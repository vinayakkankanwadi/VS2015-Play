using static System.Console;

namespace StringInterpolation
{
    class StringInterpolations
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        static void Main(string[] args)
        {
            StringInterpolations si = new StringInterpolations();
            si.FirstName = "Visual";
            si.LastName = "Studio";
            si.Age = 2015;

            WriteLine(string.Format("Old Way Name : {0} {1}\nAge : {2}", si.FirstName, si.LastName, si.Age));     // Old Way      
            // Putting String Where I need 
            WriteLine($"New Way Name : {si.FirstName} {si.LastName}\nAge : {si.Age}");            // New Way
            ReadLine();
        }
    }
}
