using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit
{
    public class Ucenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public double Prosjek { get; set; }

        public int Starost()
        {
            return DateTime.Now.Year - DatumRodjenja.Year;
        }

        public string IspisProsjeka()
        {
            if (Prosjek < 1.5)
            {
                return "nedovoljan";
            }
            else if (Prosjek < 2.5 && Prosjek >= 1.5)
            {
                return "dovoljan";
            }
            else if (Prosjek < 3.5 && Prosjek >= 2.5)
            {
                return "dobar";
            }
            else if (Prosjek < 4.5 && Prosjek >= 3.5)
            {
                return "vrlo dobar";
            }
            else
            {
                return "odličan";
            }
        }
    }
