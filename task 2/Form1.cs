using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bolunen = int.Parse(textBox1.Text);
            int bolen = int.Parse(textBox2.Text);
            if (bolen == 0)
            {
                label1.Text = "Bölen sıfır olamaz!";
                return;
            }
            int sonuc = 0;
            while (bolunen >= bolen)
            {
                bolunen -= bolen;
                sonuc++;
            }
            label1.Text = "Sonuç: " + sonuc.ToString();
        }
        
    }
}

