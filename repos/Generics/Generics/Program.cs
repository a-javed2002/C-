using System.Collections;

namespace Generics
{
    internal class Program
    {
        public static void show<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[3];
            arr1[0] = 2;
            arr1[1] = 4;
            arr1[2] = 6;
            Program.show(arr1);

            Console.WriteLine("------------------------------");

            string[] arr2 = { "sana", "hira", "saad" };
            Program.show(arr2);
            Console.WriteLine("------------------------------");

            abc<int> obj1 = new abc<int>();
            obj1.box = 3;
            Console.WriteLine(obj1.box);
            abc<string> obj2 = new abc<string>();
            obj2.box = "hello";
            Console.WriteLine(obj2.box);


            Console.WriteLine("\nCollections and arrays\n");
            /*
            we can use Array.Resize(ref array_name,new_length)...but it first take backup of data,destroy the previous
            makes a new one...shift data...the return...
            to solve this problem we use collections...plus multiple datatype data can be stored here..bur array contains homogeneous elements
            plus we can add/delete from middle...plus it contains method for operations on elements

            C#1.0 introduced collections..
            2 types of collections
            Non-Generic Collections --> Stack,ArrayList,HashTable,SortedList etc...we use namespace System.Collections
            Generic Collections --> List<T>,LinkedList<T>,Queue<T>,SortedLsit<T,V>...we use namespace System.Collections.Generic
             */

            //ArrayList

            ArrayList list1 = new ArrayList();//we can give value too...in ()
            Console.WriteLine("Length of list1 is: " + list1.Capacity);
            list1.Add(3);
            list1.Add("abc");
            Console.WriteLine("Length of list1 is: " + list1.Capacity);
            foreach (object x in list1)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("---------------------------");

            ArrayList list2 = new ArrayList();//we can give value too...in ()
            list2.Add(10);
            list2.Add(20);
            list2.Add(40);
            list2.Add(50);
            foreach (object x in list2)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Insert value on in middle on index 2");
            list2.Insert(2, 30);
            foreach (object x in list2)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("removing value on in middle");
            list2.Remove(40); //removes by value
            list2.RemoveAt(0); //removes by index
            foreach (object x in list2)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nHastables\n");
            /*
            Array/ArrayList and hastTables stored value In Key/Value Pair..But
            Array/ArrayList have impilicit keys that are known as index while...
            hastTables have Explicit keys
             */

            Hashtable h1 = new Hashtable();
            h1.Add("Id", 1123);
            h1.Add("Name", "abc");
            h1.Add("Salary", 2500.00);
            h1.Add("Married", false);
            Console.WriteLine(h1["Id"]);

            Hashtable h2 = new Hashtable()
            {

                { "Id", 1166 },
                { "Name", "xyz" },
                { "Salary", 2500.00},
                { "Married", true}
            };
            Console.WriteLine(h2["Id"]);

            Console.WriteLine("-----------");

            foreach (var key in h2.Keys)
            {
                Console.WriteLine(key + ":- " + h2[key]);
            }
            Console.WriteLine("-----------");

            foreach (var v in h2.Values)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine(h2.Count);
            h2.Remove("salary");
            h2.Clear(); //clear everything
            h2.Contains("name");//same
            h2.ContainsKey("name");//same
            h2.ContainsValue("xyz");
            Console.WriteLine("xyz".GetHashCode());//every key a hash code(integer value)
                                                   //hash tables use hash algorithm to generate hash codes for every key and bcz of this hash tables are faster then Array/ArrayList


            /*
             All Non-Generic Collections
            they store hmogeneous as well as hetrogeneous
            they automatically dyanamically resize
            they are not type safe
             */

            //Stack --> LIFO(Last In First Out)
            Stack st1 = new Stack();
            st1.Push("abc");
            st1.Push(43);
            st1.Push(42);
            st1.Push(43);
            st1.Push("asd");
            st1.Push(null);
            st1.Push("asd");

            Console.WriteLine("---------------");
            foreach (var x in st1)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine(st1.Count);
            Console.WriteLine(st1.Peek()); //top value seen
            Console.WriteLine(st1.Pop()); //top value pops
            //string c = st1.Peek().ToString();
            //Console.WriteLine(c);
            Console.WriteLine(st1.Contains("abc"));
            st1.Clear();
            /*
             Stack Class implements the IEnumerable,ICollection, and ICloneable interfaces...
             */

            //object data type is parent of all data types....!!!!!

            Console.WriteLine("-------****Queue****----------");
            //Queue --> FIFO(First In First Out)
            // add in queue --> Enqueue
            // remove from queue --> Denqueue

            Queue q1 = new Queue();
            q1.Enqueue("abc1");
            q1.Enqueue("abc2");
            q1.Enqueue(72);
            q1.Enqueue(32.2);
            q1.Enqueue(null);
            q1.Enqueue(null);
            q1.Enqueue(32.2);

            q1.Dequeue(); //removes first one..

            Console.WriteLine(q1.Peek()); //returns first value but do not remove it....
            Console.WriteLine(q1.Contains("abc"));

            foreach (var x in q1)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(q1.Count);
            q1.Enqueue(72);

            Console.WriteLine("-----------------");
            while (q1.Count > 0)
            {
                Console.WriteLine(q1.Dequeue());
            }
            Console.WriteLine(q1.Count);
            q1.Clear();

            Console.WriteLine("-----------Generic----------");
            Console.WriteLine("List");
            List<int> l1 = new List<int>();
            l1.Add(12);
            l1.Add(32);
            l1.Add(44);
            l1.Add(23);

