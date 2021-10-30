//Scott Neilson W0422816
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {
    public class EmpData {
        public double TaxAmount;

        public double NetTaxAmount;

        public double DependentDeduction;

        public double TotalTakeHome;

        public EmpData(double ta, double nta, double dd, double tth) {
            TaxAmount = ta;
            NetTaxAmount = nta;
            DependentDeduction = dd;
            TotalTakeHome = tth;
        }
    }


}
