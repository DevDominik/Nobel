using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dij> dijak = File.ReadAllLines("nobel.csv").Skip(1).Select(x => new Dij(x)).ToList();
            Console.WriteLine("4. feladat: 2017-ben ezek az emberek kaptak irodalmi Nobel-díjat:");
            foreach (Dij dij in dijak)
            {
                if (dij.Ev == 2017 && dij.Tipus == "irodalmi")
                {
                    Console.WriteLine($"{dij.Keresztnev} {dij.Vezeteknev}");
                }
            }
            Console.WriteLine("6. feladat: A Curie-család tagjai ekkor kaptak Nobel-díjat:");
            foreach (Dij dij in dijak)
            {
                if (dij.Vezeteknev.Contains("Curie"))
                {
                    Console.WriteLine($"{dij.Keresztnev} {dij.Vezeteknev} | {dij.Ev}");
                }
            }
            Console.WriteLine("7. feladat: A Nobel-díjak típus szerint összegezve:");
            List<string> tipusok = new List<string>();
            foreach (Dij dij in dijak)
            {
                if (!tipusok.Contains(dij.Tipus))
                {
                    tipusok.Add(dij.Tipus);
                }
            }
            foreach (string item in tipusok)
            {
                Console.WriteLine($"\t{item}: {dijak.Count(x => x.Tipus == item)} db");
            }
            dijak.OrderBy(x => x.Ev);
            StreamWriter sw = new StreamWriter("orvosi.txt", false);
            foreach (Dij dij in dijak)
            {
                sw.WriteLine($"{dij.Ev};{dij.Keresztnev} {dij.Vezeteknev}");
            }
            sw.Close();
            Console.WriteLine("8. feladat: orvos.txt");
        }
    }
}
