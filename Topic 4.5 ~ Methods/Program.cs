using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Topic_4._5___Methods
{
    internal class Program
    {

        public static void Joke()
        {
            Console.WriteLine("99 little bugs in the code.");
            Thread.Sleep(500);
            Console.WriteLine("99 little bugs.");
            Thread.Sleep(500);
            Console.WriteLine("Fix a bug, run it again.");
            Thread.Sleep(500);
            Console.WriteLine("100 little bugs in the code.");
        }

        public static void Joke(int numBugs)
        {
            Console.WriteLine($"{numBugs} little bugs in the code.");
            Thread.Sleep(500);
            Console.WriteLine($"{numBugs} little bugs.");
            Thread.Sleep(500);
            Console.WriteLine("Fix a bug, run it again.");
            Thread.Sleep(500);
            Console.WriteLine($"{numBugs++} little bugs in the code.");
        }

        static void Main(string[] args)
        {
            int bugs;
            Console.Write("How many bugs are in your code: ");
            Int32.TryParse(Console.ReadLine(), out bugs);
            Console.WriteLine();
            Joke(bugs);
            Console.ReadLine();

            Console.Write("Press ENTER for a joke: ");
            Console.ReadLine();
            Console.WriteLine();
            Joke();

            Console.WriteLine();

            Console.Write("Press ENTER for another joke: ");
            Console.ReadLine();
            Console.WriteLine();
            Joke(50);
        }
    }
}
