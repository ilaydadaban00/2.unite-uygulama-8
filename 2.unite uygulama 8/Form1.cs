using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.unite_uygulama_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int not;
            not = Convert.ToInt32(textBox1.Text);
            if (not < 0)
            {
                MessageBox.Show("0 dan buyuk sayı giriniz");
            }else if(not < 25)
            {
                MessageBox.Show("notunuz 0");
            }
            else if (not < 45)
            {
                MessageBox.Show("notunuz 1");
            }
            else if (not < 55)
            {
                MessageBox.Show("notunuz 2");
            }
            else if (not < 70)
            {
                MessageBox.Show("notunuz 3");
            }
            else if (not < 85)
            {
                MessageBox.Show("notunuz 4");
            }
            else 
            {
                MessageBox.Show("notunuz 5");
            }





        }
    }
}
