using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatare_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string nume1, nume2;
            nume1 = "Olariu Alexandru-Razvan";
            nume2 = "Ovidiu Radoi";
            Console.WriteLine(string.IsNullOrEmpty(nume1)); // 1
            Console.WriteLine(string.Compare(nume1, nume2)); // 2
            Console.WriteLine(String.Join(" ", nume1, nume2)); // 3
            Console.WriteLine(nume1.ToUpper()); // 4
            Console.WriteLine(nume2.ToLower()); // 5
            Console.WriteLine(nume1.StartsWith("O")); //6
            Console.WriteLine(nume2.EndsWith("Radoi")); // 7


        }
    }
}
