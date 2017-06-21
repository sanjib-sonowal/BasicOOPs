using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp
{
    public class Polymorphism
    {

    }

    /// <summary>
    /// Class demonstrate OVERLOADING.
    /// </summary>
    public class Print
    {

        public void display(string name)
        {
            Console.WriteLine("Your name is : " + name);
        }

        public void display(string name, int age)
        {
            Console.WriteLine(string.Format("Hi {0}, your age is {1}.", name, age));
        }
    }

    /// <summary>
    /// Class demonstrate OVERLOADING.
    /// </summary>
    public class Shape
    {
        public void Area(float r)
        {
            float a = (float)3.14 * r;
            Console.WriteLine("Area of a circle: {0}", a);
        }

        public void Area(float l, float b)
        {
            float x = (float)l * b;
            Console.WriteLine("Area of a rectangle: {0}", x);

        }

        public void Area(float a, float b, float c)
        {
            float s = (float)(a * b * c) / 2;
            Console.WriteLine("Area of a circle: {0}", s);
        }
    }

    /// <summary>
    /// Class demonstrate OVERRIDING.
    /// </summary>
    public class BaseClass
    {
        public virtual void Function1()
        {
            Console.Write("Base Class Method");
        }
    }
    // Derived class
    public class DerivedClass : BaseClass
    {
        public override void Function1()
        {
            Console.Write("Derived Class Method");
            //base.Method1();
        }
    }
}
