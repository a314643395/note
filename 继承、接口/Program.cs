using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 继承_接口
{
  public  class Program
    {
        static void Main(string[] args)
        {
            //MyClass myClass=new MyClass(50,50); 
            //Console.WriteLine(myClass.SumNumber());  //继承

            IBase be=new CatClass();
            be.Speck("喵");

            IBase b=new DogClass();
            b.Speck("汪");

            Console.ReadKey();
        }
    }

  #region 继承
  
    public class BaseClass
    {
        private int a1;
        private int b1;
        public BaseClass(int a,int b)
        {
            a1 = a;
            b1 = b;
        }

        public virtual int SumNumber()
        {
            return a1 + b1;
        }
    }

    public class MyClass : BaseClass
    {
        public MyClass(int a, int b) : base(a, b){}   //实例化构造函数

        public override int SumNumber()  //重写方法，不修改可以省略
        {
            
            return base.SumNumber();
        }
    }
  #endregion

  #region 接口
    /// <note>
    ///   定义一个接口，在实现它的类中完善方法，可以直接 Ibase i=new class 
    /// </note>
    public interface IBase
    {
        void Speck(string s);
    }

    public class CatClass:IBase
    {

        public void Speck(string s)
        {
           Console.WriteLine("Cat"+s);
        }

    }

    public class DogClass : IBase
    {

        public void Speck(string s)
        {
            Console.WriteLine("Dog" + s);
        }

    }

    #endregion
}
