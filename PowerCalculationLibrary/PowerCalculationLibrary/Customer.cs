using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDataLibrary
{
    public class Customer
    {
       
        // private data - fields
        private int accountNo;
        private string customerName;
        private string customerType;
        private decimal chargeAmount;

    
        //public properties
        public int AccountNo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerType { get; set; }
        public decimal ChargeAmount { get; set; }


        
        // constructor (how to create a Customer)
        public Customer(int accountNumber, string customerName, string customerType, decimal chargeAmount)
        {
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
        //public override string ToString() // provide new definition
        //{
        //    return CustomerName + ": " + chargeAmount.ToString("c") + ". ";
        //}


    }//class
}//namespace
