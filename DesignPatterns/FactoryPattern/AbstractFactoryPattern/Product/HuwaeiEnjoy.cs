using System;

namespace AbstractFactoryPattern.Product
{
    public class HuwaeiEnjoy : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Huwaei Enjoy");
        }

        public void CameraSpecification()
        {
            Console.WriteLine("48 MP Primary Camera. 8 MP Secondary Camera");
        }
    }
}