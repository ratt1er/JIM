此软件为C#编写，命名为JIM
====
>使用的集成环境为PHP Study\
MySQL版本：5.7.26

请在[configClass.cs](https://github.com/ratt1er/JIM/blob/master/config/configClass.cs)中修改配置项

    public class configClass
    {

        public static string serverip = "127.0.0.1";
        public static string databaseip = "localhost";
        public static int databaseport = 3306;
        public static int listenport = 10086;
        public static string psw = "thisisjim1!";
        public static string databaseusername = "root";
    }

1.环境里有四个数据库，分别为

>"jim","friends", "keydata", "login_information", "talkdata"

其中 `jim` 里放置用户信息（账号密码等）  
其中 `friends` 里放置用户的好友列表  
其中 `keydata` 里放置用户的登录key，可以以此验证用户操作是否合法，每个用户key登录可获得，退出即毁  
其中 `login_information` 里放置用户操作信息，如登录退出  


#### 目前已经做到了可以登录和收发信息

### 初次使用请使用[Server项目](https://github.com/ratt1er/JIM/tree/master/Server)初始化数据库
![初始化界面](https://s3.ax1x.com/2021/02/01/yeKuHH.png)

