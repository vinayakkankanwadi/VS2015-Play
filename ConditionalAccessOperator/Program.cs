using System;
using static System.Console;

namespace ConditionalAccessOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayName("Test");
            DisplayName(null);
        }

        public static void DisplayName(String name)
        {
            /*string dispName = "Guest";    // Old Way 
            if( name != null)
            {
                dispName = name;
            }*/

            string dispName = name?.ToString() ?? "Guest"; // New way using ?. to check null
            WriteLine($"Hello {dispName}");
        }
    }
}
