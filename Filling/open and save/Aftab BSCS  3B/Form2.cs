using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Aftab_BSCS__3B
{
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2(Form1 ff1)
        {
            f1 = ff1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Names
            this.Text = "Option";
            this.button1.Text = "Open";
            this.button2.Text = "Save";
            this.button3.Text = "OK";
            this.button4.Text = "EXIT";
            this.label1.Text = "File Name";

            //Defualt Font & Style
            this.button1.Font = new Font("Algerian", 11);
            this.button2.Font = new Font("Algerian", 11);
            this.button3.Font = new Font("Algerian", 11);
            this.button4.Font = new Font("Algerian", 11);
            this.label1.Font = new Font("Mistral", 13);
            this.BackColor = Color.Maroon;
            this.button1.BackColor = Color.Black;
            this.button1.ForeColor = Color.White;
            this.button2.BackColor = Color.Black;
            this.button2.ForeColor = Color.White;
            this.button3.BackColor = Color.Black;
            this.button3.ForeColor = Color.White;
            this.button4.BackColor = Color.Black;
            this.button4.ForeColor = Color.White;
            this.label1.ForeColor = Color.White;

            //Control Box
            this.ControlBox = false;
      
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fn = openFileDialog1.FileName;
               f1.textBox2.Text = File.ReadAllText(fn);
               f1.textBox1.Text = openFileDialog1.FileName;
               this.textBox1.Text = openFileDialog1.FileName;
                f1.Text = openFileDialog1.FileName; 
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "text(*txt)|*txt";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fn = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(fn, f1.textBox2.Text);
                f1.Text = saveFileDialog1.FileName;
                f1.textBox1.Text = saveFileDialog1.FileName;
                this.textBox1.Text = saveFileDialog1.FileName;
                f1.Text = saveFileDialog1.FileName;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f1.button2.Visible = true;
            f1.button3.Visible = true;
            f1.label1.Visible = true;
            this.textBox1.Visible = true;
            f1.textBox1.Visible = true;
            f1.textBox2.Visible = true;
            f1.button4.Visible = true;
            this.Hide();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
