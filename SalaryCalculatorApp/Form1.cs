using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Salary employeeSalary=new Salary();

        private void showButton_Click(object sender, EventArgs e)
        {
            employeeSalary.employeeName = employeeNameTextBox.Text;
            employeeSalary.basicAmount = Convert.ToDouble(basicAmountTextBox.Text);
            MessageBox.Show(employeeSalary.employeeName + " Your " +
                            "total salary=" +
                            employeeSalary.GetTotalSalary(Convert.ToDouble(houseRentTextBox.Text),
                                Convert.ToDouble(medicalAllowanceTextBox.Text)));

        }
    }
}
