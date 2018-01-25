using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            list.RemoveAll(a => a > 9);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
