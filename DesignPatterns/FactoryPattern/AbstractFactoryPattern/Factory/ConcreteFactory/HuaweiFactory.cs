using AbstractFactoryPattern.Product;
using AbstractFactoryPattern.Factory;

namespace AbstractFactoryPattern.Factory.ConcreteFactory
{
    public class HuwaeiFactory : IMobileFactory
    {
        public IMobile CreateMobile(MobileType type)
        {
            switch (type)
            {
                case MobileType.Enjoy:
                    return new HuwaeiEnjoy();
                    
                case MobileType.Nova:
                    return new HuwaeiNova();
                default:
                    throw new Exception("Type not found.");
            }
        }
    }
}
