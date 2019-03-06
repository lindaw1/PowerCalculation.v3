using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDataLibrary
{
    public class Customer
    {
        const decimal RES_MINIMUM_RATE = 6m;
        const decimal RES_KWH_RATE = 0.052m;
        const decimal COM_FLAT_RATE = 60m;
        const decimal COM_KWH_RATE = 0.045m;
        const decimal IND_PEAK_FLAT_RATE = 76m;
        const decimal IND_PEAK_KWH_RATE = 0.065m;
        const decimal IND_OFFPEAK_FLAT_RATE = 40m;
        const decimal IND_OFFPEAK_KWH_RATE = 0.028m;


    
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
        public decimal CalculateCharge(decimal kilowatt, decimal offPeakKilowatt, string customerType)
        {
            decimal charge = 0;
            

            switch(customerType)
            {
                case "Res":
                    charge = RES_MINIMUM_RATE + (RES_KWH_RATE * kilowatt);
                    break;

                case "Com":
                    if (kilowatt >= 1000)
                        charge = COM_FLAT_RATE + (COM_KWH_RATE * (kilowatt - 1000));
                    else
                        charge = COM_FLAT_RATE;
                    break;

                case "Ind":

                    decimal indPeakCost = 0;
                    decimal indOffPeakCost = 0;

                    // calculate the cost of the power Peak HOurs, Industrial
                    if (kilowatt >= 1000)
                        indPeakCost = IND_PEAK_FLAT_RATE + (IND_PEAK_KWH_RATE * (kilowatt - 1000));
                    else
                        indPeakCost = IND_PEAK_FLAT_RATE;

                    // calculate the cost of the power off Peak HOurs, Industrial
                    if (offPeakKilowatt >= 1000)
                        indOffPeakCost = IND_OFFPEAK_FLAT_RATE + (IND_OFFPEAK_KWH_RATE * (offPeakKilowatt - 1000));
                    else
                        indOffPeakCost = IND_OFFPEAK_FLAT_RATE;

                    charge = indPeakCost + indOffPeakCost;  //combines Offpeak and peak costs
                    break;

            }
            return charge;
        }




        // TO DO
        // Override the ToString() method that returns a display string.
        public override string ToString() // provide new definition
        {
            return CustomerName + "\t" + AccountNo + "\t" + ChargeAmount + "\t" + CustomerType;
        }



    }//class
}//namespace
