using System;
using AbstractFactoryPattern.Product;
using AbstractFactoryPattern.Factory;
using AbstractFactoryPattern.Factory.ConcreteFactory;

namespace AbstractFactoryPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IMobileFactory mobileFactory = new SamsungFactory();
            IMobile mobile = mobileFactory.CreateMobile(MobileType.GalaxyA);
            mobile.GetMobile();
            mobile.CameraSpecification();
        }
    }
}