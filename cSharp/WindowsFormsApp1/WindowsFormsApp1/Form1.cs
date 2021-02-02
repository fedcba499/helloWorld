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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, sum;
            num1 = Int32.Parse(tb_num1.Text);
            num2 = Int32.Parse(tb_num2.Text);
            sum = num1 + num2;
            lbl_sum.Text = sum.ToString();
        }

        private void button1_Resize(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cn.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter1.Fill(this.cn.Customers);
            // TODO: This line of code loads data into the 'databaseDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.databaseDataSet.Customers);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fullNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void customersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void fullNameLabel1_Click(object sender, EventArgs e)
        {

        }

        private void fullNameTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel1_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressLabel1_Click(object sender, EventArgs e)
        {

        }

        private void addressTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneLabel1_Click(object sender, EventArgs e)
        {

        }

        private void phoneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void genderLabel1_Click(object sender, EventArgs e)
        {

        }

        private void genderComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
