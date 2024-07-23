using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak4
{
    public partial class Form1 : Form
    {
        private List<Komponenta> komponente;
        public Form1()
        {
           
            InitializeComponent();
            komponente = new List<Komponenta>();
            comboBox1.Items.Add(VrstaKomponente.Procesor);
            comboBox1.Items.Add(VrstaKomponente.Memorija);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void IzKontroleUObjekat(Komponenta k)
        {
            k.Proizvodjac = textBox1.Text;
            k.Naziv = textBox2.Text;
            k.DatumProizvodnje = dateTimePicker1.Value;
            k.Cena = (double)numericUpDown1.Value;
            k.VrstaKomponente = (VrstaKomponente)comboBox1.SelectedIndex;
            k.RadniTakt = (double)numericUpDown2.Value;
            k.Kapacitet = (int)numericUpDown3.Value;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Komponenta nova = new Komponenta();
            IzKontroleUObjekat(nova);
            komponente.Add(nova);
            PrikaziListu();
        }
        private void PrikaziListu()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(komponente.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((VrstaKomponente)comboBox1.SelectedItem == VrstaKomponente.Memorija)
            { numericUpDown2.Enabled = false; numericUpDown3.Enabled = true; }
            else { numericUpDown2.Enabled = true; numericUpDown3.Enabled = false; }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            textBox1.Text = komponente[index].Proizvodjac;
            textBox2.Text = komponente[index].Naziv;
            dateTimePicker1.Value = komponente[index].DatumProizvodnje;
            numericUpDown1.Value = (decimal)komponente[index].Cena;
            comboBox1.SelectedItem = komponente[index].VrstaKomponente;
            numericUpDown2.Value = (decimal)komponente[index].RadniTakt;
            numericUpDown3.Value = komponente[index].Kapacitet;
        }
    }
}
