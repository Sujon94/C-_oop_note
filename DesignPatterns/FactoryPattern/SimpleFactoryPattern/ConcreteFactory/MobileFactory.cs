using SimpleFactoryPattern.Product;
using SimpleFactoryPattern.ConcreteProduct;

namespace SimpleFactoryPattern.ConcreteProduct
{
    public class MobileFactory
    {
        public static IProduct createMobile(BrandType type)
        {
            switch (type)
            {
                case BrandType.Samsung:
                    return new Samsung();
                case BrandType.Huwaei:
                    return new Huwaei();
                default:
                    throw new Exception("Invalid Brand type.");
                
            }
        }
    }
}