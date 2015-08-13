using System;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace AsyncInACatchAndFinallyBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Before caller " + Thread.CurrentThread.ManagedThreadId);
                CallerMethod();
                Console.WriteLine("After caller " + Thread.CurrentThread.ManagedThreadId);
            } while (Console.ReadKey().Key != ConsoleKey.Q);
        }

        public static async void CallerMethod()
        {
            try
            {
                throw new Exception("Error");
            }
            catch (Exception)
            {
                await Task.Delay(2000);
                WriteLine("Waiting 2 seconds in catch");
            }
            finally
            {
                await Task.Delay(2000);
                WriteLine("Waiting 2 seconds in finally");
            }
        }        
    }
}
