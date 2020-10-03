using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Encuesta
{
    public partial class Form4 : Form
    {
        string i="0";
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i += 1;
            label3.Text = i;
            label2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;

            label4.Visible = true;
            button3.Visible = true;
            button4.Visible = true;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            i += 1;
            label3.Text = i;
            label4.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            label5.Visible = true;
            button7.Visible = true;
            button6.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            label2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;

            label4.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            label5.Visible = true;
            button7.Visible = true;
            button6.Visible = true;
        }
     

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            i += 1;
            label3.Text = i;

            if (label3.Text == ("0111")) 
            {
                Form5 Form5 = new Form5();
                Form5.Show();
                this.Hide();
            }
            else if (label3.Text == ("011"))
            {
                Form6 Form6 = new Form6();
                Form6.Show();
                this.Hide();
            }
            else if (label3.Text == ("01"))
            {
                Form7 Form7= new Form7();
                Form7.Show();
                this.Hide();
            }
            else if (label3.Text == ("0"))
            {
                Form8 Form8 = new Form8();
                Form8.Show();
                this.Hide();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label3.Text == ("0111"))
            {
                Form5 Form5 = new Form5();
                Form5.Show();
                this.Hide();
            }
            else if (label3.Text == ("011"))
            {
                Form6 Form6 = new Form6();
                Form6.Show();
                this.Hide();
            }
            else if (label3.Text == ("01"))
            {
                Form7 Form7 = new Form7();
                Form7.Show();
                this.Hide();
            }
            else if (label3.Text == ("0"))
            {
                Form8 Form8 = new Form8();
                Form8.Show();
                this.Hide();
            }
        }
    }
}
