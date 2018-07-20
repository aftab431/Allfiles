using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace filling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.groupBox1.Text = "File";
            this.radioButton1.Text = "Copy";
            this.radioButton2.Text = "Delete";
            this.radioButton3.Text = "Exiest";
            this.button1.Text = "OK";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                this.Hide();
                Copy c = new Copy();
                c.Show();
            }

            if (radioButton2.Checked)
            {
                this.Hide();
                Delete c = new Delete();
                c.Show();
            }
        }

    }
}
