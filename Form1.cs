using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMarksCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string studentName = txtName.Text.Trim();
            if (string.IsNullOrWhiteSpace(studentName))
            {
                MessageBox.Show("Please enter the student name.");
                txtName.Focus();
                return;
            }
            if (!int.TryParse(txtSubject1.Text, out int mark1) ||
                !int.TryParse(txtSubject2.Text, out int mark2) ||
                !int.TryParse(txtSubject3.Text, out int mark3))
            {
                MessageBox.Show("Enter valid whole-number marks.");
                return;

            }
            if (mark1 < 0 || mark1 > 100 ||
                mark2 < 0 || mark2 > 100 ||
                mark3 < 0 || mark3 > 100)
            {
                MessageBox.Show("Each mark must be from 0 to 100.");
                return;
            }
            int total = mark1 + mark2 + mark3;
            double average = total / 3.0;
            string result = average >= 40 ? "Pass" : "Fail";

            lblTotal.Text = "Total: " + total;
            lblAverage.Text = "Average: " + average.ToString("F2");
            lblResult.Text = "Result: " + result;

            MessageBox.Show(
                "student: " + studentName +
                "\\nTotal: " + total +
                "\\nAverage: " + average.ToString("F2") +
                "\\nResult: " + result,
                "student Results");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtSubject1.Clear();
            txtSubject2.Clear();
            txtSubject3.Clear();

            lblTotal.Text = "Total:";
            lblAverage.Text = "Average:";
            lblResult.Text = "Result:";

            txtName.Focus();
        }
    }
}
