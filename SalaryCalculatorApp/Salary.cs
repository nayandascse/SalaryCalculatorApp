using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class Salary
    {
        public string employeeName;
        public double basicAmount = 0;
        public double totalAmount = 0;

        public double GetTotalSalary(double houseRent, double medicalAllowance)
        {
            return basicAmount + (basicAmount*houseRent*0.01) + (basicAmount*medicalAllowance*0.01);
        }

    }
}
