using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EzConsCM
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string key = "MrSaturn";
            for (;;)
            {
                Console.Write("Enter the Key: ");
                string b = Console.ReadLine();
                if (key == b)
                {
                    break;
                }
                Console.WriteLine("\nWrong Key!\n");
                Console.WriteLine("Press Any Key to Try Again.\n");
                System.Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("\nCorrect Key!\n");
            Thread.Sleep(5000);
            Environment.Exit(0);
        }
    }
}