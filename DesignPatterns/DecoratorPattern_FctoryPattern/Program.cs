using System;
namespace DecoratorPattern_FactoryPattern
{
    public class Program
    {
    
        public static void Main(string[] args)
        {
            Computer computer = new Computer();
            Console.WriteLine(computer.description());

            Disk disk = new Disk(new Computer());
            Console.WriteLine(disk.description());
        }
    }
}