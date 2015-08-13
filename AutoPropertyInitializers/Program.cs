using System;

namespace AutoPropertyInitializers
{
    /*public class Customer
    {
        public Customer()
        {
            customerID = Guid.NewGuid();
        }

        public Guid customerID { get; set; }
    }*/

    public class Customer
    {
        public Guid customerID { get; set; } = Guid.NewGuid();
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
