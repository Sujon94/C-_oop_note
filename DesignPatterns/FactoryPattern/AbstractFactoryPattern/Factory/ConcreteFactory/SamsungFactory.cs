using AbstractFactoryPattern.Product;
using AbstractFactoryPattern.Factory;

namespace AbstractFactoryPattern.Factory.ConcreteFactory
{
    public class SamsungFactory : IMobileFactory
    {
        public IMobile CreateMobile(MobileType type)
        {
            switch (type)
            {
                case MobileType.GalaxyA:
                    return new SamsunGalaxyA();
                case MobileType.GalaxyS:
                    return new SamsunGalaxyS();
                case MobileType.GalaxyZ:
                    return new SamsunGalaxyZ();
                default:
                    throw new Exception("Type not found.");
            }
        }
    }
}
