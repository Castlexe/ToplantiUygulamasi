using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planlayıcı_Ana_Sürüm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("Lütfen Toplantı Başlığı Girin!", "Toplantı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);  
            }
            else
            {
                Properties.Settings.Default.toplantibasligi = textBox1.Text;
                Properties.Settings.Default.toplantisaati = maskedTextBox1.Text;
                Properties.Settings.Default.toplantiaciklamasi = richTextBox1.Text;
                Properties.Settings.Default.toplantibaslangictarihi = monthCalendar1.SelectionStart.ToString();
                Properties.Settings.Default.toplantisontarihi = monthCalendar1.SelectionEnd.ToString();

                Properties.Settings.Default.Save();

                MessageBox.Show("Toplantı Başarıyla Kaydedildi!", "Toplantı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form toplantikodu = new Form3();
                toplantikodu.ShowDialog();


            }
            
            
        }
    }
}
