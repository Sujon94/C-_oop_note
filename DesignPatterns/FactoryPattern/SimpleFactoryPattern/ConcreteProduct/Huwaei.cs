using SimpleFactoryPattern.Product;
using System;

namespace SimpleFactoryPattern.ConcreteProduct
{
    public class Huwaei : IProduct
    {
        public void GetProduct()
        {
            Console.WriteLine("Huwaei mobile.");
        }
    }
}