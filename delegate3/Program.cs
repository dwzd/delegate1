using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate3
{
    public delegate void DelegateTest();
    class Program
    {
        static void Main(string[] args)
        {
            //Multicast delegate
            DelegateTest dt = () => { };
            dt = T1;
            dt += T2;
            dt += T3;
            dt += T4;
            dt();

            Console.ReadLine();
        }

        public static void T1()
        {
            Console.WriteLine("Test1");
        }
        public static void T2()
        {
            Console.WriteLine("Test2");

        }
        public static void T3()
        {
            Console.WriteLine("Test3");
        }
        public static void T4()
        {
            Console.WriteLine("Test4");
        }
    }

}