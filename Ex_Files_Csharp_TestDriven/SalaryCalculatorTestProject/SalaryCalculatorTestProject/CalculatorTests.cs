using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace SalaryCalculatorTestProject
{
    /*		
        To get hourly, divide annual salary by 2080     
        $100,006.40 / 2080 = $48.08  hr

        To get annual, multiply hourly by 2080 
        $48.08 * 2080 = $100,006.40
    */

    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AnnualSalaryTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            decimal annualSalary = sc.GetAnnualSalary(50);

            // Assert   
            Assert.AreEqual(104000, annualSalary);
        }

        [TestMethod]
        public void HourlyWageTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            decimal hourlyWage = sc.GetHourlyWage(52000);

            // Assert   
            Assert.AreEqual(25, hourlyWage);
        }

        [TestMethod]
        public void AnnualSalaryTestNegative()
        {
            //Arrange
            SalaryCalculator sc = new SalaryCalculator();
            //Act
            try
            { // A negative test. Should throw an exception
                decimal annualSalary = sc.GetAnnualSalary(-50);
                //Assert
                Assert.Fail("This code should not be run. Exception expected.");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Hourly wage must be greater than zero.", ex.Message);
            }
        }

        [TestMethod]
        public void TaxWithholdingTest()
        {
            //Arrange
            SalaryCalculator sc = new SalaryCalculator();
            //Act
            TaxData taxData = sc.TaxWithheld(1000, 2);
            //Assert
            Assert.AreEqual(60.0, taxData.ProvincialTaxWithheld);
            Assert.AreEqual(250.0, taxData.FederalTaxWithheld);
            Assert.AreEqual(40.0, taxData.DependentDeduction);
            Assert.AreEqual(270.0, taxData.TotalWithheld);
            Assert.AreEqual(730.0, taxData.TotalTakeHome);
        }


    }
}
