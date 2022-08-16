using System;
using SimpleFactoryPattern.ConcreteProduct;
using SimpleFactoryPattern.Product;

namespace SimpleFactoryPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IProduct Iproduct = MobileFactory.createMobile(BrandType.Samsung);
            Iproduct.GetProduct();

            IProduct anotherPeroduct = MobileFactory.createMobile(BrandType.Huwaei);
            anotherPeroduct.GetProduct();
        }
    }
}
