using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            Kitap kitap1=new Kitap();
            kitap1.yili = "2019";
            kitap1.renk = "Mavi";
            kitap1.turu = "Macera";
            kitap1.yazar = "Paola Peretti";
            kitap1.sayfaSayisi = 205;

            label1.Text = kitap1.yili + " \n" + kitap1.renk + "\n " + kitap1.turu + " \n" + kitap1.yazar + "\n " + kitap1.sayfaSayisi;

        }
    }
}
