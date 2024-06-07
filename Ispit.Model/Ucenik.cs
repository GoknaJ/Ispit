using Ispit.Model.Interfaces;
using System;

namespace Ispit.Model
{
    public class Ucenik : IUcenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodenja { get; set; }
        public double Prosjek { get; set; }

        public int Starost()
        {
            return DateTime.Today.Year - DatumRodenja.Year;
        }

        public string IspisProsjeka()
        {
            if (Prosjek < 1.5)
            {
                return "nedovoljan";
            }
            else if (Prosjek >=1.5 && Prosjek < 2.5)
            {
                return "dovoljan";
            }
            else if (Prosjek >= 2.5 && Prosjek < 3.5)
            {
                return "dobar";
            }
            else if (Prosjek >= 3.5 && Prosjek < 4.5)
            {
                return "vrlo dobar";
            }
            else
            {
                return "odličan";
            }
        }
    }
}
