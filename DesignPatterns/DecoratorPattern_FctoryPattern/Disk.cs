namespace DecoratorPattern_FactoryPattern
{
    public class Disk : ComponentDecorator
    {
        public Computer computer;

        public Disk(Computer c)
        {
           this.computer = c;
        }
        public override string description()
        {
            return computer.description()+" and a disk";
        }
    }
}