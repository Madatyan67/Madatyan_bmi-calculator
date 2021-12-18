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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
           Form Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Form2 Form  = new Form2();
            Form.Show();
            this.Hide();
        }
    }
}
