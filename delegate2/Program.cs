using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate2
{
    public delegate void DelegateHi(string name);

    class Program
    {
        static void Main(string[] args)
        {
           DelegateHi dh = delegate (string name) {
               Console.WriteLine("Bon jour! " + name);
            };
            dh("Java");
            //The 2nd way uses Lambda expression
           dh = (string name) => { Console.WriteLine("Ca va bien! " + name); };
            dh("Python"); 

            Console.ReadLine();
        }

        //public static void SayHi(string name, DelegateHi delegateHi)
        //{
        //    delegateHi(name);
        //}
    }
}
