// See https://aka.ms/new-console-template for more information

namespace ExceptionProgramms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                //throw new Exception();
                throw new CustomException("This is a custom exception");
            }
            catch (CustomException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }
    }
}

