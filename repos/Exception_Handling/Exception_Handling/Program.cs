namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            When Exception occurs
            1)program terminates/crash
            2)ugly message..that user can't understand
            3)statements after exception does not execute
            */

            Console.WriteLine("Enter Num 1");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num 2");
            int n2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine(n1 / n2);
            }
            catch (DivideByZeroException ex)    //Exception
            {
                Console.WriteLine("Divide by zero is not possible");
                Console.WriteLine(ex.Message);
            }

            //if we do not use try-catch then following code does not execute
            Console.WriteLine("statement-1");
            Console.WriteLine("statement-2");
            Console.WriteLine("statement-3");



            int[] arr = new int[3];
            try
            {
                arr[0] = 12;
                arr[1] = 22;
                arr[2] = 32;
                arr[3] = 42;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Range is out...!!!");
                Console.WriteLine(ex.Message);
            }


            //try
            //{
            //    string temp1 = null;
            //    Console.WriteLine(temp1.Length);
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine("String is null...!!!");
            //    Console.WriteLine(ex.Message);
            //}

            Console.WriteLine("Enter Num 3 or give string");
            string n3 = Console.ReadLine();
            try
            {
                int temp2 = int.Parse(n3);
                Console.WriteLine($"Number is {temp2}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Foramt issue...!!!");
                Console.WriteLine(ex.Message);
            }

            //multiple cathc block....make specific then general block
            //only one catch block will execute...
            //in try if more then one exception..only one will goto catch then  catch takes program downwards

            try
            {
                int a = 10;
                int b = 0;
                Console.WriteLine(a/b);

                int[] arr1 = new int[3];
                arr1[0] = 12;
                arr1[1] = 22;
                arr1[2] = 32;
                arr1[3] = 42;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            Console.WriteLine("--------finally block------------");
            //it always execute weather exception occurs(weather it is handle or not) or not...use for important coding like..closing stream,connection,etc

            try
            {
                int s1 = 10;
                int s2 = 0;
                Console.WriteLine(s1/s2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally code block executed successfully");
            }

            //remove catch and let c# handle exception and use ctrl+F5 to see result....that is "start without debugging"

            /*
            Four Ways Of Exception in C#
            1)Default Throw & Default Catch
            2)Default Throw & Our Catch
            3)Our Throw & Default Catch
            4)Our Throw & Our Catch
            */

            //we use 3 & 4 to handle some custom exceptions that C# compiler can't understand
            //3 & 4
            int acc_balance = 1000;
            int withdrawl = 200;
            try
            {
                if (withdrawl > acc_balance)
                {
                    //our exception
                    throw new Exception("Insufficient Balances...!!!");
                }
                else
                {
                    acc_balance = acc_balance - withdrawl;
                    Console.WriteLine($"Remaning Balance is: {acc_balance}");
                    Console.WriteLine("Transaction successful");
                }
            }
            //remove catch and make our exception and default catch...
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }
    }
}