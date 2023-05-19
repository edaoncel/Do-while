using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do__while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sayac = 5;
            while (sayac > 5 && sayac < 10)
            {
                sayac++;
                MessageBox.Show(sayac.ToString());
            }
            do
            {
                sayac++;
                MessageBox.Show(sayac.ToString());
            }
            while (sayac > 5 && sayac > 10);
     
        }
    }
}
