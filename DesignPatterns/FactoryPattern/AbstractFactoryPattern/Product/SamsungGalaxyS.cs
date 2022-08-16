using System;
using AbstractFactoryPattern.Product;

namespace AbstractFactoryPattern.Product
{
    public class SamsunGalaxyS : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Galaxy S");
        }
        
        public void CameraSpecification()
        {
            Console.WriteLine("48 MP Primary Camera. 8 MP Secondary Camera");
        }
    }
}