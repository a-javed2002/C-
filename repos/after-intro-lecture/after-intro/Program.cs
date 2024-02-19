namespace after_intro
{
    // STRUCT --> Value Type --> STACK MEMORY
    // CLASS --> REFERENCE Type --> HEAP MEMORY

    //REFERENCE Type --> String,arrays(even if elements are value type),class,object,delegates,interface
    //value Type --> All Remaining (data types,struct etc)

    /*
     * Value type are stored in stack(values store on one another..like a stack,has less part of RAM)..
     * it contains actual value...cannot contain null values..however this can be achieved by nullable
     types....memory is allocated on compile time
     
     * Reference Type stored in heap(values are stored in random order like dumped into a huge space,has more part of RAM)
     * it contains reference of value,can contain null values,memory is allocated on run time
     
     */
    //struct Employee
    class Employee

    {
        public int salary;
            public int age;
        }
    internal class Program
    {
        static void swp(ref int a,ref int b)
        {
            int temp = b;
            b = a;
            a=temp;
        }
        static void assign(out int a, out int b)
        {
            a = 20;
            b = 30;
        }

        static void Main(string[] args)
        {
            Employee e = new Employee();
              e.salary= 70;
            e.age= 18;

            Employee e1 = e;
            Employee e2 = e;

            e.salary = 500;
            e.age = 22;

            Console.WriteLine(e.salary);
            Console.WriteLine(e1.salary);
            Console.WriteLine(e2.salary);




            //PASS BY VALUE(Simple) AND PASS BY REFERENCE(REF AND OUT KEYWORDS)
            //pass by reference
            int x = 2;
            int y = 4;
            swp(ref x,ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("\n---------------------------------------\n");

            //pass by out..in pass by refrence we have to initialize the var but over here it is not neccessary
            int m;
            int n;
            assign(out m, out n);
            Console.WriteLine(m);
            Console.WriteLine(n);


            //var and dynamic keywords...
            Console.WriteLine(m.GetType());

            var f="string"; //datatype is figured out at compile time
            Console.WriteLine(f.GetType());

            //dynamic d = 12;
            //Console.WriteLine(d.getType()); //intellisece don't work with dynamic variables..as there datatype is figured out at run time
            //d = "acf";
            //Console.WriteLine(d.getType());
            //fn return type can be dynamic..as well as parameters
            //dynamic keyword is of reference type


            

        }
    }
}