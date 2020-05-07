此软件为C#编写，命名为JIM
====
>使用的集成环境为PHP Study\
MySQL版本：5.7.26

1.环境里有两个数据库，分别为

    jim
    talkdata
其中 `jim` 里存在一个“user”表用了保存用户信息,其中三个字段,分别是`username` `userpsw` `usermail`

`talkdata` 库中的表为程序以`year_month_day`为模板自动生成

>数据库的密码为 `thisisjim1!`

#### 目前已经做到了可以(邮箱)注册，登录，和收发信息

### 使用时请设置 `mailClass.cs` 的邮箱账号密码，不然会导致无法邮箱发送注册验证码 

![登录](https://s1.ax1x.com/2020/05/07/YZOzjO.png)


![注册](https://s1.ax1x.com/2020/05/07/YZOxgK.png)
![发送信息界面](https://s1.ax1x.com/2020/05/07/YZXpuD.png)
![发送注册码](https://s1.ax1x.com/2020/05/07/YZOv36.png)

