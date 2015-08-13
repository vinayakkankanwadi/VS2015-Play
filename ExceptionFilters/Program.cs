using System;
using static System.Console;

namespace ExceptionFilters
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception("Error");
            }
            catch (Exception ex) when (ex.Message == "Error1")
            {
                WriteLine("Caught Error1");
            }
            catch (Exception ex) when (ex.Message == "Error")
            {
                WriteLine("Caught Error");
            }
        }
    }
}
