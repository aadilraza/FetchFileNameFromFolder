using System;
using System.Collections.Generic;
using System.IO;

namespace PracticingOnFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\Users\adil.raza\Downloads\findeo\findeo\";
                List<string> List = new List<string>();
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    var FullName = Path.GetFileName(file);
                    var trimmedName = FullName.Remove(FullName.Length - 5);
                    List.Add(trimmedName);
                }

                //Pass the filepath and filename to the StreamWriter Constructor

                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(@"C:\Users\adil.raza\Downloads\findeo\findeoFile.txt");

                foreach (var item in List)
                {
                    sw.WriteLine("{0}", item.ToString() + Environment.NewLine); //Write a line of text
                }

                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }


            Console.ReadLine();
        }
    }
}
