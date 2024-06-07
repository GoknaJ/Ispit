using Ispit.Model;
using Ispit.Model.Interfaces;
using System;

namespace Ispit.Konzola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IUcenik[] ucenici = new IUcenik[3];

            Console.WriteLine("Unesi 3 učenika:");

            for (int i = 0; i < 3; i++)
            {
                Ucenik ucenik = new Ucenik();

                Console.Write("Ime: ");
                ucenik.Ime = Console.ReadLine();
                Console.Write("Prezime: ");
                ucenik.Prezime = Console.ReadLine();
                Console.Write("Datum rođenja (dd/mm/yyyy): ");
                ucenik.DatumRodenja = DateTime.Parse(Console.ReadLine());
                Console.Write("Prosjek: ");
                ucenik.Prosjek = double.Parse(Console.ReadLine());

                ucenici[i] = ucenik;
            }

            Console.WriteLine("Podaci učenika:");
            foreach (IUcenik ucenik in ucenici)
            {
                Console.WriteLine($"Ime: {ucenik.Ime}, Prezime: {ucenik.Prezime}, Datum rođenja: {ucenik.DatumRodenja}, Starost: {ucenik.Starost()}, Ispis prosjeka: {ucenik.IspisProsjeka()}");
            }
            Console.ReadKey();

        }
    }
}
