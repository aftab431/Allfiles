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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            this.label2.Text = "File name";
            this.label1.Text = "Address";
            this.button1.Text = "OK";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fn = this.textBox1.Text + "\\" + this.textBox2.Text;

            if (File.Exists(fn))
            {
                File.Delete(fn);
                MessageBox.Show("File Deleted");

            }

            else
            {
                MessageBox.Show("Not Exists");
            }

            
        }
    }
}
