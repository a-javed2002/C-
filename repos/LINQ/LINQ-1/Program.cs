namespace LINQ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] age = { 1, 23, 2, 33, 12, 3, 45, 46, 26, 55, 3, 11 };
            var a = from i in age where i > 20 orderby i descending select i;
            foreach (var x in a)
            {
                Console.WriteLine(x);
            }

            string[] names = { "ali", "sam", "sana", "sara", "harry" };
            //var b = from i in names where i.Contains("l") select i;
            var b = from i in names where i.StartsWith("h") select i;
            foreach (var x in b)
            {
                Console.WriteLine(x);
            }

            //LINQ to objects (Arrays & collections)
            //LINQ to Database -->  Linq to sql (Arrays & collections)
            //LINQ to Database -->  Linq to ADO.Net (Arrays & collections)
            //LINQ to Database -->  Linq to Entities (Arrays & collections)
            //LINQ to xml (xml files)


            /*
            Linq to Sql
            introduced in DotNet FrameWork 3.5 By Microsoft
            it's a query base language
            */

            /*
            Advantages of ADO.Net With Sql Server
            1)SQL Query checked on rum time,as we write queries in double quotes thus strings are not executed by c# compiler they were
            ignored hence queries check by sql database engine...and if they are wrong an exception is sent to C# compiler from database engine
            which is not good...!!!
            2)no intellisense support
            3)not type safe --> need to know column names and datatypes 
            4)Debugging of SQl statements are a nightmare
            5)SQL Queries are combination of object-oriented and relational
             */

            /*
            Advantages of LINQ With Sql Server
            1)queries are checked during compile time by c# compiler bcz LINQ is integrated in C# provided by DotNet Framework
            2)Intellisense support
            3)it is type safe
            4)Debugging of SQl statements is easy
            5)SQL Queries are 100% object-oriented Code
            */

            /*
            To Work With LINQ to SQL you have to map/convert relational objects of database inti object-oriented types..as shown below
            Relational Types --> Object-Oriented Types
            Table --> Class
            Columns --> Property
            Records/Row --> Object/Instance
            Stored Procedures --> Method

            The process nof mapping/converting is known as ORM(Object Relational Mapping)
            And to perform ORM we use a tool called OR Designer
             */

            /*
            LINQ TO SQL in windows form application
            1. perform ORM by OR Designer
            2. add a reference System.Data.Linq
            3. Write The comnnection string into the config file

             */
        }
    }
}