using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadProgram.ThreadPoolProgram
{
    internal class ThreadObjectApp
    {
        static void Main(string[] args)
        {
            //Execution with threadpool object
            //uses thread object to call the test method
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(MyTask)
                {
                    Name = "Thread" + i
                };
                thread.Start();
                Console.Read();
            }
        }

        public static void MyTask(object? obj)
        {
            Thread thread = Thread.CurrentThread;
            string message = $"Is Background Task: {thread.IsBackground}, Thread Pool: {thread.IsThreadPoolThread}, Thread ID: {thread.ManagedThreadId}";
            Console.WriteLine(message);
        }
    }
}
