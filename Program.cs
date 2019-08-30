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
            using (StreamReader reader = new StreamReader(fileStream))
            {
                string line = reader.ReadLine();
                //FOR EACH COMMAND GET THE OUTPUT AND PRINT THAT
                string result = doOperation(line);
                Console.WriteLine("PERSON_NOT_FOUND");
            }
        }

        static string doOperation(string line) {
            return "PERSON_NOT_FOUND";
        }
    }
}
