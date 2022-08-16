using System;

namespace AbstractFactoryPattern.Product
{
    public class HuwaeiNova : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Huwaei Nova");
        }

        public void CameraSpecification()
        {
            Console.WriteLine("28 MP Primary Camera. 5 MP Secondary Camera");
        }
    }
}