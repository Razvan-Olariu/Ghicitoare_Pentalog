using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pentalog_Tema2
{
    class Program
    {
        static void Main(string[] args)
        {
            int year, month, day;
            string gender;

            Console.WriteLine("Te rog sa precizezi anul in care te-ai nascut:");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Te rog sa precizezi luna in care te-ai nascut:");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Te rog sa precizezi ziua in care te-ai nascut:");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Te rog sa precizezi cu M/F sexul tau:\n\t(Cu litera mare!!)");
            gender = Convert.ToString(Console.ReadLine());
            DateTime value = new DateTime(year, month, day);
            Console.WriteLine("Te-ai nascut in data de:\n\t");
            Console.WriteLine(value);
            DateTime now = DateTime.UtcNow;
            TimeSpan diff = now - value;
            string diferenta = String.Format("{0:0.#}", diff.TotalDays);
            Console.WriteLine($"\n{diferenta} zile ai trait de cand te-ai nascut.\n");
            Console.WriteLine("\n\tDupa punct, sunt reprezentate orele\n\n\n");
            double pensie = Convert.ToDouble(diferenta);
            if (gender == "M" && pensie / 365 > 65)
                Console.WriteLine("Esti un pensionar ! ;) ");
            else if (gender == "F" && pensie / 365 > 63)
                Console.WriteLine("Esti o pensionara ! ;) "); 
            else if ((gender != "M" || gender != "F") && (pensie / 365 > 63 || pensie / 365 > 65))
                Console.WriteLine("Esti pensionar. ( Nu am specificat genul)");
            else
                Console.WriteLine("Esti un om muncitor!! :D");
                    
         }
    }
}
