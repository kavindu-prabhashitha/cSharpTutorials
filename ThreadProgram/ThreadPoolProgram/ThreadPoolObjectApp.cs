namespace ThreadProgram.ThreadPoolProgram
{
    public class ThreadPoolObjectApp
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(MyTask));
            }
            Console.Read();

        }

        public static void MyTask(object? obj)
        {
            Thread thread = Thread.CurrentThread;
            string message = $"Is Background Task: {thread.IsBackground}, Thread Pool: {thread.IsThreadPoolThread}, Thread ID: {thread.ManagedThreadId}";
            Console.WriteLine(message);
        }
    }
}
