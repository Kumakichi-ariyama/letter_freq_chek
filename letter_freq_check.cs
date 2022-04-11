using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "The quick brown fox jumps over the lazy dog.";
            char[] charMessage = str.ToCharArray();
            Array.Reverse(charMessage);
            int x = 0;
            foreach (char i in charMessage) 
            {
                if (i == 'o') 
                { 
                    x++; 
                } 
            }
            string new_message = new String(charMessage);
            Console.WriteLine(new_message);
            Console.WriteLine($"'o' appears " + $"{x} times.");


            Console.ReadKey();
        }
    }
}
