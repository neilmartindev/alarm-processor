using System;
using System.Data;
using System.IO;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string st = File.ReadAllText(@"C:\AlarmList.tsv");
                Console.WriteLine(st);
            }

            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            Console.Read();

        }
    }
}
