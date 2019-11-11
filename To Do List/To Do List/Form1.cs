using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkBox5.Checked && checkBox6.Checked && checkBox7.Checked && checkBox8.Checked)
            {
                label1.Text = ("Great Job!");
            }
            else
            {
                MessageBox.Show("Oops, looks like you still have to finish all of your daily to do list!");
            }
            if (checkBox9.Checked && checkBox10.Checked && checkBox11.Checked && checkBox12.Checked && checkBox13.Checked && checkBox14.Checked && checkBox15.Checked && checkBox16.Checked)
            {
                label2.Text = ("Fantastic!");
            }
            else
            {
                MessageBox.Show("Make sure you complete all your weekly tasks!");
            }
            if (checkBox17.Checked && checkBox18.Checked && checkBox19.Checked && checkBox20.Checked && checkBox21.Checked && checkBox22.Checked && checkBox23.Checked && checkBox24.Checked)
            {
                label3.Text = ("All Done!");
            }
            else
            {
                MessageBox.Show("Don't forget about all your monthly tasks!");
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
