using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator 
{
    public class TaxData 
    {
        public double ProvincialTaxWithheld;

        public double FederalTaxWithheld;

        public double DependentDeduction;

        public double TotalWithheld;

        public double TotalTakeHome;

        public TaxData(double ptwh, double ftwh, double dd, double twh, double tth) 
        {
            ProvincialTaxWithheld = ptwh;
            FederalTaxWithheld = ftwh;
            DependentDeduction = dd;
            TotalWithheld = twh;
            TotalTakeHome = tth;
        }
    }
}
