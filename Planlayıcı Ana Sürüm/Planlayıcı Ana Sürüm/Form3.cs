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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random toplantikodu = new Random();
            int sayi = toplantikodu.Next();
            textBox1.Text = Convert.ToString(sayi);

            Properties.Settings.Default.toplantikodu = textBox1.Text;
            Properties.Settings.Default.Save();

            MessageBox.Show("Oluşturuldu! / Lütfen Kopyalamayı Unutmayın!","Toplantı İşlemleri",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }
    }
}
