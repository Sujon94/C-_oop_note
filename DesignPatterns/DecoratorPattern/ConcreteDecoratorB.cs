namespace DesignPatterns.DecoratorPattern.DecoratorPattern
{
    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddBehaviour();
            Console.WriteLine("ConcreteDecoratorB.Operation");
        }

        void AddBehaviour()
        {
            Console.WriteLine("ConcreteDecoartorB.AddBehaviour");
        }
    }
}