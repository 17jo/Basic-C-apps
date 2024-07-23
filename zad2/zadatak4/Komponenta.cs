using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace zadatak4
{
    public enum VrstaKomponente
    {
        Procesor=0,
        Memorija
    }

    class Komponenta
    {
        private string proizvodjac;
        private string naziv;
        private DateTime datumProizvodnje;
        private double cena;
        private VrstaKomponente vrstakomponente;
        private double radniTakt;
        private int kapacitet;

        public Komponenta()
        {
        }
        public Komponenta(string p, string n, DateTime dp, double c, VrstaKomponente vk, double rt, int k)
        {
            proizvodjac = p;
            naziv = n;
            datumProizvodnje = dp;
            cena = c;
            vrstakomponente = vk;
            radniTakt = rt;
            kapacitet = k;
        }
        public Komponenta (Komponenta k)
        {
            proizvodjac = k.proizvodjac;
            naziv = k.naziv;
            datumProizvodnje = k.datumProizvodnje;
            cena = k.cena;
            vrstakomponente = k.vrstakomponente;
            radniTakt = k.radniTakt;
            kapacitet = k.kapacitet;
        }
        public string Naziv
        {
            get { return this.naziv; }
            set { this.naziv = value; }
        }
        public string Proizvodjac
        {
            get { return this.proizvodjac; }
            set { this.proizvodjac = value; }
        }
        public DateTime DatumProizvodnje
        {
            get { return this.datumProizvodnje; }
            set { this.datumProizvodnje = value; }
        }
        public double Cena
        {
            get { return this.cena; }
            set { this.cena = value; }
        }
        public VrstaKomponente VrstaKomponente
        {
            get { return this.vrstakomponente; }
            set { this.vrstakomponente = value; }
        }
        public double RadniTakt
        {
            get { return this.radniTakt; }
            set { this.radniTakt = value; }
        }
        public int Kapacitet
        {
            get { return this.kapacitet; }
            set { this.kapacitet = value; }
        }

        public override string ToString()
        {
            if (VrstaKomponente == VrstaKomponente.Memorija)
                return VrstaKomponente + ": " + Proizvodjac + " " + Naziv + ", " + Kapacitet + "GB ," + DatumProizvodnje.ToString("yy/MM/dd") + " Cena: "+Cena;
            else return VrstaKomponente + ": " + Proizvodjac + " " + Naziv + ", " + RadniTakt+ "GHz ," + DatumProizvodnje.ToString("yy/MM/dd") + " Cena: " + Cena;
        }
    }
}
