using System;
using System.IO;

namespace Document
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Document\n");

            string name;
            Console.Write("Please enter a name for the document: ");
            name = Console.ReadLine();
            Console.WriteLine("");

            string content;
            Console.Write("Please enter the content within this document: ");
           content = Console.ReadLine();
            Console.WriteLine("");

            try
            {
                StreamWriter sw = new StreamWriter(name + ".txt");
                sw.WriteLine(content);
                sw.Close();
                Console.WriteLine("{0} has been saved.", name + ".txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }   
     }
 }

