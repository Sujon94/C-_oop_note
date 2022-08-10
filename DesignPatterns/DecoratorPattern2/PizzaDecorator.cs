namespace DesignPatterns.DecoratorPattern2
{
    public class PizzaDecorator : IPizza
    {
        IPizza _ipizza;

        public PizzaDecorator(IPizza ipizza)
        {
            Console.WriteLine("PizzaDecorator");
            _ipizza = ipizza;
        }

        public virtual string GetApizza()
        {
            return _ipizza.GetApizza();
        }
    }
}