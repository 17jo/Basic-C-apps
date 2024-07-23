using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak2
{
    public partial class Form1 : Form
    {
        private List<Film> filmovi;
        public static Form1 instance;
        public TextBox tex1;
        public TextBox tex2;
        public NumericUpDown num1;
        public DateTimePicker date;
        public ComboBox combox;
        public NumericUpDown num2;
        public Form1()
        {
            InitializeComponent();
            instance = this;
             tex1= tb1;
            tex2 = tb2;
            num1 = numericUpDown1;
            date =dateTimePicker1 ;
            combox = cb ;
              num2= numericUpDown2;

            filmovi = new List<Film>();
            cb.Items.Add(Zanr.Drama);
            cb.Items.Add(Zanr.Ratni);
           cb.Items.Add(Zanr.Horor);
            cb.Items.Add(Zanr.Bajka);
            
            
        }
        private void IzKontrolaUObjekat(Film f)
        {
            f.Naslov = tb1.Text;
            f.Reditelj = tb2.Text;
            f.Ocena = (double)numericUpDown1.Value;
            f.DatumPremijere = dateTimePicker1.Value;
            f.Zanr = (Zanr)cb.SelectedItem;
            f.MinUzrast = (int)numericUpDown2.Value;
            
        }
        private void IzObjektaUKontrole(Film f)
        {
            tb1.Text = f.Naslov;
            tb2.Text = f.Reditelj; 
           numericUpDown1.Value = (decimal)f.Ocena;
            dateTimePicker1.Value = f.DatumPremijere;
            cb.SelectedItem = (Zanr)f.Zanr;
            numericUpDown2.Value = f.MinUzrast;
        }
        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void btn_Click(object sender, EventArgs e)
        {

            Film novifilm = new Film();
            IzKontrolaUObjekat(novifilm);
            filmovi.Add(novifilm);
            PrikaziListu();
        }
        public void PrikaziListu()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(filmovi.ToArray());
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void cb_Click(object sender, EventArgs e)
        {
         
        }

        private void cb_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((Zanr)cb.SelectedItem == Zanr.Bajka) numericUpDown2.Enabled = false;
            else numericUpDown2.Enabled = true;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show("nesto" + sender);
            Form2 obj = new Form2();
            
            obj.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
