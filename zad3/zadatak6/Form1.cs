using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak6
{
    public partial class Form1 : Form
    {
        private List<Telefon> telefoni;
        public Form1()
        {
            InitializeComponent();
            telefoni = new List<Telefon>();
        }

        private void IzKontrolaUobjekat(Telefon t)
        {
            t.Proizvodjac = textBox1.Text;
            t.Model = textBox2.Text;
            t.RAM = (double)numericUpDown1.Value;
            t.Frekvencija = (double)numericUpDown2.Value;
            t.DatumObjavljivanja = dateTimePicker1.Value;
            t.Operativni = Selektovano();
            t.Verzija = (int)numericUpDown3.Value;
            
        }
        private OperativniSistem Selektovano()
        {
            if (radioButton1.Checked == true) return OperativniSistem.Android;
            else if (radioButton2.Checked == true) return OperativniSistem.IOS;
            else  return OperativniSistem.Windows; 
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Telefon noviTel = new Telefon();
            IzKontrolaUobjekat(noviTel);
            string model=noviTel.Model;
            bool dalDodati = true;
            foreach (Telefon t in telefoni)
            {
                if (model == t.Model) dalDodati = false;
            }
            if (dalDodati == true)
                telefoni.Add(noviTel);
            else MessageBox.Show("Telefon " + model + " vec postoji u listu");
            PrikaziListu();
        }
        private void PrikaziListu()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(telefoni.ToArray());
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            numericUpDown3.Value = (int)10; numericUpDown3.Enabled = false;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            numericUpDown3.Enabled = true;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            numericUpDown3.Enabled = true;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            textBox1.Text = telefoni[index].Proizvodjac;
            textBox2.Text = telefoni[index].Model;
            numericUpDown1.Value = (decimal)telefoni[index].RAM;
            numericUpDown2.Value = (decimal)telefoni[index].Frekvencija;
            dateTimePicker1.Value = telefoni[index].DatumObjavljivanja;
            switch (telefoni[index].Operativni)
            {
                case OperativniSistem.Android: radioButton1.Checked = true;break;
                case OperativniSistem.IOS: radioButton2.Checked = true; break;
                case OperativniSistem.Windows: radioButton3.Checked = true; break;
                default: break;
            }
            numericUpDown3.Value = telefoni[index].Verzija;
            
        }
    }
}
