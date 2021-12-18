using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace madatyan62
{
    public partial class Form2 : Form
    {
        float index;
        float r;
        float V;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            r = float.Parse(rost.Text);
            V = float.Parse(ves.Text);
            r = r / 100;
            index = V / (r * r);
           label1.Text = index.ToString();
            trackBar1.Value = (int)index;
            progressBar1.Value = (int)index;
        }
    }
}
