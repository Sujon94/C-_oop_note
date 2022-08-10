using System;
using  DesignPatterns.DecoratorPattern.DecoratorPattern;

namespace DesignPatterns.DecoratorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA a = new ConcreteDecoratorA();
            ConcreteDecoratorB b = new ConcreteDecoratorB();

            a.SetComponent(c);
            b.SetComponent(a);
            b.Operation();
            
        }
    }
}