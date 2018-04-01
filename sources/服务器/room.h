#include <stdio.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>9
#include <string.h>
#include <vector>
const int room_num = 10;
using namespace std;
class player
{
public:
    sockaddr_in ip;
    char *name;
    int score;
public:
    player(sockaddr_in p,char *name)
    {
        this->ip=p;
        this->name=name;
        this->score=0;
    }
};
class room
{
    int send_fd;
    bool isbegin[room_num];
    int sodr[room_num];
    int los[room_num];

    //struct sockaddr_in addr;
    vector < struct player> rooms[room_num];
public :
    room()
    {
        memset(isbegin,0,sizeof(isbegin));
        send_fd = socket(AF_INET,SOCK_DGRAM,0);
        memset(sodr,0,sizeof(sodr));


    }

    void  add_cli(struct sockaddr_in p,int rn,char *name)     //  one client
    {

        if(rooms[rn].size() >= 6)return ;

        p.sin_port = htons(613);
        player pl = *new player(p,name);

        rooms[rn].push_back(pl);
        cout<<"add_cli"<<endl;
       this->f5(rn);

    }
    void quit_cli(struct sockaddr_in p,int rn)
    {
        //  if(rooms[rn].find(p) == 1)
        //  {
        for(int i = 0; i < rooms[rn].size(); i++)
        {
            if(rooms[rn][i].ip.sin_addr.s_addr == p.sin_addr.s_addr)
            {
                rooms[rn].erase(rooms[rn].begin()+i);
                f5(rn);
                return ;
            }
        }

        // }
    }
    void bro_message(char *buff,int rn)
    {
    cout<<"bro"<<endl;
        for(int i = 0; i < rooms[rn].size(); i++)
        {
            sendto(send_fd, buff, strlen(buff), 0, (struct sockaddr *)&rooms[rn][i].ip, sizeof(rooms[rn][i].ip));
        }
    }
    void f5(int rn)
    {
        cout<<"f5"<<endl;
        char buff[1024];
        buff[0]=53;
        buff[1]=rn+48;
        int i;
        int kl;
        for( i = 2,kl=0; kl < rooms[rn].size(); i=i+6)
        {
            buff[i]  = kl+48;
            int k = 0;
            for(int j = i+1; j<=i+5; j++)
                buff[j]=rooms[rn][kl].name[k++];
            buff[i+5]=rooms[rn][kl].score+48;
            kl++;
        }
       for(;i <100;i++)
       buff[i] = '1';
        buff[100]='\0';
       cout<<buff<<"????";
        bro_message(buff,rn);
    }
    void allroom(struct sockaddr_in p)
    {

        p.sin_port = htons(613);
        char buff[1024];
        buff[0]=6+48;
        buff[1]=7+48;
        for(int i = 2;i<=5;i++)
        {
            buff[i] = 49;
        }
       // buff[]
        int j = 1;
        int i;
        for(i = 6; j <=room_num; i=i+3)
        {
            buff[i]=j+48;
            buff[i+1]=rooms[j].size()+48;
            buff[i+2]=isbegin[j++]+48;
        }
        buff[i] = '\0';
        cout<<buff<<endl;

        sendto(send_fd, buff, strlen(buff), 0, (struct sockaddr *)&p, sizeof(p));


    }


    void getscore(int rn,int size)
    {
        rooms[rn][size].score+= los[rn];
        los[rn]--;
        if(los[rn]==0)
        {
            gameover(rn);

        }
        f5(rn);
    }

    void bdraw(int rn,int size)
    {
        char buff[1024];
        buff[0] = 7+48;
        buff[1] =rn+48;
        for(int i = 2;i<=5;i++)
        {
            buff[i] = 49;
        }
            for(int i = 6;i<=15;i++)
        {
            buff[i] =1;
        }
        buff[16] ='/0';
        // sendto(send_fd , buff, strlen(buff), 0, (struct sockaddr *)&p, sizeof(p));
        sendto(send_fd, buff, strlen(buff), 0, (struct sockaddr *)&rooms[rn][size].ip, sizeof(rooms[rn][size].ip));
        los[rn] = rooms[rn].size();

    }
    void gamebegin(int rn)
    {
        isbegin[rn]=1;
        bdraw(rn,0);
        sodr[rn]=1;

    }
    void gameover(int rn)
    {
        if(sodr[rn]==rooms[rn].size())
        {
            isbegin[rn] = 0;
            return;
        }
        bdraw(rn,sodr[rn]);
        sodr[rn] ++;
    }
};
