namespace DesignPatterns.DecoratorPattern2
{
    public class CheesePizzaDecorator : PizzaDecorator
    {
       public CheesePizzaDecorator(IPizza ipizza) : base(ipizza)
       {
            Console.WriteLine("CheesePizzaDecorator");

       }

        public override string GetApizza()
        {
            string pizza = base.GetApizza();    //"This is a normal pizza"
            pizza += "With extra cheese."+FriedProperly();
            return pizza;
        }

        string FriedProperly()
        {
            return "Properly fried.";
        }
    }
}