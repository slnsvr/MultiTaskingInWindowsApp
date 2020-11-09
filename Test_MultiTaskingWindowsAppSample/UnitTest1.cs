using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiTaskingWindowsAppSample;

namespace Test_MultiTaskingWindowsAppSample
{
    [TestClass]
    public class TestHelper
    {
        [TestInitialize]
        public void TestInitialize()
        {
            //nothing as of now
        }

        [TestMethod]
        public void SaveAndGetEmployeeDetails()
        {
            Helper helper = new Helper();
            //sample input  
            Employee emp = new Employee { ID = 101, Age = 32, Gender = "M", Name = "Lakshman" };
            helper.SaveEmployeeDetails(Convert.ToString(emp.ID), emp.Name, emp.Gender, Convert.ToString(emp.Age));

            Assert.IsTrue(helper.GetAge(Convert.ToString(emp.ID)) == 32);
            Assert.IsTrue(helper.GetID(Convert.ToString(emp.ID)) == 101);
            Assert.IsTrue(helper.GetGender(Convert.ToString(emp.ID)) == "M");
            Assert.IsTrue(helper.GetName(Convert.ToString(emp.ID)) == "Lakshman");
        }
    }
}
