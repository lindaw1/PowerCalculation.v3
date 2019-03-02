using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDataLibrary
{
    public class Customer
    {
        // *********TO Do
        // private data
        // hmmm - variables should be private and methods should be public?
        private int accountNo;
        private string customerName;
        private string customerType;
        private decimal chargeAmount;

        // ************TO do
        //public properties
        public int AccountNo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerType { get; set; }
        public decimal ChargeAmount { get; set; }


        // ************TO DO
        // constructor (how to create a Customer
        public Customer(int accountNumber, string customerName, string customerType, decimal chargeAmount)
        {
            //to do
            AccountNo = accountNumber;
            CustomerName = customerName;
            CustomerType = customerType;
            ChargeAmount = chargeAmount;

        }

        // ************TO DO
        // Method --> CalculateCharge that calculates the charge amount
        // for this customer according to the rules



        // TO DO
        // Override the ToString() method that returns a display string.
        public override string ToString() // provide new definition
        {
            return CustomerName + ": " + chargeAmount.ToString("c") + ". ";
        }


    }//class
}//namespace
