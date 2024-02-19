using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace intermediate_2
{
    public partial class Student
    {
        public Student(int id,string name,int age) {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        
        public void StudentShow()
        {
            Console.WriteLine($"id: {id}\tname: {name}\tage: {age}");
        }
    }
    internal class StudentPartialClass1
    {
    }
}
