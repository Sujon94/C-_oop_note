using SimpleFactoryPattern.Product;
using System;

namespace SimpleFactoryPattern.ConcreteProduct
{
    public class Samsung : IProduct
    {
        public void GetProduct()
        {
            Console.WriteLine("Samsung Mobile.");
        }
    }
}