using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadProgram.ThreadPoolProgram
{
    internal class PerformanceTesting
    {
        static void Main(string[] args)
        {
            //Warmup Code start
            //The for loop within the Main method is for warm - up.
            //This is because when we run the code for the first time, compilation happens and compilation takes some time and we don’t want to measure that.
            for (int i = 0; i < 10; i++)
            {
                ExecuteMethodWithThreadPool();
                ExecuteMethodWithThread();
            }
            //Warmup Code start
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Execution using Thread");
            stopwatch.Start();
            ExecuteMethodWithThread();
            stopwatch.Stop();
            Console.WriteLine("Time consumed by MethodWithThread is : " +
                                 stopwatch.ElapsedTicks.ToString());

            stopwatch.Reset();
            Console.WriteLine("Execution using Thread Pool");
            stopwatch.Start();
            ExecuteMethodWithThreadPool();
            stopwatch.Stop();
            Console.WriteLine("Time consumed by MethodWithThreadPool is : " +
                                 stopwatch.ElapsedTicks.ToString());

            Console.Read();
        }

        public static void ExecuteMethodWithThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(TestMethod);
                thread.Start();
            }
        }
        public static void ExecuteMethodWithThreadPool()
        {
            for (int i = 0; i < 10; i++)
            {
                //QueueUserWorkItem - queues a method for execution. the method executes when a thread pool thread becomes available
                ThreadPool.QueueUserWorkItem(new WaitCallback(TestMethod));
            }
        }
        public static void TestMethod(object? obj)
        {
        }
    }
}
