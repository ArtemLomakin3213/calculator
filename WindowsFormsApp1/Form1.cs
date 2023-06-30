using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            textBox4.Clear();
            if (checkBox1.Checked)
            {
                int result = 4 * a + 4 * b + 4 * c;
                textBox4.Text = Convert.ToString(result); 
            } 
            if(checkBox2.Checked)
            {
                int result = a * b * c;
                textBox4.Text = Convert.ToString(result);
            }
            if((checkBox1.Checked && checkBox2.Checked))
            {
                textBox4.Text = "Ошибка!!!";
            }
                textBox5.Text += textBox4.Text + '\r' + '\n';
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible != true)
            {
                groupBox1.Visible = true;
                groupBox3.Visible = false;
            }
            else
                groupBox1.Visible = false;
        }

        private void calcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (groupBox3.Visible != true)
            {
                groupBox3.Visible = true;
                groupBox1.Visible = false;
            }
            else
                groupBox3.Visible = false;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
        }
    }
}
