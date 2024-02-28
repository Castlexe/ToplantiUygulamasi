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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form toplantiolustur=new Form2();
            toplantiolustur.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form toplantikatil=new Form4();
            toplantikatil.ShowDialog();
        }
    }
}
