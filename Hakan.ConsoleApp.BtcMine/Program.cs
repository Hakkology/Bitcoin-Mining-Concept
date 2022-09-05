using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Timers;

namespace Hakan.ConsoleApp.BtcMine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int n = 4;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            string FirstInput = "My name is Earl";
            Random rand = new Random();
            int Nonce = rand.Next(0,7);
            string Hashx = Hash.GetHashString(FirstInput);
            Console.WriteLine($"Hash value is: {Hashx}");

            do
            {
                Hashx = Hash.GetHashString($"{Hashx}+{Nonce}");
                count++;
            } while (Hashx.Substring(0, n) != String.Concat(Enumerable.Repeat("0",n)));

            watch.Stop();
            Console.WriteLine($"Current Hash value is {Hashx}");
            Console.WriteLine($"This iteration took {count} times");
            Console.WriteLine($"It  took {watch.ElapsedMilliseconds/1000} seconds to reach desired conditions.");
            Console.ReadLine();
        }


    }

}

