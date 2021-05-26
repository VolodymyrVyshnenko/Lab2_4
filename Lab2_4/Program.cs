using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_4
{
    public class MyFactory<T> where T : new()
    {
        public static T FacrotyMethod()
        {
            return new T();
        }
    }

    public class MyClass
    {
        public int Val { get; set; }
        public MyClass(int i)
        {
            Val = i;
        }
        public MyClass() { }
    }

    public class MyType
    {
        public int a;

        public MyType(int a)
        {
            this.a = a;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            var instance = MyFactory<MyType>.FacrotyMethod();

            Console.WriteLine(instance.GetType());
            Console.ReadKey();
        }
    }
}