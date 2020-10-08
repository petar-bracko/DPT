using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace pbracko_zadaca_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TvornicaKlonovaSingleton tvornicaPrograma = TvornicaKlonovaSingleton.GetInstance();
            List<TvProgram> listaPrograma = new List<TvProgram>();

            string exePutanja = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine("Exe: " + exePutanja);

            String solutionDir = Directory.GetParent(exePutanja).Parent.Parent.FullName;
            Console.WriteLine("Solution directory: " + solutionDir);
            Console.WriteLine("ovo je testni zapis");
            Console.WriteLine("Commit iz VS-a");

            string x = Path.Combine(exePutanja, "Programi.txt");
            if (!File.Exists(x))
            {
                Console.WriteLine("Nema Programa.txt");
                Console.ReadLine();
                System.Environment.Exit(1);
            }
            string[] sviProgrami = System.IO.File.ReadAllLines(x);
            string[] split = sviProgrami[0].Split(';');
            Adresa prototipAdresa = new Adresa(
                int.Parse(split[3].Trim()),
                split[2].Trim()
                );
            TvProgram prototip = new TvProgram(
                int.Parse(split[0].Trim()),
                split[1].Trim(),
                prototipAdresa
                );
            listaPrograma.Add(prototip);

            sviProgrami = sviProgrami.Skip(1).ToArray();
            foreach (string record in sviProgrami)
            {
                string[] recordSplit = record.Split(';');
                TvProgram klon = (TvProgram)tvornicaPrograma.getClone(prototip);
                klon.Id = int.Parse(recordSplit[0].Trim());
                klon.Naziv = recordSplit[1].Trim();
                klon.Adresa.Ulica = recordSplit[2].Trim();
                klon.Adresa.Broj = int.Parse(recordSplit[3].Trim());
                listaPrograma.Add(klon);
            }

            foreach (TvProgram program in listaPrograma)
            {
                Console.WriteLine("Program ID: " + program.Id.ToString() + " | Naziv programa: " + program.Naziv + ".");
                Console.WriteLine("Adresa: " + program.Adresa.Ulica + " " + program.Adresa.Broj.ToString());
                Console.WriteLine("-----");
            }

            listaPrograma[1].Naziv = "DomaTV";
            listaPrograma[1].Adresa.Ulica = "Trg slobode";
            listaPrograma[1].Adresa.Broj = 8;
            Console.WriteLine("Pormjena--------------");
            foreach (TvProgram program in listaPrograma)
            {
                Console.WriteLine("Program ID: " + program.Id.ToString() + " | Naziv programa: " + program.Naziv + ".");
                Console.WriteLine("Adresa: " + program.Adresa.Ulica + " " + program.Adresa.Broj.ToString());
                Console.WriteLine("-----");
            }

            int indexArgumenta = 0;
            foreach (var argument in args)
            {
                if (argument.Equals("-x"))
                {
                    Console.WriteLine("Pronađen arugment x");
                    Console.WriteLine("Indeks argumenta x: " + indexArgumenta);
                    Console.WriteLine("Putanja do datoteke X nalazi se na: " + args[indexArgumenta + 1]);
                }
                indexArgumenta++;
            }

            Console.ReadLine();
        }
    }
}