            l1.Sort();
            foreach (var x in l1)
            {
                Console.WriteLine(x);
            }
            l1.AddRange(l1);
            l1.Insert(1, 23);
            l1.InsertRange(1, l1);
            l1.Remove(33);//by value
            l1.RemoveAt(3);//by index
            l1.RemoveRange(2, 3);//from index 2..removes 3 elements
            Console.WriteLine(l1.IndexOf(33, 2));//find 33 from index 2 onwards
            Console.WriteLine(l1.LastIndexOf(33));//find 33 index from last
            foreach (var x in l1)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("diff---------");
            Console.WriteLine("capacity is " + l1.Capacity);
            Console.WriteLine("count is " + l1.Count);
            Console.WriteLine("val at index 2 " + l1[2]);
            Console.WriteLine(l1.Contains(3));
            l1.Reverse();
            l1.Clear();
            Console.WriteLine("Real Use of list");

            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee(1, "abc", 12, "CS"));
            empList.Add(new Employee(2, "xyz", 15, "CYS"));
            empList.Add(new Employee(3, "mno", 17, "AI"));

            foreach (var x in empList)
            {
                Console.WriteLine($"id is {x.id},name is {x.name},age is {x.age},department is {x.department}");
            }

            //lamda expression..predicate
            empList.RemoveAll(emp => emp.age > 15);
            Console.WriteLine("diff---------");
            foreach (var x in empList)
            {
                Console.WriteLine($"id is {x.id},name is {x.name},age is {x.age},department is {x.department}");
            }

            empList.Add(new Employee(4, "jkl", 11, "ACCA"));
            empList.Add(new Employee(5, "fgh", 21, "Bs"));
            empList.Add(new Employee(6, "awsd", 14, "CA"));

            Console.WriteLine(empList.Exists(emp => emp.department.StartsWith("A")));

            Employee temp = empList.Find(emp => emp.age < 20);//first occurence
            Console.WriteLine($"id is {temp.id},name is {temp.name},age is {temp.age},department is {temp.department}");
            temp = empList.FindLast(emp => emp.age < 20);//last occurence
            Console.WriteLine($"id is {temp.id},name is {temp.name},age is {temp.age},department is {temp.department}");
            List<Employee> temp1 = empList.FindAll(emp => emp.age < 20);//all
            foreach (var x in temp1)
            {
                Console.WriteLine($"id is {x.id},name is {x.name},age is {x.age},department is {x.department}");
            }
            Console.WriteLine("------------------");
            Console.WriteLine(temp1.FindIndex(emp => emp.age > 12));//return -1 if not found
            Console.WriteLine(temp1.FindLastIndex(emp => emp.age > 12));//return -1 if not found
            Console.WriteLine("------------------");
            Employee[] Emp_Array = temp1.ToArray();
            foreach (var x in Emp_Array)
            {
                Console.WriteLine($"id is {x.id},name is {x.name},age is {x.age},department is {x.department}");
            }

            Console.WriteLine("--------&&&&&&&----------");
            List<Employee> New_Emp_List = Emp_Array.ToList();
            foreach (var x in Emp_Array)
            {
                Console.WriteLine($"id is {x.id},name is {x.name},age is {x.age},department is {x.department}");
            }
            /*
            generic type
            type safe
            dynamically size increase
            search,sort and manipulation with list is easy
             */

            Console.WriteLine("\n\nDictionary");
            //access elemnts with explicit keys instead of index
            //auto resize
            //ame datatype

            Dictionary<string, string> d1 = new Dictionary<string, string>();
            d1.Add("id", "Std1234");
            d1.Add("name", "abc");
            d1.Add("batch", "2110c1");

            foreach (var key in d1.Keys)
            {
                Console.WriteLine(key + ": " + d1[key]);
            }

            Console.WriteLine("------DIFF-------");
            //can use var instead of KeyValuePair<string,string>........but prefer this --> KeyValuePair<string,string>
            foreach (KeyValuePair<string,string> x in d1)
            {
                Console.WriteLine(x.Key + ": " + x.Value);
            }
            string value;
            if(d1.TryGetValue("asd",out value))
            {
            Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("key not found");
            }
            Console.WriteLine(d1.ContainsKey("name"));
            Console.WriteLine(d1.ContainsValue("2110c1"));
            d1.Remove("name");

            Console.WriteLine("---------------");
            foreach (string x in d1.Keys)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("---------------");
            foreach (string x in d1.Values)
            {
                Console.WriteLine(x);
            }
            d1.Clear();
            Console.WriteLine("-------REAL USE OF DICTIONARY--------");
            Employee emp1 = new Employee(1, "jkl", 9, "ACCA");
            Employee emp2 = new Employee(2, "mno", 13, "CA");
            Employee emp3 = new Employee(3, "fgh", 11, "CS");
            Dictionary<int, Employee> EmpDict = new Dictionary<int, Employee>();
            EmpDict.Add(emp1.id,emp1);
            EmpDict.Add(emp2.id,emp2);
            EmpDict.Add(emp3.id,emp3);

            foreach (KeyValuePair<int,Employee> x in EmpDict)
            {
                Console.WriteLine($"{x.Key}: {x.Value.id}\n{x.Key}: {x.Value.name}\n{x.Key}: {x.Value.age}\n{x.Key}: {x.Value.department}");
            }
            Console.WriteLine("-------------------");
            Console.WriteLine(EmpDict.Count(z=>z.Value.age>10));
            Console.WriteLine(EmpDict.Count(z=>z.Value.name.StartsWith("f")));

            //key cannot be null but value can
            //no duplicate keys
            //store same types of elements
        }
    }

    class abc<T>
    {
        public T box { get; set; }
    }

    class Employee
    {
        public Employee(int id, string name, int age, string department)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.department = department;
        }

        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string department { get; set; }
    }
}