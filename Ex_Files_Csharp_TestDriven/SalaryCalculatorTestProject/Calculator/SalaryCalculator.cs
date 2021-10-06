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

        public decimal GetAnnualSalary(decimal hourlyWage)
        {
            if (hourlyWage <= 0)
            {
                throw new InvalidOperationException("Hourly wage must be greater than zero.");
            }
            return hourlyWage* HoursInYear;
        }
        public decimal GetHourlyWage(int annualSalary) => annualSalary / HoursInYear;

        public TaxData TaxWithheld(double weeklySalary, int numDependents)
        {
            
            TaxData objectOne = new TaxData();
            objectOne.ProvincialTaxWithheld = 0.06 * weeklySalary; // 
            objectOne.FederalTaxWithheld = 0.25 * weeklySalary;           
            objectOne.DependentDeduction = 0.02 * weeklySalary * numDependents; //
            objectOne.TotalWithheld= objectOne.ProvincialTaxWithheld + objectOne.FederalTaxWithheld
                                            - objectOne.DependentDeduction;
            objectOne.TotalTakeHome = weeklySalary - objectOne.TotalWithheld;



            return objectOne;
        }
    }
    
}
