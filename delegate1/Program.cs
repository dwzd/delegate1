using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate1
{
    //声明委托
    public delegate string DelString(string name);

    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "send", "THIS", "to", "mars!" };

            ProStr(names, delegate (string name) //使用匿名函数，与ProStr方法的签名一样
            {
               // return name.ToUpper();
                return "\"" + name + "\"";
            });
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();

        }

        public static void ProStr(string[] name, DelString del)
        {
            for (int i = 0; i < name.Length; i++)
            {
                name[i] = del(name[i]);
            }
        }
    }
}
