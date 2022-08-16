using System;
using AbstractFactoryPattern.Product;

namespace AbstractFactoryPattern.Product
{
    public class SamsunGalaxyZ : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Galaxy Z");
        }

        public void CameraSpecification()
        {
            Console.WriteLine("60 MP Primary Camera. 8 MP Secondary Camera");
        }
    }
}