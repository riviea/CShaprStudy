using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.design
{
    public abstract class Creator
    {
        public void someOperation()
        {
            iProduct p = createProduct();
            p.doStuff();
        }

        public abstract iProduct createProduct();
    }

    public class ConcreteCreateA : Creator
    {
        public override iProduct createProduct()
        {
            return new ConcreteProductA();
        }
    }

    public class ConcreteCreateB : Creator
    {
        public override iProduct createProduct()
        {
            return new ConcreteProductB();
        }
    }

    public interface iProduct
    {
        public void doStuff();
    }

    public class ConcreteProductA : iProduct
    {
        public void doStuff()
        {
            Console.WriteLine("doStuff from ConcreteProductA.");
        }
    }

    public class ConcreteProductB : iProduct
    {
        public void doStuff()
        {
            Console.WriteLine("doStuff from ConcreteProductB.");
        }
    }

    internal class Abstract_Factory
    {
        public Creator creator;

        public void Foo()
        {
            string config = "ccB";

            if (config.CompareTo("ccA") == 0)
                creator = new ConcreteCreateA();
            else if (config.CompareTo("ccB") == 0)
                creator = new ConcreteCreateB();
            else
                throw new Exception("Error!");

            creator.someOperation();
        }
    }
}
