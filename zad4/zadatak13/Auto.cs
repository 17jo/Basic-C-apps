using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak13
{
    public enum VrstaGoriva
    {
        Dizel=0,
        Benzin,
        Plin
    }

    class Auto
    {
        private string proizvodjac;
        private string model;
        private double cenaRegistracije;
        private VrstaGoriva vrstaGoriva;
        private DateTime datumRegistracije;
        private double kubikaza;
        public Auto(string p, string m, double cr, VrstaGoriva vg, DateTime dr, double k)
        {
            proizvodjac = p;
            model = m;
            cenaRegistracije = cr;
            vrstaGoriva = vg;
            datumRegistracije = dr;
            kubikaza = k;
        }
        public Auto(Auto a)
        {
            proizvodjac = a.proizvodjac;
            model = a.model;
            cenaRegistracije = a.cenaRegistracije;
            vrstaGoriva = a.vrstaGoriva;
            datumRegistracije = a.datumRegistracije;
            kubikaza = a.kubikaza;
        }
        public override string ToString()
        {
            return Proizvodjac + " - " + Model + " / " + CenaRegistracije + " - " + datumRegistracije.ToString("dd-MMM-yy") +" / "+Kubikaza+" " +VrstaGoriva;
        }
        public Auto()
        {

        }
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
        public double CenaRegistracije
        {
            get { return this.cenaRegistracije; }
            set { this.cenaRegistracije = value; }
        }
        public VrstaGoriva VrstaGoriva
        {
            get { return this.vrstaGoriva; }
            set { this.vrstaGoriva = value; }
        }
        public DateTime DatumRegistracije
        {
            get { return this.datumRegistracije; }
            set { this.datumRegistracije = value; }
        }
        public double Kubikaza
        {
            get { return this.kubikaza; }
            set { this.kubikaza = value; }
        }
        private void Save(StreamWriter writer)
        {
            writer.Write(proizvodjac);
            writer.Write(model);
            writer.Write(cenaRegistracije);
            writer.Write(vrstaGoriva);
            writer.Write(datumRegistracije);
            writer.Write(kubikaza);

        }
        public static void SnimiAutomobile(string path, List<Auto> l)
        {
            FileStream stream = new FileStream(path, FileMode.Create);
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.Write(l.Count);
                for (int i = 0; i < l.Count; i++)
                {
                    l[i].Save(writer);
                }
            }
            stream.Close();
        }

    }
}
