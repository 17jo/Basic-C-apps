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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.instance.tex1.Text;
            label2.Text = Form1.instance.tex2.Text;
           decimal k = Form1.instance.num1.Value;
            label3.Text = k.ToString();
            label4.Text = Form1.instance.date.Text;
            label5.Text = Form1.instance.combox.Text;
            k = Form1.instance.num2.Value;
            label6.Text = k.ToString();
          }
    }
}
