using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repozytorium_PC.Klasy
{
    public class Pacjent
    {
        private string Imie { get; set; }
        private string Nazwisko { get; set; }
        private string Numer_Ewidencyjny { get; set; }
        private string Pesel { get; set; }
        public Pacjent(string Imie, string Nazwisko, string Numer_Ewidencyjny, string Pesel)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.Numer_Ewidencyjny = Numer_Ewidencyjny;
            this.Pesel = Pesel;
        }
    }
}