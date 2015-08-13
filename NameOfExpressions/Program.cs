using System;
using static System.Console;

namespace NameOfExpressions
{
    class Program
    {
        static void DisplayName(string name)
        {
            try
            {
                //throw new Exception("name");          // Before
                throw new Exception(nameof(name));      // name of resolves issues with hard coded string literals when passing them as parameter          
            }
            catch (Exception ex) when (ex.Message == nameof(name))
            {
                WriteLine("Expection for "+ex.Message);
            }
        }

        static void Main(string[] args)
        {
            DisplayName("Dev");
        }
    }
}
