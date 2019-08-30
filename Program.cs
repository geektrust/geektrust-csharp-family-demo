using System;
using System.IO;

namespace geektrust_family_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            String filename = args[0];
            FileStream fileStream = new FileStream(filename, FileMode.Open);
            string line;  

            using (StreamReader reader = new StreamReader(fileStream))
            {
                while((line = reader.ReadLine()) != null)  {
                    //FOR EACH COMMAND GET THE OUTPUT AND PRINT THAT
                    string result = doOperation(line);
                    Console.WriteLine(result);
                }
            }
        }
        static string doOperation(string line) {
            if (line.StartsWith("ADD_CHILD")) {
                return "CHILD_ADDITION_FAILED";
            }
            return "PERSON_NOT_FOUND";
        }
    }
}
