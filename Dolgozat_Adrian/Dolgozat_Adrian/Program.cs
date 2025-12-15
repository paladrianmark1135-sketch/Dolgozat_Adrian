using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_Adrian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> szamok = new List<int> {12, -10, 38, 1, -6, 23, 9, -15};
            List<int> szamParatlan = new List<int>();
            List<int> negSzamok = new List<int>();
            szamok.Remove(-6);
            szamok.Add(20);
            szamok.Add(30);
            Console.Write(String.Join(", ", szamok));
            foreach (var item in szamok)
            {
                if (item < 0)
                {
                    negSzamok.Add(item);
                }
            }
            foreach (var item in szamok)
            {
                if (item%2 == 0)
                {
                    szamParatlan.Add(item);
                }
            }

            Console.Write($"\nLegkisseb Elem: {szamok.Min()}");
            Console.Write($"\nLegnagyobb Elem: {szamok.Max()}");
            Console.Write($"\nPáratlan Számok: {string.Join(" ", szamParatlan)}");
            Console.Write($"\nNegatív Számok: {string.Join(" ", negSzamok)}");
            
            Console.ReadKey();

        }
    }
}
