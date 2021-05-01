using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string writeText = "Hello Haripriya";  // Create a text string
            File.WriteAllText("names.txt", writeText);  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText("names.txt");  // Read the contents of the file
            Console.WriteLine(readText);

            String path = @"E:\Example.txt"; //file is in E drive

            String[] lines;
            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

            String copypath = @"E:\ExampleCopys.txt";

            File.Copy(path, copypath);
            // File.Delete(path); // To delete the file in the Path

            FileStream F = new FileStream("test.txt", FileMode.OpenOrCreate,
           FileAccess.ReadWrite);

            for (int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }
            F.Position = 0;
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();
        }
    }
}
