namespace assignment
{
    internal class Program
    {
        public int square(int x)
        {
            return x * x;
        }
        

        static void Main(string[] args)
        {
            /*
             1. Write a program that can compute square of a number immediately as it
                object is instantiated.
             */
            Program p = new Program();
            Console.WriteLine(p.square(5));


            /*
             2. ERROR...bcz we have parameterized constructor that takes an integer argument, 
            but the main method is not passing any argument while creating an object of Demo class. 
            Therefore, the compiler cannot find a suitable constructor to match the invocation and generates an error.
            To rectify this error, we need to provide an integer argument while creating the object of the Demo class
             */

            /*
             3.Constructor method called.
             */

            /*
             4. Write a program that has a parent class named as aptech and then
            extend it to child classes like aptechNN, aptechNk and show the use of inheritance
             */
            AptechNN apt1 = new AptechNN("xyz");
            AptechNN apt2 = new AptechNN("abd");


            /*
             5.
             */


            /*
             6.constructor invoked once automatically, when object instantiated while method can called several times
            constructor name and class name should be same while method has different names
            constrcutor does not have return type while method can/cannot have...
             */


            /*
             7.
             */
            Emp e1 = new Emp("abcd");

            /*
             8.Hello
             */


            /*
             9.
             */


            /*
             10.Compile time error
             */


        }
    }

     class Aptech
    {
        public Aptech(string name)
        {
            Console.Write($"Welcome {name},");
        }
    }

     class AptechNN : Aptech
    {
        public AptechNN(string name) : base(name)
        {
            Console.WriteLine("Learning programming at AptechNN.");
        }
    }

     class AptechNk : Aptech
    {
        public AptechNk(string name) : base(name)
        {
            Console.WriteLine("Learning programming at AptechNk.");
        }
    }

     class Emp
    {
        string name;

        public Emp(string name)
        {
            this.name = name;
        }
    }

   
}