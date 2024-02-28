using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planlayıcı_Ana_Sürüm
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + dateTimePicker1.Text+"\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Toplantı : "+ Properties.Settings.Default.toplantibasligi);
            listBox2.Items.Add("Toplantı Başlangıç Günü : "+Properties.Settings.Default.toplantibaslangictarihi);
            listBox2.Items.Add("Toplantı Son GÜnü : "+Properties.Settings.Default.toplantisontarihi);
            listBox2.Items.Add("Toplantı Saati : "+Properties.Settings.Default.toplantisaati);
            listBox2.Items.Add("Toplantı Açıklaması : "+Properties.Settings.Default.toplantiaciklamasi);


        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label2.Text = Properties.Settings.Default.katilimciadi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string metin = Properties.Settings.Default.katilimciadi +"\n"+richTextBox1.Text;

            FileStream fs = new FileStream("dosya.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(metin);
            sw.Close();

            MessageBox.Show("Uygun Tarihleriniz Eklendi!","Toplantı İşlemleri",MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            string metin;
            FileStream fs=new FileStream("dosya.txt",FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            metin = sr.ReadLine();

            while(metin != null)
            {
                listBox1.Items.Add(metin);
                metin = sr.ReadLine();

            }
            sr.Close();
            fs.Close();
            MessageBox.Show("Başarılı!","Toplantı İşlemleri",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
        }
    }
}
