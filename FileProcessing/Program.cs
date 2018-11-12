using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\test.txt";
            if (File.Exists(filePath))
                ProcessFile(filePath);
            else
                Console.WriteLine("Error - File {0} not Found", filePath);
            Console.ReadKey();
        }

        static void ProcessFile(String filePath)
        {
            string oneLine;
            int lineNo = 1;
            try
            {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine("*====== File.ReadAllText() method ======");
                Console.WriteLine("{0}", fileContent);
                Console.WriteLine("==========================================================");

                string[] fileLines = File.ReadAllLines(filePath);
                Console.WriteLine("====== File.ReadLines() method =======");
                foreach (string line in fileLines)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("============================================================");

                StreamReader myFileReader = new StreamReader(filePath);
                while ((oneLine = myFileReader.ReadLine()) != null)
                {
                    Console.WriteLine("\r\n"+"Line " + lineNo + ":");
                    string[] words = oneLine.Split(' ');
                    for (int i = 0; i < words.Length; i++)
                        Console.Write(words[i]);
                    lineNo++;
                }

                myFileReader.Close();

            }
            catch (IOException ex)
            {

                Console.WriteLine(ex);
            }
        }
    }
}
