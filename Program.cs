using System;
using System.IO;

class Program
{
    static void Main()
    {
        // File path of the text file containing student data
        string filePath = "E:\\Dotnet\\Test File Input For student.txt";

        // Check if the file exists before reading
        if (File.Exists(filePath))
        {
            try
            {
                // Read all lines from the text file into an array of strings
                string[] lines = File.ReadAllLines(filePath);

                // Loop through each line (representing a student record)
                foreach (string line in lines)
                {
                    // Split the line using the comma as the delimiter
                    string[] data = line.Split(',');

                    // Ensure the data array has the required number of fields
                    if (data.Length == 4)
                    {
                        // Extract the individual fields from the data array
                        string name = data[0];
                        int age = int.Parse(data[1]);
                        int rollNumber = int.Parse(data[2]);
                        string major = data[3];

                        // Display the student data
                        Console.WriteLine($"Name: {name}, Age: {age}, Roll Number: {rollNumber}, Major: {major}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid data format: " + line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading the file: " + e.Message);
            }
        }
        else
        {
            Console.WriteLine("The file 'students.txt' does not exist.");
        }

        // Wait for user input before closing the console window (optional)
        Console.ReadLine();
    }
}
