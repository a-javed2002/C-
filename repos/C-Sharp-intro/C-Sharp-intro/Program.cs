namespace C_Sharp_intro
{
    internal class Program
    {
        public void wish(string name) //non-static method OR instance method
        {
            Console.WriteLine($"Good Morning {name}\n");
        }

        public static void wish1(string name) //static method
        {
            Console.WriteLine($"Good Morning {name}\n");
        }
        static void greet(string name="unknown")
        {
            Console.WriteLine($"Good Morning {name}\n");
        }

        static int average(int a,int b,int c)
        {
            return (a + b + c)/3;
        }
        static int average(int a, int b)
        {
            return (a + b) / 2;
        }
        static void Main(string[] args)
        {
        /*
          https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet-framework
         */
            Console.WriteLine("Hello, World!");

            //two integer types...signed(+ & -) and unsigned(+)

            //properties
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            //Console.WriteLine(float.MaxValue);
            //Console.WriteLine(byte.MinValue);
            //Console.WriteLine(uint.MaxValue);
            //Console.WriteLine(double.MinValue);

            Console.WriteLine("\n------------------------\n");

            int a = 34;
            float b = 34.4F;
            double c = 34.4D;
            bool d = true;
            char e = 'a';
            string f = "hello";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);

            //Tyoe Casting -->
            //1)IMPLICIT:- char to int to long to float to double
            // int x = b; //error
            float y = a;
            Console.WriteLine(y);
            int z = 'k';
            Console.WriteLine(z); //ascii value

            //2)EXPLICIT:- we tell C# compiler
            int x = (int)b;
            Console.WriteLine(x);

            Console.WriteLine("\n------------------------\n");

            //Typecasting using methods
            float j = 34.3F;
            double l = 23.33;

            Console.WriteLine(Convert.ToInt32(j));
            Console.WriteLine(Convert.ToInt32(l));
            Console.WriteLine(Convert.ToDouble(l));
            Console.WriteLine(Convert.ToString(l));

            Console.WriteLine("\n------------------------\n");
            //string str1 = Console.ReadLine(); //always takes string as input...hrnce use type casting for manupilation
            double v = Math.Max(34, 65);
            Console.WriteLine(v);
            v = Math.Min(34, 65);
            Console.WriteLine(v);
            v = Math.Sqrt(64);
            Console.WriteLine(v);
            v = Math.Abs(-65);
            Console.WriteLine(v);

            Console.WriteLine("\n-------------Escape Sequence Chaarcter-------------\n");
            Console.WriteLine("\n-------------LOOPS-------------\n");
            //for use when you know the range
            //while use on only condition...like fetching data from DB...that limit is unknown...
            //for initial var can be initialize/declare in and out of for loop scope...but while loop initial var initialize outside



            Console.WriteLine("\n-------------jump statements-------------\n");
            //break,countinue,goto,return

            for (int i = 0; i < 5; i++)
            {
                if (i==2)
                {
                    break;
                    //continue;
                    //goto stop;

                }
            }

            stop:
            Console.WriteLine("loop ends by goto");


            Console.WriteLine("\n-------------Arrays-------------\n");
            string[] my_array1 = new string[2]; //1st way
            my_array1[0] = "asd";
            Console.WriteLine(my_array1[0]);
            my_array1[1] = "pqr";
            Console.WriteLine(my_array1[1]);
            string[] my_array2 = new string[] {"asd","pqr"}; //2nd way
            string[] my_array3 = { "asd", "pqr" }; //3rd way
            Console.WriteLine(my_array3.Length);

            for (int i = 0; i < my_array3.Length; i++)
            {
                Console.WriteLine($"At index {i} the value is {my_array3[i]}");
            }

            foreach (string value in my_array3)
            {
                Console.WriteLine(value);
            }

            int[,] my_array4 = new int[3, 4]
            {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12}
            };
            for (int i = 0; i < my_array4.GetLength(0); i++)
            {
                for (int r = 0; r < my_array4.GetLength(1); r++)
                {
                    Console.WriteLine($"at index {i},{r} ---> { my_array4[i, r]}");
                }
            }

            Console.WriteLine("\n-------------Jagged Array-------------\n");
            int[][] my_array5 = new int[3][];
            my_array5[0] = new[] { 1, 2, 3, 4, 5 };
            my_array5[1] = new[] { 1, 2, 3 };
            my_array5[2] = new[] { 1, 2, 3, 4, 5,6,7 };

            for (int i = 0; i < my_array5.GetLength(0); i++)
            {
                for (int k = 0; k < my_array5[i].Length; k++)
                {
                    Console.Write($"{my_array5[i][k]},");
                }
                Console.WriteLine();
            }

            //or use for each
            Console.WriteLine();

            foreach (int[] m in my_array5)
            {
                foreach (var n in m)
                {
                    Console.Write($"{n},");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n-------------Dynamic Array-------------\n");
            //Console.WriteLine("Enter Array length");
            //int ln = int.Parse(Console.ReadLine());
            //int[] my_array6 = new int[ln];

            //for (int i = 0; i < ln; i++)
            //{
            //    Console.WriteLine($"value for index {i}");
            //    int data = int.Parse(Console.ReadLine());
            //    my_array6[i] = data;
            //}
            //foreach (var item in my_array6)
            //{
            //    Console.WriteLine(item);
            //}


            //String Fn
            Console.WriteLine("\n-------------String Fn-------------\n");
            string str2 = "Hello My Name Is xyz";
            Console.WriteLine(str2.Length);
            Console.WriteLine(str2.ToUpper());
            Console.WriteLine(str2.ToLower());
            Console.WriteLine(str2 + " cool...!!!");
            Console.WriteLine(string.Concat(str2, " cool...!!!"));
            Console.WriteLine($"{str2} cool...!!!");
            Console.WriteLine("{0} cool...!!!", str2);

            //Varbatim literal
            Console.WriteLine(@"C:\Users\ABDULLAH JAWED\Desktop\LANGUAGES\C#");
            //Non-Varbatim literal
            Console.WriteLine("C:\\Users\\ABDULLAH JAWED\\Desktop\\LANGUAGES\\C#");

            Console.WriteLine("\n--------------------------\n");

            string str3 = "Hello World this Is xyz";
            Console.WriteLine(str3.IndexOf("is"));
            Console.WriteLine(str3.Substring(5));
            Console.WriteLine(str3); //no effect on original string


            Console.WriteLine("\n------------Methods/Functions--------------\n");
            greet("bob");

            int res=average(1, 2, 3);
            Console.WriteLine(res);
            //Fn Overloading
            res = average(3, 3);
            Console.WriteLine(res);

            Program p1 = new Program();
            p1.wish("jkl"); //non-static
            Program.wish1("hi"); //static
            wish1("hello");
            Program.wish1(name:"hi2"); //named argument...good while we have multiple parameters

            Console.WriteLine("\n------------DATE--------------\n");
            DateTime dt = DateTime.Now;
            Console.WriteLine("d -> {0:d}", dt);
            Console.WriteLine("D -> {0:D}", dt);
            Console.WriteLine("f -> {0:f}", dt);
            Console.WriteLine("F -> {0:F}", dt);
            Console.WriteLine("g -> {0:g}", dt);
            Console.WriteLine("G -> {0:G}", dt);
            Console.WriteLine("t -> {0:t}", dt);
            Console.WriteLine("T -> {0:T}", dt);
            Console.WriteLine("m -> {0:m}", dt);
            Console.WriteLine("y -> {0:y}", dt);
            Console.WriteLine("yy -> {0:yy}", dt);
            Console.WriteLine("yyyy -> {0:yyyy}", dt);
            Console.WriteLine("ddd -> {0:ddd}", dt);
            Console.WriteLine("dddd -> {0:dddd}", dt);
            Console.WriteLine("FF -> {0:FF}", dt);
            Console.WriteLine("HH -> {0:HH}", dt);
            Console.WriteLine("MM -> {0:MM}", dt);
            Console.WriteLine("MMM -> {0:MMM}", dt);
            Console.WriteLine("ss -> {0:ss}", dt);
            Console.WriteLine("making date -> {0:hh:mm:ss tt}", dt); //12 hour format
            Console.WriteLine("making date -> {0:HH:mm:ss}", dt); //24 hour formst
            Console.WriteLine("making date -> {0:dd-mm-yyyy}", dt);
            Console.WriteLine("making date -> {0:dd/mm/yyyy}", dt);


            Console.WriteLine("\n------------Tenary--------------\n");
            string res3 = (20 > 30) ? "True" : "False";
            Console.WriteLine(res3);

            //alternate of ==
            //if (res3.Equals("True"))
            //{
            //    Console.WriteLine();
            //}



            Console.WriteLine("\n------------OOP--------------\n");
            //class is coming from class1.cs

            Class1 obj1 = new Class1();
            Console.WriteLine(obj1.health);
            obj1.setHealth(100);
            Console.WriteLine(obj1.health);
            Console.WriteLine(obj1.getPower());
            obj1.setPower(100);
            Console.WriteLine(obj1.getPower());

        }
    }
}