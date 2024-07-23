using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak2
{
    public enum Zanr
    {
        Drama=0,
        Ratni,
        Horor,
        Bajka
    }
    class Film
    {
        private string naslov;
        private string reditelj;
        private double ocena;
        private DateTime datum_premijere;
        private Zanr zanr;
        private int minUzrast;
        

        public Film()
        {

        }
        public Film(string n,string r, double o,DateTime d, Zanr z, int m)
        {
            naslov = n;
            reditelj = r;
            ocena = o;
            datum_premijere = d;
            zanr = z;
            if (z == Zanr.Bajka) minUzrast = 0;
            else minUzrast = m;
        }
        public Film(Film novi)
        {
            naslov = novi.naslov;
            reditelj = novi.reditelj;
            ocena = novi.ocena;
            datum_premijere = novi.datum_premijere;
            zanr = novi.zanr;
            minUzrast = novi.minUzrast;
        }
        public override string ToString()
        {
            if(Zanr.Bajka==Zanr) return Naslov + " by " + Reditelj + " " + Ocena + " " + Zanr + ", " + DatumPremijere.ToString("yy/MM/dd");
            else  return Naslov + " by " + Reditelj + " " + Ocena + " " + Zanr + " (prikladan za starije od " + minUzrast + " ), " + DatumPremijere.ToString("yy/MM/dd"); 
              

        }
        public string Naslov
        {
            get { return this.naslov; }
            set { this.naslov = value; }
        }
        public double Ocena
        {
            get { return this.ocena;  }
            set { this.ocena = value; }
        }

        public string Reditelj
        {
            get { return this.reditelj; }
            set { this.reditelj = value; }
        }
        public DateTime DatumPremijere
        {
            get { return this.datum_premijere; }
            set { this.datum_premijere = value; }
        }
        public Zanr Zanr
        {
            get { return this.zanr; }
            set { this.zanr = value; }
        }
        public int MinUzrast
        {
            get { return this.minUzrast; }
            set { this.minUzrast = value; }
        }
        
    }
}
