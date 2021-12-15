using EmployeePayRollSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace EmployeePayrollTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given10Employee_WhenAddedToList_ShouldMatchEmployeeEntries()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Varun1", PhoneNumber: "9603331139", Address: "VDP", Department: "PROD", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Varun2", PhoneNumber: "9603331139", Address: "VDP", Department: "PROD", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Varun3", PhoneNumber: "9603331139", Address: "VDP", Department: "PROD", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india")); 
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Varun4", PhoneNumber: "9603331139", Address: "VDP", Department: "PROD", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Varun5", PhoneNumber: "9603331139", Address: "VDP", Department: "PROD", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Varun6", PhoneNumber: "9603331139", Address: "VDP", Department: "PROD", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Varun7", PhoneNumber: "9603331139", Address: "VDP", Department: "PROD", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Varun8", PhoneNumber: "9603331139", Address: "VDP", Department: "PROD", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Varun9", PhoneNumber: "9603331139", Address: "VDP", Department: "PROD", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Varun10", PhoneNumber: "9603331139", Address: "VDP", Department: "PROD", Gender: 'M', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));

            EmployeePayRollOperation employeePayRollOperation = new EmployeePayRollOperation();
            employeePayRollOperation.addEmployeeToPayRoll(employeeDetails);
        }
    }
}