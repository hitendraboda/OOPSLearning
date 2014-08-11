using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    /*
    abstract class absClass1
    {
        public abstract int AddTwoNumbers(int Num1, int Num2);
        public abstract int MultiplyTwoNumbers(int Num1, int Num2);
    }

    //Abstract Class2
    abstract class absClass2 : absClass1
    {
        //Implementing AddTwoNumbers
        public override int AddTwoNumbers(int Num1, int Num2)
        {
            return Num1 + Num2;
        }
    }

    //Derived class from absClass2
    class absDerived : absClass2
    {
        //Implementing MultiplyTwoNumbers
        public override int MultiplyTwoNumbers(int Num1, int Num2)
        {
            return Num1 * Num2;
        }
    }
    */

    //Creating an Abstract Class
    abstract class absClass
    {
        //A Non abstract method
        public int AddTwoNumbers(int Num1, int Num2)
        {
            return Num1 + Num2;
        }

        //An abstract method, to be
        //overridden in derived class
        public abstract int MultiplyTwoNumbers(int Num1, int Num2);
    }

    //A Child Class of absClass
    class absDerived : absClass
    {
        [STAThread]
        static void Main(string[] args)
        {
            //You can create an
            //instance of the derived class

            absDerived calculate = new absDerived();
            int added = calculate.AddTwoNumbers(10, 20);
            int multiplied = calculate.MultiplyTwoNumbers(10, 20);
            Console.WriteLine("Added : {0}, Multiplied : {1}", added, multiplied);
            Console.ReadKey();
        }

        //using override keyword,
        //implementing the abstract method
        //MultiplyTwoNumbers
        public override int MultiplyTwoNumbers(int Num1, int Num2)
        {
            return Num1 * Num2;
        }
    }
}
