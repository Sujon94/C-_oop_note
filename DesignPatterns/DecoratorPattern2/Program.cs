using System;

namespace DesignPatterns.DecoratorPattern2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConcreteIPizza cp = new ConcreteIPizza();
            CheesePizzaDecorator cpd = new CheesePizzaDecorator(cp);
            Console.WriteLine(cpd.GetApizza());
            
            OnionPizzaDecorator opd = new OnionPizzaDecorator(cpd);
            Console.WriteLine(opd.GetApizza());
        }
    }
}