using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak13
{
    public partial class Form1 : Form
    {
        private List<Auto> auto;
        public Form1()
        {
            InitializeComponent();
            auto = new List<Auto>();
            comboBox1.Items.Add(VrstaGoriva.Benzin);
            comboBox1.Items.Add(VrstaGoriva.Dizel);
            comboBox1.Items.Add(VrstaGoriva.Plin);
        }
        private void IzKontroleUObjekat(Auto a)
        {
           a.Proizvodjac= textBox1.Text;
            a.Model = textBox2.Text;
            a.CenaRegistracije = (double)numericUpDown1.Value;
            a.VrstaGoriva = Selektovan();
            a.DatumRegistracije = dateTimePicker1.Value;
            a.Kubikaza = (double)numericUpDown2.Value;
        }
        public VrstaGoriva Selektovan()
        {
            if ((VrstaGoriva)comboBox1.SelectedItem == VrstaGoriva.Benzin) return VrstaGoriva.Benzin;
            else if ((VrstaGoriva)comboBox1.SelectedItem == VrstaGoriva.Dizel) return VrstaGoriva.Dizel;
            else return VrstaGoriva.Plin;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Auto a = new Auto();
            IzKontroleUObjekat(a);
            auto.Add(a);
            PrikaziListu();
        }
        private void PrikaziListu()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(auto.ToArray());
        }

        private void snimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stdSnimi.ShowDialog() == DialogResult.OK)
            {
                Auto.SnimiAutomobile(stdSnimi.FileName, auto);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((VrstaGoriva)comboBox1.SelectedItem==VrstaGoriva.Dizel) { numericUpDown2.Value = 1900; numericUpDown2.Enabled = false; }
            else numericUpDown2.Enabled = true;
        }
    }
}
