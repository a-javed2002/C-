using System.Collections.Specialized;
using System.Text;

namespace File_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = "F:\\data.txt";
            string path = @"C:\Users\ABDULLAH JAWED\source\repos\File Handling\File Handling\TextFile1.txt"; //verbatim literal...
            string path2 = @"C:\Users\ABDULLAH JAWED\source\repos\File Handling\File Handling\TextFile2.txt"; //verbatim literal...
            String data;
            if (File.Exists(path))
            {
                Console.WriteLine($"File {path} is presnt");
                //Reading A File
                data = File.ReadAllText(path);
                Console.WriteLine(data);

                //Copying A File
                //File.Copy(path, path2);//if file already exists it will give error....bcz it won't allow us to over write it

                //therefore we are using an overloaded Fn...
                File.Copy(path, path2, true);
            }
            else
            {
                Console.WriteLine($"File {path} is Not-presnt");
            }

            Console.WriteLine("---------Directory----------");
            string name = @"C:\MyDirectoryByC_Sharp";
            string name2 = @"C:\MyDirectoryByC_Sharp_2";
            //DirectoryInfo dir = new DirectoryInfo(name);
            //dir.Create();
            //dir.CreateSubdirectory("Another_directory");
            //dir.MoveTo(name2);//delete previous directory
            //dir.Delete();//delete if directory is empty
            //dir.Delete(true);//delete if directory is empty or not

            //DirectoryInfo[] dire = dir.GetDirectories();
            //foreach (var x in dire)
            //{
            //    Console.WriteLine(x + " & " + x.GetFiles().Length);
            //}

            //Console.WriteLine(dir.Name);
            //Console.WriteLine(dir.FullName);
            //Console.WriteLine(dir.LastAccessTime);
            //Console.WriteLine(dir.CreationTime);
            //Console.WriteLine(dir.Attributes);
            //Console.WriteLine(dir.Parent);
            //Console.WriteLine(dir.LastWriteTime);
            //Console.WriteLine(dir.Root);

            Console.WriteLine("---------File Stream----------");
            //FileStream class is derived from Stream class
            //File stream used with files to read,write & delete plus open and close
            /*
            The Four Parameters...
            1)Name Of File
            2)File Mode --> Open,append,close,Create
            3)Fiel Access --> read,write,read/write
            4)file share --> Other File STreams
             */

            string file_path = @"C:\Users\ABDULLAH JAWED\source\repos\File Handling\File Handling\my_new_file.txt";
            //FileMode.Create   //FileMode.Append   //FileMode.CreateNew//throws exception if file exists   //FileMode.Open//open existing file
            //FileMode.openOrCreate FileMode.Truncate

            //FileAccess.Write  //FileAccess.Read  //FileAccess.ReadWrite

            //FileShare.Write  //FileShare.Read  //FileShare.ReadWrite
            using (FileStream file=new FileStream(file_path,FileMode.Append,FileAccess.Write,FileShare.Read))
            {
                file.WriteByte(66);
                string data1 = "\nThis is me...!!!!\n";
                byte[] write_data = Encoding.UTF8.GetBytes(data1);
                file.Write(write_data,0,data1.Length);
                Console.WriteLine("File Created");
            }
            //file.Close();//use when not using the "using block"......

            //StreamWriter file is used to write data only...inherited from TextWriter...
            //like FileStream Class StreamWriter also have several constructors....
            //provide methods to Write the Stream

            string new_path = @"C:\Users\ABDULLAH JAWED\source\repos\File Handling\File Handling\my_new_file_2.txt";
            using (FileStream file2 = new FileStream(new_path, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(file2,Encoding.UTF8))
                {
                    writer.Write("Hey...i am the1...!!!\n");
                    writer.WriteLine("Hey...i am the2...!!!");
                    writer.WriteLine("Hey...i am the3...!!!");
                }
            }

            //StreamReader used to Read Text Files Only...Inherited from TextReader..provide methods to read from the Stream 
            using (FileStream file3 = new FileStream(new_path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(file3, Encoding.UTF8))
                {
                    string line = "";
                    while ((line=reader.ReadLine())!=null)
                    {
                        Console.WriteLine(line);
                    }

                    //for reading char
                    //foreach (var x in reader.ReadLine())
                    //{
                    //    Console.WriteLine(x);//chars
                    //}

                    //reading all data once
                    Console.WriteLine("-----------------------------");
                    string dataa = reader.ReadToEnd();
                    Console.WriteLine(dataa);

                    if (reader.Peek()>0)
                    {
                        Console.WriteLine("file is not empty");
                    }
                    else
                    {
                        Console.WriteLine("File si Empty");
                    }
                }
            }
        }
    }
}