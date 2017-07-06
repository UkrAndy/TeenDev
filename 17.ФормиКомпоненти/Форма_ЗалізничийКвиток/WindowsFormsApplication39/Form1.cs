using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication39
{
    public partial class Form1 : Form
    {
        double[,] prices = new double[3,3]{ { 2, 11, 354 }, { 45, 32, 123 }, { 45, 32, 123 } };
        public Form1()
        {
            InitializeComponent();
        }
        double sum = 50.6;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sum = Convert.ToDouble((sender as RadioButton).Tag);
            textBox1.Text = sum.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedIndex.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(listBox1.SelectedIndex.ToString());

            foreach (var item in listBox1.SelectedIndices)
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedIndices)
            {
                MessageBox.Show(item.ToString());
            }
        }
    }
}
