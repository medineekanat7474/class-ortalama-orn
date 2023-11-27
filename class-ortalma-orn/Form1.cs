using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_ortalma_orn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double yazili1=Convert.ToDouble(txtYazili1.Text);
            double yazili2=Convert.ToDouble(txtYazili2.Text);
            double yazili3=Convert.ToDouble(txtYazili3.Text);

            Ortalama ortalama=new Ortalama(yazili1 , yazili2, yazili3);
            txtOrtalama.Text = ortalama.Ortalamahesapla().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtOrtalama.Enabled = false;
        }
    }
}
