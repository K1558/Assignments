using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht1._2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
          
                        using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\WriteLines.txt"))
                        {
                        for (int i = 0; i < 3; i++)
                            try
                            {
                                Console.WriteLine("Write a line: ");
                                string line = Console.ReadLine();

                                outputFile.WriteLine(line);
                            
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                break;
                            }
                         
                        }
            
         

            try
            {
                string text = System.IO.File.ReadAllText(mydocpath+@"\WriteLines.txt");
                System.Console.WriteLine("The content of the file: \n"+text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }

        }
    }
}
