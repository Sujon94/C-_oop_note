using System;

namespace AbstractFactoryPattern.Product
{
    public class SamsunGalaxyA : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Galaxy A");
        }

        public void CameraSpecification()
        {
            Console.WriteLine("64 MP Primary Camera. 8 MP Secondary Camera");
        }
    }
}