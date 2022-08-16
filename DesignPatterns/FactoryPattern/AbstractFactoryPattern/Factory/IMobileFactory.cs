using AbstractFactoryPattern.Product;

namespace AbstractFactoryPattern.Factory
{
    public interface IMobileFactory
    {
        IMobile CreateMobile(MobileType type);
    }
    
}