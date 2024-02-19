using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace intermediate_2
{
    class Program
    {
        
        public void fn_original()
        {
            Console.WriteLine("from program class...!!!");
        }
        public static void fn()
        {
            for (int i = 0; i < 20; i++)
            {
                if (i==10)
                {
                    Thread.Sleep(8000);//sleep for 8s
                }
            }
        }

        public static void fn1()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Fn1={i}");
            }
        }
        public static void fn2()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Fn2={i}");
            }
        }

        public static void fn3()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Fn3={i}");
            }
        }

        public static int add(params int[] arr)
        {
            int sum = 0;
            foreach (var x in arr)
            {
                sum += x;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Student s1 = new Student(1, "abc", 12);
            s1.StudentShow();


            /*
            on large projects....multiple programmers can work together with a single class...hence work then simultaneously
            Vs usespartial classes to seperate,automatically generated system code from the developer's code.For example:-
            when you add a webform ,2 files of .CS are generated
            1)Webform1.aspx.cs --> Contains Developers Code
            2)Webform1.aspx.designer.cs --> Contains System generated Code..example --> controls the you drag and drop on the webform
            */


            
            Console.WriteLine("Sum is: " + add(10, 20, 30, 40));    //params help to pass multiple parameters
            Console.WriteLine("Sum is: " + add());
            //params usage
            //used when programmer don't have prior knowledge number of porameters
            //only ONE params is allowed....and after it...do notr make parameters..make before then params
            //the length of params will be zero if no arguments passed...

            Console.WriteLine("---------String Builder---------");

            string str1 = "abd";
            Stopwatch sw1=new Stopwatch();
            sw1.Start();
            for (int i = 0; i < 10; i++) //make length 100000 (1 lac to see diff)
            {
                str1+= i;
            }
            sw1.Stop();

            StringBuilder str2 =new StringBuilder("abd");//can give capacity in ()..when we takes input..by default capacity is 16 char
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            for (int i = 0; i < 10; i++)//make length 100000 (1 lac to see diff)
            {
                str2.Append(i);
            }
            sw2.Stop();

            Console.WriteLine($"Time Taken By String is {sw1.ElapsedMilliseconds} ms");
            Console.WriteLine($"Time Taken By String Builder is {sw2.ElapsedMilliseconds} ms");

            /*
            string takes alot of time...for concatination..bcz it was changing the memory block..making a new one
            abd,abd0,abd01,abd012 and so on....while string builder memory block remains same....it does not make copies..
            or we can say in terms that...string builder does not create new objects in the memory but dynamically expands
            memory to accommodate the modified string

            we use string builder when alot of updation/modification is done otherwise use string

            agar capacity exceed hojae tou error nhi ayega...resize hojayega
             */

            StringBuilder str3 = new StringBuilder();//16
            str3.Append("abd");
            str3.AppendLine("jav");
            str3.Append("is");

            Console.WriteLine(str3);
            Console.WriteLine("-------");
            StringBuilder str4 = new StringBuilder();
            str4.AppendFormat("{0:C}",25);
            //str4.AppendFormat("{0:N}",25);
            //str4.AppendFormat("{0:X}",25);
            Console.WriteLine(str4);
            
            
            StringBuilder str5 = new StringBuilder("Hello World");
            str5.Insert(5, " C#");
            str5.Replace("World", "programming");
            str5.Remove(0, 6);
            Console.WriteLine(str5);

            //making string from string builder...making it immutable...as string is immutable an d string builder is mutable

            string t = str5.ToString();
            Console.WriteLine(t);

            Console.WriteLine("-----Multi-Threading------");
            /*
            Every application has a Single Thread by default to execute a program and thats ingle thread is known as MAIN THREAD
            Every Application foolws Single Threaded Model...
            
            Threads Are Executed By Operating system useing time-sharing
            Threads Are Executed Simultaneously
             */

            Thread th1 = Thread.CurrentThread;
            th1.Name = "Main Thread";//by default no name
            Console.WriteLine($"Current Executing Name is: {Thread.CurrentThread.Name}");

            Thread thread1 = new Thread(fn1);
            Thread thread2 = new Thread(fn2);
            Thread thread3 = new Thread(fn3);

            //execute simultaneously
            thread1.Start();
            thread2.Start();
            thread3.Start();

            /*
            Threads Are light Weightprocesses...
            A Thread is defined as the execution path of a program
            each thread defines a unique flow of program
            if your execution involves complicated and time consuming operations,then it is often helpful to set
            different execution paths/threads,with each thread performing a particular job
            */





            Console.WriteLine("Extension");
            /*
            Extension Method Aloows you to inject additional methods without modifying,deriving or recompiling the original
            class,struct or interface

            Q)so y we don't use inheritence.......?
            A)what if class is sealed....or we have struct instaed of class
            
             To Extend The Class...we need to pass a binding parameter
             */

            //chk file ext_1,ext_2

            //we make static method in extension and it becomes non-static when extended...or when we call
            //if same name method extended...then it's of no use...bcz method present in original class will be called..extended ignored
            //binding parameter does not need value...but we can add parameters after the binding one...

            //int is a struct..so

            //STRUCTS
            /*
            Structures blongs to procedural lang while classes belongs to oop
            structures in C can contain only fields/members
            structures in C# can contain most of the members that a class have...like members/fields,porperies,method,constructors,indexers etc
            structures are value type and stored in stack(small memory)..hence they are wiegth used for small entites like color
            classes are reference type and stored in heap(large memory).hence they are used for large entites

            write click on int & then on string--> peek defination
            string is a class,reference type
            int is a struct,value type
            */

            /*
             diifference b/t struct & class
             new name_of_struct/class keyword is neceesary in class but not in struct

            if we don't use new keywaord in struct then we have to explicity initialize the fields as default constructor won't invoked

            in struct we cannot make explicity parameterless constructor

            in class...when we make explicit constructor then the default constrctor is ignored but it won't happen in struct

            inheritence is not supported in struct

            struct can implement interfaces only

            we do not have template for struct like we have for classes and interfaces in VS...so use code file...
            ctrl+shift+A then code file
             */

        }

    }

    //chk another file to see remaning code of class Student
    public partial class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    }

    
}