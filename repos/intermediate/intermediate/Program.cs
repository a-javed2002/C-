namespace intermediate
{
    class Detail
    {
        public int id;
        public string name;
    }

    class Faculty : Detail
    {
        int salary;
    }

    class Student : Detail
    {
        int fees;
    }

    public delegate void Calculator(int a, int b);
    public delegate void MyDelegate(int a);
    public delegate int MyDelegate2(int a);
    public delegate int MyDelegate3(int a, int b);
    internal class Program
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Add result is " + (a + b));
        }

        public static void Sub(int a, int b)
        {
            Console.WriteLine("Sub result is " + (a - b));
        }

        public static void Mul(int a, int b)
        {
            Console.WriteLine("Mul result is " + (a * b));
        }

        public static void Div(int a, int b)
        {
            Console.WriteLine("Div result is " + (a / b));
        }
        public static void MyMethod(int a)
        {
            a += 10;
            Console.WriteLine("a is " + a);

        }
        public static void MyMethod2(MyDelegate del, int a)
        {
            a += 10;
            del(a);
        }
        static void Main(string[] args)
        {
            Faculty f1 = new Faculty();
            f1.id = 123;
            f1.name = "asd";

            /*
            indexers 
            like properties this is used but in prop we can set or get one value of member
            but in indexer we have arrays and collections...with cinditio on them like prop
             */
            //use all access modifers and have return type
            Employee emp1 = new Employee();
            emp1[0] = 5;
            Console.WriteLine(emp1[0]);
            //unlike prop,indexers can also be overloaded
            Employee emp2 = new Employee();
            emp2[0, 3] = 5;
            Console.WriteLine(emp2[0]);

            //copy construtor --> we made a constructor with arguments of passing same obj in it and setting up teh values

            //encapsulation --> access modifiers

            //abstraction --> abstract classes & interfaces

            //single level inheritence
            //multi level inheritence
            //hiraerical inheritence
            //multiple inheritence...with teh help of interafces

            //polymorphism
            //compile time --> overloading
            //run-time --> overriding

            //new and override with virtual
            //parent p1= new child()....in new call parent methods
            //parent p1= new child()....in override call child methods


            Console.WriteLine("\nDelegates");
            //Delegate is Reference Type
            //delegate & method signature should be same
            //delegates has no implementations...hence no body...we can use invoke method with deleagte
            //delegates are used to encapsulate methods
            //delegates can point to one or more methods
            //we amke objects of delegates thta have reference of methods..that need to be invoked...
            //invoking delegate will execute the referenced method at run-time
            //return type of delegate and method should be same
            Calculator calc = new Calculator(Add);
            calc.Invoke(2, 2);
            calc = Sub;
            //invoke is optional
            calc(2, 2);
            calc = Mul;
            calc(2, 2);
            calc = Div;
            calc(2, 2);
            //or make ediferent objects for each methods

            //single-cast delegates
            //multiple delegates
            //multi-cast delegates --> inherit from System.MulticastDelegates class

            Console.WriteLine("\nMulti-Cast Delegates");
            Calculator calc2 = new Calculator(Add);
            calc2 += Sub;
            calc2 += Mul;
            calc2 += Div;
            calc2(2, 2);
            Console.WriteLine("\nSub wala nhi aaya");
            calc2 -= Sub;
            calc2(2, 2);




            Console.WriteLine("\nANONYMOUS FUNCTION");
            //as we discuss that delegates are used to reference methods that has same signature as that of the delegates
            //anonymous method is a method without a name...jus the body
            //anonymous method can be defined using delegate keyword
            MyDelegate d1 = new MyDelegate(MyMethod);
            //d1.Invoke(5);
            d1(5);

            //anonymously
            MyDelegate d2 = delegate (int a)
            {
                a += 10;
                Console.WriteLine("Anonymously a is " + a);
            };
            //d2.Invoke(5);
            d2(5);

            //anonymous method can be assigned to a variable of delegate type
            //delegate and anonymous method have same return type...so no need to specify
            //don't need any access specifiers with anonymous Fn
            //Anonymous Fn is not static or instance method
            //lesser typing work --> no return type...no anme....no access mofiers

            //limitations of anonymous Fn
            //it cannot contain jump statements liek goto,break or continue
            //it cannot access ref or out parameter of an outer method

            Program.MyMethod2(delegate (int b) { b += 10; Console.WriteLine("b is " + b); }, 5);

            //anonymous Fn can be used in event handling

            /*
            saveButton.Click+=delegate(Object o,EventArgs e){
            MessagebOx.Show("Save Successfully..!!!");
            } 
            */

            Console.WriteLine("LAMBDA EXPRESSION");
            //anonymous Fn is simplified to Lambda Fn...in c# 2.0 anonymous was released then in C# 3.0 lambda Expression released
            //in anonymus Fn keyword delegate and type of parameter is fazoool...as type should be same as in delegate hence
            MyDelegate d3 = (a) =>
            {
                a += 10;
                Console.WriteLine("Anonymously a is " + a);
            };

            //lambda works with anonymous method..have two parts on left and right side
            //=> labda operator used in labda expression
            /*
            2 types of lambda expression
            1)Statement lambda expression:-consists of input and set of statements to be executed
                syntax:- input =>{statements};
                Note:- Does not return any value implicity
            2)Expression Lambda:-consists of input and a expression
                syntax:- input => expression;
                Note:- return the evaluated value implicity
             */

            MyDelegate2 d4 = (a) => a * a;
            MyDelegate2 d5 = (a) => a * a * a;
            Console.WriteLine(d4(3));
            Console.WriteLine(d5(3));

            MyDelegate3 d6 = (a, b) => a + b;
            Console.WriteLine(d6(3, 7));
        }
    }

    class Employee
    {
        private int[] age = new int[3];
        public int this[int index]
        {
            set
            {
                if (index >= 0 && index < age.Length)
                {
                    if (value > 0)
                    {
                        age[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("age cannot be negative");
                    }
                }
                else
                {
                    Console.WriteLine("index out of range");
                }
            }
            get
            {
                return age[index];
            }
        }

        public int this[int index, int i]
        {
            set { age[index] = value + i; }
            get { return age[index]; }
        }
    }
}