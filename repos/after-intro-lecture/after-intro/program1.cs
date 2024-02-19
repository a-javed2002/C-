using System;

namespace after_intro
{
	//no inheritance aur object(instantiated) of this class
	static class xyz
	{
		static x;
	}
	class emp
	{
		string name;
		int salary;

		//static is a class variable..hence it is invoked by class name
		//we can make static Fn...but only static members can be accessed...
		//in normal Fn...we can use both static & non-static members
		public static company_name="ABC";
		public static fees=100;
			public static xyz;

		//constructor Overloading //depends on data type and number of parameters
		public emp()
		{
			Console.WriteLine("New Employee Created");
		}

		//parametrized constructor
		public emp(string name,int salary) {
			this.name = name;
			this.salary = salary;
		}

		public string getName() { return name; }	
		public int getSalary() { return salary; }

		public static int getFees()
		{
			return fees;
		}

		//static construtor...it runs only once...it is called before instance construtor....
		//	no parameter or any access modifiers with static construtor 
		//CLR calls static construtor...we can't run it directly...
		//use to initialize static members
		static emp()
		{
			xyz = "asd";
			Console.WriteLine("Static Construtor invoked");
		}

		//copy constructor
		public emp(emp e)
		{
			this.name = e.name;
			this.salary = e.salary;
		}


		//we can make private constructor when we have static methods only in class
		//we can make empty private construtor...just to avoid making of objects..of that class...
		//we cannot make private and public construtor...with same parameters/data type...as it also breaks law of construtor overloading
		//public emp(){} and private emp(){} --> not valid


		//destrutor --> de-allocates memory of objects that are no longer required...
		//cannot be overloaded or inherited....hence no access modifiers plus no parameters
		//cannot invoke explicity...
		~emp(){
			Console.WriteLine("Destrutor Has Been Invoked...!!!");
		}
	}
	internal class Program1
	{


		//program1.cs
		Console.WriteLine("---------program1.cs-----------");
			emp e = new emp("abd", 21);
		Console.WriteLine(e.name);
			Console.WriteLine(e.salary);

			//initialize..with the help of copy construtor
			emp e1 = new emp(e);
		Console.WriteLine(e1.name);
			Console.WriteLine(e1.salary);


	}
}