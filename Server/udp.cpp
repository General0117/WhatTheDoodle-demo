#include <stdio.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <string.h>
#include<iostream>
#include "room.h"
#define SERVER_PORT 6666
#define BUFF_LEN 1024
using namespace std;
room ro;
void handle_udp_msg(int fd)
{
    char buf[BUFF_LEN];  //接收缓冲区，1024字节
    socklen_t len;
    int count;
    struct sockaddr_in clent_addr;  //clent_addr用于记录发送方的地址信息
    while(1)
    {
        memset(buf, 0, BUFF_LEN);
        len = sizeof(clent_addr);
        count = recvfrom(fd, buf, BUFF_LEN, 0, (struct sockaddr*)&clent_addr, &len);  //recvfrom是拥塞函数，没有数据就一直拥塞
        if(count == -1)
        {
            printf("recieve data fail!\n");
            return;
        }
        // printf("client:%s\n",buf);  //打印client发过来的信息
        // string a = new string(buf);
        //  cout<<"client:"<<int(buf[0])<<"  "<<int(buf[1]);

        //   memset(buf, 0, BUFF_LEN);
        //    sprintf((char*)buf, "I have recieved %d bytes data!\n", count);  //回复client
        //  printf("server:%s\n",buf);  //打印自己发送的信息给
        cout<<int(buf[0])-48<<"  "<<int(buf[1])-48<<endl;
        cout<<"                       !!!!         "<<buf<<endl;
        //ro.add_cli();
        switch(buf[0])
        {
        case 49://1

            char name[5];
            cout<<buf<<endl;
            //char aaa[5]="tony";
          //  name = aaa;
           // name = strncpy(name,&buf[2],4);
           for(int i = 0;i<4;i++)
           {
                name[i] = buf[i+2];
           }
           name[4] = '\0';


           // cout<<name<<endl;
            ro.add_cli(clent_addr,buf[1]-48,name);
            // ro.bro_message(buf,buf[1]);
            break;
        case 50://2
            //cout<<int(buf[0])<<"  "<<int(buf[1])<<endl;
            ro.quit_cli(clent_addr,buf[1]-48);
            //ro.bro_message(buf,buf[1]);
            break;
        case 51:
           // cout<<int(buf[0])<<"  "<<int(buf[1])<<endl;
            ro.bro_message(buf,buf[1]-48);
            break;
        case 52://4
            ro.bro_message(buf,buf[1]-48);
            break;
        case 53://5
            break;
        case 54://6
            ro.getscore(buf[1]-48,buf[2]-48);
            //ro.f5(buf[1]-48);
            break;
        case 55://7    game begin

            ro.gamebegin(buf[1]-48);

            break;
        case 56://8
            ro.allroom(clent_addr);
            break;
        case 57://9  game over
            ro.gameover(buf[1]-48);
            break;

        default:
            cout<<"?????"<<endl;
            break;

        }
        //   sendto(fd, buf, BUFF_LEN, 0, (struct sockaddr*)&clent_addr, len);  //发送信息给client，注意使用了clent_addr结构体指针

    }
}


/*
    server:
            socket-->bind-->recvfrom-->sendto-->close
*/

int main()
{
    int server_fd, ret;
    struct sockaddr_in ser_addr;

    server_fd = socket(AF_INET, SOCK_DGRAM, 0); //AF_INET:IPV4;SOCK_DGRAM:UDP
    if(server_fd < 0)
    {
        printf("create socket fail!\n");
        return -1;
    }

    memset(&ser_addr, 0, sizeof(ser_addr));
    ser_addr.sin_family = AF_INET;
    ser_addr.sin_addr.s_addr = htonl(INADDR_ANY); //IP地址，需要进行网络序转换，INADDR_ANY：本地地址
    ser_addr.sin_port = htons(SERVER_PORT);  //端口号，需要网络序转换

    ret = bind(server_fd, (struct sockaddr*)&ser_addr, sizeof(ser_addr));
    if(ret < 0)
    {
        printf("socket bind fail!\n");
        return -1;
    }
    printf("waiting client.............\n");
    handle_udp_msg(server_fd);   //处理接收到的数据

    // close(server_fd);
    return 0;
}
