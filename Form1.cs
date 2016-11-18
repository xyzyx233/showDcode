using codedecode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace showDcode
{
    public partial class Form1 : Form
    {
        Dcode d;
        public Form1()
        {
            InitializeComponent();
            d = new Dcode();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = d.Code;
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d.go();
            textBox1.Text =d.Code;
        }
    }
}
