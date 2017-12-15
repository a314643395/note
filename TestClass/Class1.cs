using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestClass
{
    public class TestClass1
    {
        public void WriteString(string s, int i)
        {
            Console.WriteLine("WriteString:" + s + i);
        }

        public static void StaticWriteString(string s)
        {
            Console.WriteLine("StaticWriteString" + s);
        }

        public static void NonePataWriteString()
        {
            Console.WriteLine("NonePataWriteString");
        }
    }
}
