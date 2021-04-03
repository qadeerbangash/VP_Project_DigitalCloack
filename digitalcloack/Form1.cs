using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace digitalcloack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
            label2.Text = DateTime.Now.ToString("dd");
            label3.Text = DateTime.Now.ToString("MM");
            label4.Text = DateTime.Now.ToString("yyyy");
            label9.Text = DateTime.Now.ToString("dddd");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGoldenrod;
            this.label1.BackColor = Color.DarkSlateBlue;
            this.label9.BackColor = Color.DarkSlateBlue;
            this.label2.BackColor = Color.DarkSlateBlue;
            this.label3.BackColor = Color.DarkSlateBlue;
            this.label4.BackColor = Color.DarkSlateBlue;
            this.label5.BackColor = Color.White;
            this.label6.BackColor = Color.White;
            this.label7.BackColor = Color.White;
            this.label8.BackColor = Color.White;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
