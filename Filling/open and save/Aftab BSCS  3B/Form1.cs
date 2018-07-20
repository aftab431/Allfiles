using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aftab_BSCS__3B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //names
            this.Text = "Assignment";
            this.button1.Text = "File";
            this.button2.Text = "Reset";
            this.button3.Text = "Exit";
            this.button4.Text = "About";
            this.label1.Text = "File Name";
            
            //visible Property
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.button4.Visible = false;
            this.label1.Visible = false;
            this.textBox1.Visible = false;
            this.textBox2.Visible = false;

            //Scrollbars
            this.textBox2.ScrollBars = ScrollBars.Both;

            //Defualt Font & Style
            this.label1.Font = new Font(label1.Font, FontStyle.Bold);
            this.textBox2.Font = new Font(textBox2.Font, FontStyle.Bold);
            this.textBox2.Font = new Font("Raviel", 11);
            this.button1.Font = new Font("Algerian", 11);
            this.button2.Font = new Font("Algerian", 11);
            this.button3.Font = new Font("Algerian", 11);
            this.button4.Font = new Font("Algerian", 11);
            this.label1.Font = new Font("Mistral", 15);
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
            this.Hide();
            Form2 f = new Form2(this);
            f.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = "Assignment";
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.label1.Visible = false;
            this.textBox1.Visible = false;
            this.textBox2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name : Muhammad Aftab \nS/o : Muhammad Altaf \nSection : BSCS 3B", " About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
