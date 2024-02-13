using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.design
{
    public abstract class AbstractFactory
    {
        protected abstract IProduct CreateProduct();
        public IProduct GetProduct()
        {
            IProduct product = CreateProduct();
            product.PrintProductType();
            return product;
        }
    }

    //Factory Mathod:
    public enum ProductType
    {
        ProductA, ProductB
    }

    public class FactoryMathod
    {
        public IProduct SomeOperation(ProductType type)
        {
            IProduct product = CreateProduct(type);
            product.PrintProductType();
            return product;
        }

        public IProduct CreateProduct(ProductType type)
        {
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
    public class ProductFactoryA : AbstractFactory
    {
        protected override IProduct CreateProduct()
        {
            return new ConcreteProductA();
        }
    }

    public class ProductFactoryB : AbstractFactory
    {
        protected override IProduct CreateProduct()
        {
            return new ConcreteProductB();  
        }
    }

    public interface IProduct
    {
        public void PrintProductType();
    }

    public class ConcreteProductA : IProduct
    {
        public void PrintProductType()
        {
            Console.WriteLine("This is ConcreteProductA.");
        }
    }

    public class ConcreteProductB : IProduct
    {
        public void PrintProductType()
        {
            Console.WriteLine("This is ConcreteProductB.");
        }
    }

    public class FactoryTest
    {
        public static void Foo()
        {
            //Factory Mathod:
            FactoryMathod fm = new FactoryMathod();
            fm.SomeOperation(ProductType.ProductA);
            fm.SomeOperation(ProductType.ProductB);

            //Abstract Factory:
            ProductFactoryA fa = new ProductFactoryA();
            ProductFactoryB fb = new ProductFactoryB();

            IProduct product1 = fa.GetProduct();
            IProduct product2 = fb.GetProduct();
        }
    }
}
