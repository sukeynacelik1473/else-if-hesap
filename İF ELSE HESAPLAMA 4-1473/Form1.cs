using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İF_ELSE_HESAPLAMA_4_1473
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHsapla_Click(object sender, EventArgs e)
        {
            float sayı1 = Convert.ToSingle(txtSayı1.Text);
            float sayı2 = Convert.ToSingle(txtSayı2.Text);
            float sonuc = 0;// varsayılan bir değer ekleyerek olusturuldu
             if (rbTopla.Checked)
            {
                sonuc = sayı1 + sayı2;
            }
            else if (rbCıkar.Checked)
            {
                sonuc = sayı1 - sayı2;

            }
             else if (rbCarp.Checked)
            {
                sonuc = sayı1 * sayı2;
            }
             else if (rbBol.Checked)
            {
                sonuc = sayı1 / sayı2;
            }
             lblSonuc.Text=sonuc.ToString();
        }
    }
}
