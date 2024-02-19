using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;

namespace final_lecture
{
    internal class Program
    {
        public static async void Task1()
        {
            //lambda expression (also known as Arrow Fn In Js)
            await Task.Run(() =>
            {
                Console.WriteLine("Task 1 Starting...");
                Thread.Sleep(4000);
                Console.WriteLine("Task 1 Completed...!!!");
            });
        }

        public static async void Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 2 Starting...");
                Thread.Sleep(4000);
                Console.WriteLine("Task 2 Completed...!!!");
            });
        }

        public static async void Task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 3 Starting...");
                Thread.Sleep(4000);
                Console.WriteLine("Task 3 Completed...!!!");        
             });
            Console.WriteLine("From task 3 hello abd");
        }

        public static async void Task4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 4 Starting...");
                Thread.Sleep(4000);
                Console.WriteLine("Task 4 Completed...!!!");
            });

        }
        static void Main(string[] args)
        {
            //Boxing --> value to reference --> implicit conversion --> stack to heap
            //un-Boxing --> reference to value --> explicit conversion --> heap to stack

            //Value type --> variable and value in stack
            //Reference type --> variable in stack & value in heap

            int a = 10;//value type
            object obj = a;//boxing

            int b = (int)obj;//explicit

            //Globally Unique Identifier (GUID) --> SQL SERVER(same concept)
            //memory --> 128 bits or 16 BYTES
            //possible combinations are tooooooooooooo much....more then 5x10^36
            Guid g = Guid.NewGuid();  //generate unique 36 char value..including hypens(-)
            Console.WriteLine(g.ToString());
            Console.WriteLine(g.ToString().Replace("-", string.Empty));
            Console.WriteLine(g.ToString("N").Substring(0, 15));//get 15 chars from 36

            Console.WriteLine("Swapping 2 nums without using other var");

            int n1 = 10;
            int n2 = 20;

            Console.WriteLine($"n1 is {n1} & n2 is {n2}");
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
            Console.WriteLine($"n1 is {n1} & n2 is {n2}");

            Console.WriteLine("palindrome");
            string s1 = "121";

            char[] arr = s1.ToCharArray();
            Array.Reverse(arr);

            string s1_reverse = new string(arr);
            if (s1.ToLower().Equals(s1_reverse.ToLower()))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not A Palindrome");
            }

            Console.WriteLine("Store different data types in an array");
            object[] obj_arr = new object[4];
            obj_arr[0] = 1;
            obj_arr[1] = "kjds";
            obj_arr[2] = false;

            Employee emp = new Employee();
            emp.Id = 123;
            emp.Name = "abd";

            obj_arr[3] = emp; //we override a method in class...to extract name.

            foreach (var x in obj_arr)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("is VS as");
            /*is --> chk datatype of an object --> chks whether the conversion from one object type to another object type is
            compatible or not...if yes returns true else false
             */

            object temp = 123;
            if (temp is string)
            {
                Console.WriteLine("temp is string");
            }
            else
            {
                Console.WriteLine("temp is not a string");
            }

            /*
            as --> chk typecasting --> it helps to avoid InvalidCastException... 
            as --> typecasting not possible returns null....to see null do debugging(breakpoint) as null does not print on console
            */
            string str = temp as string;
            Console.WriteLine(str);

            /*
            Diff
            is chk run-time type of object while as use in conversion
            is return boolean value(true/false) while as return reference value or null
            is used for conversions -->reference,boxing and un-boxing 
            as used for conversions --> reference,boxing and nulllable
            */

            Console.WriteLine("Null Coalesce operator");
            string name = null;
            string res = name == null ? "anonymous" : name;//we can make any condition
            string res1 = name ?? "anonymous1";//only chk null

            Console.WriteLine($"res is {res} & res1 is {res1}");

            string f1 = null;
            string f2 = "apple";
            string f3 = "banana";
            string res3 = f1 ?? f2 ?? f3;//return first non-null value
            Console.WriteLine($"res3 is {res3}");

            //it returns left side operand if value is not null otherwise return right side


            Console.WriteLine("What happens if finally block throws exception...in that case we have to do try-catch nesting");
            try
            {
                try
                {
                    int m = 10;
                    int n = 0;

                    Console.WriteLine("result is " + m / n);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    string temp2 = "asd";
                    Console.WriteLine("length is " + temp2.Length);
                }
            }
            catch (Exception ex2)
            {
                Console.WriteLine("Exception in finally block");
                Console.WriteLine(ex2.Message);
            }

            //we can put inner try-catch-finally block in a method

            Console.WriteLine("Serialization");
            //->object --> stream of bytes --> 1)Memory 2)File 3)Database
            //->it's main purpose is to save the state of an object in order to be able to recreate it when needed..providing storage of
            //objects as well as data exchange....like XML AND JSON do
            //->the reverse process is called Deserialization....
            //->object is serialized to a stream that carries the data
            //->stream may also have information about object's type,version,culture and assembly name
            //->through serialization we can do:-
            //sending the object to a remote application by using a web service
            //passing as object from one domain to another
            //passing a object through firewall as a JSON or XML string
            //maintaining security or user-specific information across applications 

            /*
             types of serialization:-
            Serializing In Binary
            Serializing In JSON
            Serializing In XML
             */
            Aptech ap1 = new Aptech(12, "abd");
            string path = @"C:\Users\ABDULLAH JAWED\source\repos\final_lecture\final_lecture\sample.txt";//extension of file can be anything
            using (FileStream file = new FileStream(path, FileMode.OpenOrCreate))
            {
                BinaryFormatter bf1 = new BinaryFormatter();
                bf1.Serialize(file, ap1);
                Console.WriteLine("Serialized File Created Successfully");
            }

            //Deserialization is the opposing process which takes data from a file,stream or network and rebuilds it into an object
            //it resurrects the state of the object by setting properties,fields etc
            using (FileStream file = new FileStream(path, FileMode.OpenOrCreate))
            {
                BinaryFormatter bf1 = new BinaryFormatter();
                Aptech ap2 = (Aptech)bf1.Deserialize(file);
                Console.WriteLine("Deserialized Successfully");
                Console.WriteLine($"Id is {ap2.Id}\nname is {ap2.Name}");
            }

            Console.WriteLine("Concrete Class");
            //any class which is not a abstract class is known as concrete class hence normal classes are concrete classes

            Console.WriteLine("Dependency Injection");
            //Tight coupling --> when a group of classes id dependent on one another
            // on eclass have too many responsibilities...spread over many classes...creating other classes objects
            //hence,difficult ot maintain and test

            //Loose Coupling --> classes are independent of each other or have less dependency on each other
            //loose coupling is achieved by means of design that promotes single-responsibility and seperation of concerns
            //hence,easy ot maintain and test

            //how to avoid tight coupling --> bu using Dependency Injection(Di)
            //Di is achieved bu sing interfaces
            //interfaces are power full tool to use for decoupling(tight coupling --> loose coupling process)
            //classes can communicate through interfaces rather than other concrete classes

            //Dependency Injection (DI) is a software patteren
            //DI provides the objects that an object needs..instaed of having it construct the objects themselves
            //DI is a technique whereby one object supplies teh dependencies of another object
            //DI --> loosely couple code

            /*
            3 types of Di
            Constructor Injection --> nothing but the process of injecting dependent class object through the constructor
            Setter or Property Injection...
            Method Injection...
            */


            //Tight Coupling
            Console.WriteLine("\nTight Coupling");
            Account acc = new Account();
            acc.printAccounts();

            //Using same concepts different name classes to show DI
            //Constructor Injection
            Console.WriteLine("\nConstructor Injection");
            IAccount ca = new CurrentAccount2();
            Account2 acc1 = new Account2(ca);
            acc1.printAccounts();

            IAccount sa = new SavingAccount2();
            Account2 acc2 = new Account2(sa);
            acc2.printAccounts();

            // Setter or Property Injection
            Console.WriteLine("\nSetter or Property Injection");
            Account3 acc3 = new Account3();
            acc3.account = new CurrentAccount2();
            acc3.printAccounts();

            Account3 acc4 = new Account3();
            acc4.account = new SavingAccount2();
            acc4.printAccounts();

            //Method Injection
            Console.WriteLine("\nMethod Injection");
            Account4 acc5 = new Account4();
            acc5.printAccounts(new CurrentAccount2());

            Account4 acc6 = new Account4();
            acc6.printAccounts(new SavingAccount2());

            Console.WriteLine("ENUMS(Enumeration) --> Specifically Listed");
            //what is Enum
            //Built-in Enums
            //Custom Enums
            //why and when to use enums
            //Enum Conversion(Typecasting with Enums)
            //Enum with Switch Case

            //Enum is a class that represents set of constants...
            //It's readable..better understandable
            //default underlying type of an Enum is int
            //default value of first element is zero and then gets increment by 1
            //Enums are value types
            //behind the scenes Enum is converted to Abstract Class
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Days birthDay = Days.Monday;
            Console.WriteLine(birthDay);

            //Typecasting --> Explicit
            birthDay = (Days)2;
            Console.WriteLine(birthDay);

            int xyz = (int)Days.Tuesday;
            Console.WriteLine(xyz);

            string[] members = (string[])Enum.GetNames(typeof(Days));
            foreach (string member in members)
            {
                Console.WriteLine(member);
            }
            int[] values = (int[])Enum.GetValues(typeof(Days));
            foreach (int val in values)
            {
                Console.WriteLine(val);
            }

            //enums are used in months..days...colors etc
            //we can typecast adn chk by values too
            Days myDay = Days.Wednesday;
            switch (myDay)
            {
                case Days.Monday:
                    Console.WriteLine("This is Monday");
                    break;
                case Days.Tuesday:
                    Console.WriteLine("This is Tuesday");
                    break;
                case Days.Wednesday:
                    Console.WriteLine("This is Wednesday");
                    break;
                case Days.Thursday:
                    Console.WriteLine("This is Thursday");
                    break;
                case Days.Friday:
                    Console.WriteLine("This is Friday");
                    break;
                case Days.Saturday:
                    Console.WriteLine("This is Saturday");
                    break;
                case Days.Sunday:
                    Console.WriteLine("This is Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }

            Console.WriteLine("Async And Await In C#");
            //Synchronous programming is a programming model where operations takes place sequentially
            //that's why we use Asynchronous programming --> is a programming model where operationsdoes not dependent on each other
            Task1();
            Task2();
            Task3();
            Task4();

            //After suspension...the control goes back to the caller method...
            //once task completes,teh control comes back to teh state where await is mentioned and executes the remaining statements in the eclosing method

        }
    }

    enum Days
    {
        //days are enum members and there values are enum values
        Monday, Tuesday, Wednesday, Thursday = 6, Friday, Saturday, Sunday
    }


    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string? ToString()
        {
            return this.Name;
        }
    }



    [Serializable]//after putting this on class........we cannot inherit it
    class Aptech
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public Aptech(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

    }

    class CurrentAccount
    {
        public void printDetails()
        {
            Console.WriteLine("Details Of Current Account");
        }
    }
    class SavingAccount
    {
        public void printDetails()
        {
            Console.WriteLine("Details Of Saving Account");
        }
    }

    class Account
    {
        CurrentAccount ca = new CurrentAccount();
        SavingAccount sa = new SavingAccount();

        public void printAccounts()
        {
            ca.printDetails();
            sa.printDetails();
        }
    }


    interface IAccount
    {
        void printDetails();
    }

    class CurrentAccount2 : IAccount
    {
        public void printDetails()
        {
            Console.WriteLine("Details Of Current Account");
        }
    }
    class SavingAccount2 : IAccount
    {
        public void printDetails()
        {
            Console.WriteLine("Details Of Saving Account");
        }
    }

    class Account2
    {
        private IAccount account;

        public Account2(IAccount account)
        {
            this.account = account;
        }

        public void printAccounts()
        {
            account.printDetails();
        }
    }

    class Account3
    {
        public IAccount account { get; set; }

        public void printAccounts()
        {
            account.printDetails();
        }
    }
    class Account4
    {
        public void printAccounts(IAccount account)
        {
            account.printDetails();
        }
    }

}