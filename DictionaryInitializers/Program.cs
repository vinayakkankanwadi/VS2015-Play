using System.Collections.Generic;


namespace DictionaryInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dictionary<string, string> customerNames = new Dictionary<string, string>()
            {
                { "Michael Jordan", "Basketball" },
                { "Peyton Manning", "Football" },
                { "Babe Ruth", "Baseball" }
            };*/

            Dictionary<string, string> customerNames = new Dictionary<string, string>()
            {
                ["Michael Jordan"] = "Basketball",
                ["Peyton Manning"] = "Football",
                ["Babe Ruth"] = "Baseball"
            };
        }
    }
}
