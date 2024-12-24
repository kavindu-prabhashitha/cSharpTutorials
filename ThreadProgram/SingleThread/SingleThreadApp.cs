using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadProgram.SingleThread
{
    public class SingleThreadApp
    {
        static void Main(string[] args)
        {
            Method1();
            Console.WriteLine("Method 1 executed completed");
            Method2();
            Console.WriteLine("Method 2 executed completed");
            Method3();
            Console.WriteLine("Method 3 executed completed");
            Console.ReadLine();
        }

        private static void Method3()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Counter : " + i);
            }
        }

        private static void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Counter : " + i);
            }
        }

        private static void Method1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Counter : " + i);
            }
        }
    }
}
