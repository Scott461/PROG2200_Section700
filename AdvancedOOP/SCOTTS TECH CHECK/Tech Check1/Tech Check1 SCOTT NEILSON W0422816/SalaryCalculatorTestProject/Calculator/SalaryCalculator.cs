using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SalaryCalculator
    {
        const int HoursInYear = 2080;

         public decimal GetAnnualSalary(decimal hourlyWage) // calculates annual salary 
        {
            if (hourlyWage > 0)
                return hourlyWage * HoursInYear;
            else
                throw new InvalidOperationException("Hourly wage must be greater than zero.");// throw exception if negative wages 
        }

        public decimal GetHourlyWage(int annualSalary)//calculates hourly wage
           {
            if (annualSalary > 0)
                return annualSalary / HoursInYear;
            else
                throw new InvalidOperationException("Yearly salary must be greater than zero."); // throw exception if negative salary 
        }

        public EmpData TaxWithheld(decimal weeklySalary, int numDependents) // calculate tax data 
        {
            if (weeklySalary > 0) {
                decimal dd = 0;

                decimal ta = 0.25m * weeklySalary; // federal 
                if (numDependents >= 0) // dependent deduction
                    dd = 0.05m * numDependents * weeklySalary;
                else
                    throw new InvalidOperationException("Number dependents cannot be negative."); // can't have negative kids
                decimal nta = ta - dd;// total withheld 
                decimal tth = weeklySalary - nta; //total take home

                return new EmpData((double)ta, (double)nta, (double)dd, (double)tth);
            } else
                throw new InvalidOperationException("Weekly salary must be greater than zero.");
        }

    }
}
