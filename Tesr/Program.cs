using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Tesr
{

    
    class Program
    {
        static void Main(string[] args)
        {
            Assembly ass;
            string s="";
            ass = Assembly.LoadFile(@"C:\TestClass.dll");
            Type t = ass.GetType("TestClass.TestClass1");
            object o = System.Activator.CreateInstance(t, new object[]{});
            System.Reflection.MethodInfo m = t.GetMethod("WriteString");
            string str = (string)m.Invoke(o, new object[] { "收拾收拾", 1 });
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
