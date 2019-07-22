using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer jason = new Customer();
            jason.LastName = "ikenawa";
            
            Console.WriteLine("Last Name :{0}",jason.LastName);
        }
    }
}
