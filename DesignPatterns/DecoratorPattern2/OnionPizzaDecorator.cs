namespace DesignPatterns.DecoratorPattern2
{
    public class OnionPizzaDecorator : PizzaDecorator
    {
        public OnionPizzaDecorator(IPizza ipizza) : base(ipizza)
        {
            Console.WriteLine("OnionPizzaDecorator");

        }

        public override string GetApizza()
        {
            string pizza = base.GetApizza();
            pizza += "With extra onion";
            return pizza;
        }
    }
}