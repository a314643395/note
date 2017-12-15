using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 委托
{
    class Program
    {
        public delegate void BuyTicketDg();
        static void Main(string[] args)
        {
            MrZhang mz=new MrZhang();
            BuyTicketDg buyTicketDg = new BuyTicketDg(mz.BuyTicket);
            buyTicketDg += mz.BuyMovie;
            buyTicketDg();
            Console.ReadKey();
        }
    }

    public class MrZhang
    {
        public  void BuyTicket()
        {
            Console.WriteLine("小张去买票了！");
        }
        public  void BuyMovie()
        {
            Console.WriteLine("小张又去买票了！");
        }

    }
}
