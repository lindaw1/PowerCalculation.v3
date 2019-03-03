using CustomerDataLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerCalculation
{ 
    
    public partial class frmLindaPowCal : Form
    {
        // names the power rates as constants
        const decimal RES_MINIMUM_RATE = 6m;
        const decimal RES_KWH_RATE = 0.052m;
        const decimal COM_FLAT_RATE = 60m;
        const decimal COM_KWH_RATE = 0.045m;
        const decimal IND_PEAK_FLAT_RATE = 76m;
        const decimal IND_PEAK_KWH_RATE = 0.065m;
        const decimal IND_OFFPEAK_FLAT_RATE = 40m;
        const decimal IND_OFFPEAK_KWH_RATE = 0.028m;
        const string PATH = "customers.csv";  // external file for storing customer data
        List<Customer> customers = new List<Customer>();

        public frmLindaPowCal()
        {
            InitializeComponent();
        }

        // Residential Power Calulation, activated when user clicks the btnCalculateRes
        private void btnCalculateRes_Click(object sender, EventArgs e)
        {
            //create variables for residential power and cost
            decimal resPower;
            decimal resCost;

            // checks to see if the user entered valid data
            if (Validator.IsProvided(txtResPower, "kWh") &&
                Validator.IsNonNegativeDecimal(txtResPower, "kWh"))
            {
                // input amount of power
                resPower = Convert.ToDecimal(txtResPower.Text);

                // calls the method CalculateResidential to calculate cost of power
                resCost = CalculateResidential(resPower);

                // display the cost
                txtCost.Text = resCost.ToString("c");
            }
        }
        // Method to calculate the cost of residential power.
        private static decimal CalculateResidential(decimal resPower)
        {
            return RES_MINIMUM_RATE + (RES_KWH_RATE * resPower);
        }

        // When the Radio Button for Commercial is clicked, it hides
        // the information for Residentail & Industrial. And clears
        // previous entries.
        private void radCom_CheckedChanged(object sender, EventArgs e)
        {
            lblCommercial.Visible = true;
            txtComPower.Visible = true;
            txtComPower.Select();   // selects the textbox for input
            btnCalculateCom.Visible = true;

            lblResidential.Visible = false;
            txtResPower.Visible = false;
            btnCalculateRes.Visible = false;

            lblIndPeak.Visible = false;
            lblIndOffPeak.Visible = false;
            txtIndPeakPower.Visible = false;
            txtIndOffPeakPower.Visible = false;
            btnCalculateInd.Visible = false;

            ClearForm();  //resets the form to blank
        }
        // When the Radio Button for Industrial is clicked, it hides
        // the information for Residential & Industrial. And clears
        // previous entries.
        private void radInd_CheckedChanged(object sender, EventArgs e)
        {
            lblIndPeak.Visible = true;
            lblIndOffPeak.Visible = true;
            txtIndPeakPower.Visible = true;
            txtIndPeakPower.Select();   // selects the textbox for input
            txtIndOffPeakPower.Visible = true;
            btnCalculateInd.Visible = true;

            lblResidential.Visible = false;
            txtResPower.Visible = false;
            btnCalculateRes.Visible = false;

            lblCommercial.Visible = false;
            txtComPower.Visible = false;
            btnCalculateCom.Visible = false;

            ClearForm();  //resets the form to blank
        }
        // When the Radio Button for Residential is clicked, it hides
        // the information for Commercial & Industrial. And clears
        // previous entries.
    
        private void radRes_CheckedChanged(object sender, EventArgs e)
        {
            lblResidential.Visible = true;
            txtResPower.Visible = true;
            txtResPower.Select();  // selects the textbox for input
            btnCalculateRes.Visible = true;

            lblCommercial.Visible = false;
            txtComPower.Visible = false;
            btnCalculateCom.Visible = false;

            lblIndPeak.Visible = false;
            lblIndOffPeak.Visible = false;
            txtIndPeakPower.Visible = false;
            txtIndOffPeakPower.Visible = false;
            btnCalculateInd.Visible = false;

            ClearForm();  //resets the form to blank
        }

        // Commercial Power Calulation, activated when user clicks the btnCalculateCom
        private void btnCalculateCom_Click(object sender, EventArgs e)
        {
            //create variables
            decimal comPower;
            decimal comCost;
            // checks to see if the user entered valid data
            if (Validator.IsProvided(txtComPower, "kWh") &&
                Validator.IsNonNegativeDecimal(txtComPower, "kWh"))
            {
                // input amount of power
                comPower = Convert.ToDecimal(txtComPower.Text);

                // Call the method to calculate cost of power
                comCost = CalculateCommercialCost(comPower);

                // display the cost
                txtCost.Text = comCost.ToString("c");
            }
        }
        //Method to calculate the cost of Commerical power
        private static decimal CalculateCommercialCost(decimal comPower)
        {
            decimal comCost;
            if (comPower >= 1000)
                comCost = COM_FLAT_RATE + (COM_KWH_RATE * (comPower - 1000));
            else
                comCost = COM_FLAT_RATE;
            return comCost;
        }

        // Industrial Power Calulation, activated when user clicks the btnCalculateInd
        private void btnCalculateInd_Click(object sender, EventArgs e)
        {
            //create variables
            decimal indPeakPower;
            decimal indOffPeakPower;
            decimal indPeakCost;
            decimal indOffPeakCost;
            decimal indTotalCost;

            // checks to see if the user entered valid data
            if (Validator.IsProvided(txtIndPeakPower, "kWh") &&
                Validator.IsProvided(txtIndOffPeakPower, "kWh") &&
                Validator.IsNonNegativeDecimal(txtIndPeakPower, "kWh") &&
                Validator.IsNonNegativeDecimal(txtIndOffPeakPower, "kWh"))
            {
                // input amount of Peak and Off peak power
                indPeakPower = Convert.ToDecimal(txtIndPeakPower.Text);
                indOffPeakPower = Convert.ToDecimal(txtIndOffPeakPower.Text);

                // calls the method to calculate the cost of Industrial Power
                CalculateIndustrialCost(indPeakPower, indOffPeakPower, 
                    out indPeakCost, out indOffPeakCost, out indTotalCost);

                // display the cost
                txtCost.Text = indTotalCost.ToString("c");
            }
        }
        //method to calculate the Industrial Cost of power.
        private static void CalculateIndustrialCost(decimal indPeakPower, decimal indOffPeakPower, out decimal indPeakCost, out decimal indOffPeakCost, out decimal indTotalCost)
        {
            // calculate the cost of the power Peak HOurs, Industrial
            if (indPeakPower >= 1000)
                indPeakCost = IND_PEAK_FLAT_RATE + (IND_PEAK_KWH_RATE * (indPeakPower - 1000));
            else
                indPeakCost = IND_PEAK_FLAT_RATE;

            // calculate the cost of the power off Peak HOurs, Industrial
            if (indOffPeakPower >= 1000)
                indOffPeakCost = IND_OFFPEAK_FLAT_RATE + (IND_OFFPEAK_KWH_RATE * (indOffPeakPower - 1000));
            else
                indOffPeakCost = IND_OFFPEAK_FLAT_RATE;

            indTotalCost = indPeakCost + indOffPeakCost;  //combines Offpeak and peak costs
        }

        //clear the form
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();  //resets the form to blank
            radRes.Checked = true; //resets the form to residential
            ActiveControl = txtResPower;
        }

        //method to clear the form
        private void ClearForm()
        {
            txtResPower.Text = string.Empty;
            txtComPower.Text = string.Empty;
            txtIndOffPeakPower.Text = string.Empty;
            txtIndPeakPower.Text = string.Empty;
            txtCost.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // read all the items in the List Box lstCustomers and put them in a List<Customer>.  
            //Then we will pass this List<Customer> into the SaveCustomers Method.

            SaveCustomers(customers);
    
            Close(); // Exit application
        }

        private void frmLindaPowCal_Load(object sender, EventArgs e)
        {
            radRes.Checked = true;
            ActiveControl = txtResPower;
            ReadCustomers();
        }

        private void ReadCustomers()
        {
            FileStream fs = null;
            StreamReader sr = null;
            string line;
  
            try
            {
                // opening for reading; assuming file exists
                fs = new FileStream(PATH, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs); // file is open
                // do the reading
                while (!sr.EndOfStream) // while not at the end
                {
                    line = sr.ReadLine();
                    string [] customerArray = line.Split(',');
                    Customer customer = new Customer(int.Parse(customerArray[1]),customerArray[0], customerArray[2], decimal.Parse(customerArray[3]));
                    customers.Add(customer);
                }
                BindCustomerData();
            }
            catch (Exception ex)  
            {
                MessageBox.Show("Error while reading: " + ex.Message,
                    ex.GetType().ToString());
            }
            finally // executes always
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
        private void SaveCustomers(List<Customer> customers)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            string line;
            try
            {
                // prepare/create the file for writing
                fs = new FileStream(PATH, FileMode.Create, FileAccess.Write);
                //prepares the file for writing, overrides old content.

                sw = new StreamWriter(fs);

                // write data from the list
                foreach (Customer elem in customers)
                {
                    line = elem.CustomerName + "," + elem.AccountNo.ToString()
                        + "," + elem.CustomerType + "," + elem.ChargeAmount.ToString();
                    sw.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while writing: " + ex.Message,
                    ex.GetType().ToString());
            }
            finally
            {
                if (sw != null) sw.Close();
                if (fs != null) fs.Close();
            }
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            // if statement to find out which radio button is checked.  Assigns a string to the 
            //variable "customerType"
            string customerType = radRes.Checked ? "Res" : (radCom.Checked ? "Com" : ("Ind"));

            // checks to see if the user entered valid data
            if (Validator.IsProvided(txtCustName, "Customer Name") &&
                Validator.IsProvided(txtCustNumber, "Customer Number") &&
                Validator.IsNonNegativeInt(txtCustNumber, "Customer Number") &&
                Validator.IsProvided(txtCost, "Calculate")) 
            {
                // takes data from the form and creates (instantiates) an 
                // object called "customer". (new record).
                Customer customer = new Customer(int.Parse(txtCustNumber.Text), txtCustName.Text,
                    customerType, decimal.Parse(txtCost.Text.Replace('$', ' ')));  
                customers.Add(customer);
                BindCustomerData(); //writes data to list box
            }
        }

        private void BindCustomerData()
        {
            decimal sumResCharges = 0;
            decimal sumComCharges = 0;
            decimal sumIndCharges  = 0;
            decimal sumAll = 0;

            lstCustomers.Items.Clear();
            foreach (Customer cust in customers)
            {
                //writes out the 4 fields for each customer record
                lstCustomers.Items.Add(cust.CustomerName + "\t" + cust.AccountNo + "\t" + cust.ChargeAmount + "\t" + cust.CustomerType);

                //checks what the customer type is, then adds the ChargeAmount to the appropriate customer total.
                if (cust.CustomerType == "Res")
                {
                    sumResCharges += cust.ChargeAmount;
                }
                else if (cust.CustomerType == "Com")
                {
                    sumComCharges += cust.ChargeAmount;
                }
                else
                    sumIndCharges += cust.ChargeAmount;
            }
            lblCustTotal.Text = "Total Number of Customers: " + customers.Count;
            txtSumResCharges.Text = sumResCharges.ToString();
            txtSumComCharges.Text = sumComCharges.ToString();
            txtSumIndCharges.Text = sumIndCharges.ToString();
            sumAll = sumResCharges + sumComCharges + sumIndCharges;
            txtSumAll.Text = sumAll.ToString();
        }
    }
}
