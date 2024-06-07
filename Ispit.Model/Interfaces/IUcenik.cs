using System;

namespace Ispit.Model.Interfaces
{
    public interface IUcenik
    {
        string Ime { get; set; }
        string Prezime { get; set; }
        DateTime DatumRodenja { get; set; }
        double Prosjek { get; set; }
        int Starost();
        string IspisProsjeka();
    }
}
