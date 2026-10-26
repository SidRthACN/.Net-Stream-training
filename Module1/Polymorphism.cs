using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    // compile time polymorphism


    //internal class Calculator
    //{
    //    public int Add(int a, int b)
    //    {
    //        return a + b;
    //    }

    //    public int Add(int a, int b, int c)
    //    {
    //        return a + b + c;
    //    }

    //    public double Add(double a, double b)
    //    {
    //        return a + b;
    //    }

    //}

    // runtime polymorphism

    internal class Animal
    {
       public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    internal class  Dog: Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }


}
