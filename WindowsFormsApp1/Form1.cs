using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            string i = "item" + n++.ToString();
            comboBox1.Items.Add(i);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.ToLongTimeString();

        }
    }
}
