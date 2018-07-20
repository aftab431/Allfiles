using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace filling
{
    public partial class Copy : Form
    {
        public Copy()
        {
            InitializeComponent();
        }

        private void Copy_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Address";
            this.label2.Text = "File name";
            this.label3.Text = "Destination add";
            this.button1.Text = "OK";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fn = this.textBox1.Text + "\\" + this.textBox2.Text;
            String destname = this.textBox3.Text + "\\" + this.textBox2.Text;

            if (File.Exists(fn))
            {
                    MessageBox.Show("File exists Do you want to replace the File");
                    File.Delete(fn);
                    File.Copy(fn, destname);
            }

            else
            {
                File.Copy(fn, destname);
                MessageBox.Show("File copied");
            }
        }
    }
}
