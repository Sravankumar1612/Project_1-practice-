using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "E:\\Dotnet\\Test File Input For student.txt";

        // Check if the file exists
        if (File.Exists(filePath))
        {
            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            // Display the student data
            Console.WriteLine("School student details: \n");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("Student data file not found!");
        }

        Console.ReadLine();
        
    }
}
