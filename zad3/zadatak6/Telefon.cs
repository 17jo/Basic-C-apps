using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace zadatak6
{
    public enum OperativniSistem
    {
        Android=0,
        IOS,
        Windows
    }

    class Telefon
    {
        private string proizvodjac;
        private string model;
        private double ram;
        private double frekvencija;
        private DateTime datumObjavljivanja;
        private OperativniSistem operativni;
        private int verzija;
        public string Proizvodjac
        {
            get { return this.proizvodjac; }
            set { this.proizvodjac = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public double RAM
        {
            get { return this.ram; }
            set { this.ram = value; }
        }
        public double Frekvencija
        {
            get { return this.frekvencija; }
            set { this.frekvencija = value; }
        }
        public DateTime DatumObjavljivanja
        {
            get { return this.datumObjavljivanja; }
            set { this.datumObjavljivanja = value; }
        }
        public OperativniSistem Operativni
        {
            get { return this.operativni; }
            set { this.operativni = value; }
        }
        public int Verzija
        {
            get { return this.verzija; }
            set { this.verzija = value; }
        }
        public override string ToString()
        {
            return Proizvodjac + " " + Model + ", RAM: " + RAM + "GB, Frekvencija:" + Frekvencija + "GHz, " + Operativni + " " + Verzija + " " + DatumObjavljivanja.ToString("yy/MM/dd");
        }
        public Telefon(string p, string m, double r, double f, DateTime d, OperativniSistem o, int v)
        {
            proizvodjac = p;
            model = m;
            ram = r;
            frekvencija = f;
            datumObjavljivanja=d;
            verzija = v;
        }
        public Telefon(Telefon t)
        {
            proizvodjac = t.proizvodjac;
            model = t.model;
            ram = t.ram;
            frekvencija = t.frekvencija;
            datumObjavljivanja = t.datumObjavljivanja;
            operativni = t.operativni;
            verzija = t.verzija;
        }
        public Telefon()
        {

        }
    }
}
