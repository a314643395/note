using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConsoleApplication2
{
    public class RefClass
    {
        private int _test3;
        private int _test1 { get; set; }
        protected int Test2 { get; set; }
        public int Test3 { get; set; }

        public void Show(String str)
        {
            Console.WriteLine(str + "sdsds");
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof (RefClass);
            MemberInfo[] minfos = t.GetMembers();
            foreach (MemberInfo min in minfos)
            {
                Console.WriteLine(min.Name);
             
            }
            Console.ReadKey();
        }
    }
}
