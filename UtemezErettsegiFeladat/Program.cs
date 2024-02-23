using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtemezErettsegiFeladat;

namespace Utemez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var taborok = new List<Taborok>();
            using var sr = new StreamReader(
                path: @"..\..\..\bin\Debug\taborok.txt",
                encoding: Encoding.UTF8);
            while (!sr.EndOfStream) taborok.Add(new(sr.ReadLine()));

            Console.WriteLine($"2. feladat\nAz adatsorok száma: {taborok.Count}");

            Console.WriteLine("3. feladat:");
            foreach (var zenei in taborok)
            {
                if (zenei.TaborTema == "zenei")
                {
                    Console.WriteLine($"Zenei tábor kezdődik {zenei.KezdHo}. hó {zenei.KezdNap}. napján.");
                }
            }

            Console.WriteLine("4. feladat");
            //int legtobbJel = 0;
            //string legnepszerubb;
            //foreach (var legtobb in taborok)
            //{
            //    if (legtobb.DiakBetujel.Count() > legtobbJel)
            //    {
            //        legtobbJel = legtobb.DiakBetujel.Count();
            //    }
            //    if (legtobb.DiakBetujel.Count() == legtobbJel)
            //    {
                    
            //    }
                
            //}

            //Console.WriteLine("7. feladat");


            //string betu;
            //Console.Write("Adja meg egy tanuló betűjelét: ");
            //betu = Console.ReadLine();
            //foreach (var tanulo in taborok)
            //{
            //    if (tanulo.DiakBetujel.Contains(betu))
            //    {
            //        Console.WriteLine($"{tanulo.TaborTema}");
            //    }
            //}

        }
    }
}