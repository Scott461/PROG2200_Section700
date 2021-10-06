using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SalaryCalculator
    {
        const int HoursInYear = 2080; // constant number of hours in a year 
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
    }
}
