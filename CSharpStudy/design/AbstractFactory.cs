using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.design
{
    //Factory Mathod:
    public enum ProductType
    {
        ProductA, ProductB
    }

    public class FactoryMathod
    {
        public IProduct MakeProduct(ProductType type)
        {
            Console.WriteLine("We will make {0}", type.ToString());
            switch (type)
            {
                case ProductType.ProductA:
                    return new ConcreteProductA();
                case ProductType.ProductB:
                    return new ConcreteProductB();
                default:
                    throw new NotSupportedException();
            }
        }
    }

    // Abstract Factory:
    public abstract class AbstractFactory
    {
        protected abstract IProduct MakeProduct();
        public IProduct GetProduct()
        {
            IProduct product = MakeProduct();
            product.PrintProductInfo();
            return product;
        }
    }

    public class ProductFactoryA : AbstractFactory
    {
        protected override IProduct MakeProduct()
        {
            ConcreteProductA product = new ConcreteProductA();
            product.maker = GetType().Name;

            return product;
        }
    }

    public class ProductFactoryB : AbstractFactory
    {
        protected override IProduct MakeProduct()
        {
            ConcreteProductB product = new ConcreteProductB();
            product.maker = GetType().Name;
            product.legion = "korea";

            return product;
        }
    }

    public interface IProduct
    {
        public void PrintProductInfo();
    }

    public class ConcreteProductA : IProduct
    {
        public string? maker;

        public void PrintProductInfo()
        {
            Console.WriteLine("This is {0}. Maker: {1}", GetType().Name, maker);
        }
    }

    public class ConcreteProductB : IProduct
    {
        public string? maker;
        public string? legion;

        public void PrintProductInfo()
        {
            Console.WriteLine("This is {0}, Maker: {1}, legion: {2}", GetType().Name, maker, legion);
        }
    }

    public class FactoryTest
    {
        public static void Foo()
        {
            //Factory Mathod:
            FactoryMathod fm = new FactoryMathod();
            fm.MakeProduct(ProductType.ProductA);
            fm.MakeProduct(ProductType.ProductB);

            //Abstract Factory:
            AbstractFactory fa = new ProductFactoryA();
            AbstractFactory fb = new ProductFactoryB();

            IProduct product1 = fa.GetProduct();
            IProduct product2 = fb.GetProduct();
        }
    }
}
