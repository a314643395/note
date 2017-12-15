using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 事件Event
{
    //事件的发生一般都牵扯2个角色

    //事件发行者（Publisher）:一个事件的发行者，也称作是发送者（sender），其实就是个对象，这个对象会自行维护本身的状态信息，
    //当本身状态信息变动时，便触发一个事件，并通知说有的事件订阅者。

    //事件订阅者（Subscriber）:对事件感兴趣的对象，也称为Receiver，可以注册感兴趣的事件，在事件发行者触发一个事件后，
    //会自动执行这段代码。
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher=new Publisher();
            publisher.OnPublish +=new Publisher.PublisherDg(MrMing.Receive);
            publisher.issue();
            Console.ReadKey();
        }
    }
    //发布者（Publiser)
    public class Publisher
    {
        public delegate void PublisherDg();

        //在委托的机制下我们建立以个出版事件
        public event PublisherDg OnPublish;

        //事件必须要在方法里去触发，出版社发布新书方法
        public void issue()
        {
            if (OnPublish != null)
            {
                Console.WriteLine("最新一期《火影忍者》");
                OnPublish();
            }
        }

       
    }


    //Subscriber 订阅者小明
    public class MrMing
    {
        //对事件感兴趣的事情，这里指对出版社的书感兴趣
        public static void Receive()
        {
            Console.WriteLine("嘎嘎，我已经收到最新一期的《火影忍者》啦！！");
        }
    }

    //Subscriber 订阅者小张
    public class MrZhang
    {
        //对事件感兴趣的事情
        public static void Receive()
        {
            Console.WriteLine("幼稚，这么大了，还看《火影忍者》，SB小明！");
        }
    }
}
