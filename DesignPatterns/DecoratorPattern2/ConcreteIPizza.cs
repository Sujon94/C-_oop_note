using System;

namespace DesignPatterns.DecoratorPattern2
{
    public class ConcreteIPizza : IPizza
    {
        public string GetApizza()
        {
            Console.WriteLine("ConcreteIPizza");
            
            return "This is a normal pizza. ";
        }
    }
}