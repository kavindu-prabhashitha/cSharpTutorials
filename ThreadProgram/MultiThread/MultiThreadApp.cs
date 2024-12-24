using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadProgram.MultiThread
{
    internal class MultiThreadApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");
            //Creating Threads
            Thread thread01 = new Thread(Method1) { Name = "Thread01" };
            Thread thread02 = new Thread(Method2) { Name = "Thread02" };
            Thread thread03 = new Thread(Method3) { Name = "Thread03" };

            //Executing the methods
            thread01.Start();
            thread02.Start();
            thread03.Start();

            Console.WriteLine("Main Thread Ended/Completed");
            Console.ReadLine();
        }
        private static void Method1()
        {
            Console.WriteLine("Method 01 Started using " + Thread.CurrentThread.Name);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method 01 : " + i);
            }
            Console.WriteLine("Method 01 Started using " + Thread.CurrentThread.Name);
        }
        private static void Method2()
        {
            Console.WriteLine("Method 02 Started using " + Thread.CurrentThread.Name);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method 02 : " + i);
                if (i == 2)
                {
                    Console.WriteLine("Method 02 Db operation started");
                    //Sleep for 5 seconds
                    Thread.Sleep(5000);
                    Console.WriteLine("Method 02 Db operation ended");
                }
            }
            Console.WriteLine("Method 02 Ended using " + Thread.CurrentThread.Name);
        }
        private static void Method3()
        {
            Console.WriteLine("Method 03 Started using " + Thread.CurrentThread.Name);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method 03 : " + i);
            }
            Console.WriteLine("Method 03 Ended using " + Thread.CurrentThread.Name);
        }


    }
}
