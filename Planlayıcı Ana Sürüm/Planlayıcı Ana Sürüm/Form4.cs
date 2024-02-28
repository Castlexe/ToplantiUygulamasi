using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planlayıcı_Ana_Sürüm
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""||textBox2.Text=="")
            {
                MessageBox.Show("Lütfen Boşlukları Doldurun!","Toplantı İşlemleri",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if(textBox2.Text==Properties.Settings.Default.toplantikodu)
                {
                    Properties.Settings.Default.katilimciadi = textBox1.Text;
                    Properties.Settings.Default.Save();

                    MessageBox.Show("Giriş Başarılı!","Toplantı İşlemleri",MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form toplantibilgileri= new Form5();
                    toplantibilgileri.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Hatalı Toplantı Kodu","Toplantı İşlemleri",MessageBoxButtons.OK,MessageBoxIcon.Error );
                }
            }
        }
    }
}
