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
    
        const string PATH = "Customers.csv";  // external file for storing customer data
        List<Customer> customers = new List<Customer>();

        public frmLindaPowCal()
        {
            InitializeComponent();
        }

            private void radCom_CheckedChanged(object sender, EventArgs e)
        {
            ResComSelected();
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
 

            lblResidential.Visible = false;
            txtResComPower.Visible = false;

            ClearForm();  //resets the form to blank
        }
        // When the Radio Button for Residential is clicked, it hides
        // the information for Commercial & Industrial. And clears
        // previous entries.

        private void radRes_CheckedChanged(object sender, EventArgs e)
        {
            ResComSelected();
        }

        private void ResComSelected()
        {
            lblResidential.Visible = true;
            txtResComPower.Visible = true;
            txtCustName.Select();  // selects the CustName textbox for input

            lblIndPeak.Visible = false;
            lblIndOffPeak.Visible = false;
            txtIndPeakPower.Visible = false;
            txtIndOffPeakPower.Visible = false;

            ClearForm();  //resets the form to blank
        }
       
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();  //resets the form to blank
            radRes.Checked = true; //resets the form to residential
            ActiveControl = txtCustName;
        }

        //method to clear the form
        private void ClearForm()
        {
            txtResComPower.Text = string.Empty;
            txtIndOffPeakPower.Text = string.Empty;
            txtIndPeakPower.Text = string.Empty;
            txtCustName.Text = string.Empty;
            txtCustNumber.Text = string.Empty;
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
            ActiveControl = txtResComPower;
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
                    string[] customerArray = line.Split(',');
                    Customer customer = new Customer(int.Parse(customerArray[1]), customerArray[0], 
                        customerArray[2], decimal.Parse(customerArray[3]));
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
                Validator.IsNonNegativeInt(txtCustNumber, "Customer Number"))
            {

                // takes data from the form and creates (instantiates) an 
                // object called "customer". (new record).
                Customer customer = new Customer(int.Parse(txtCustNumber.Text), txtCustName.Text,
                    customerType, 0);
                if (customer.CustomerType == "Ind")
                {
                    customer.ChargeAmount = customer.CalculateCharge(decimal.Parse(txtIndPeakPower.Text), 
                        decimal.Parse(txtIndOffPeakPower.Text), customer.CustomerType);
                }
                else
                {
                    customer.ChargeAmount = customer.CalculateCharge(decimal.Parse(txtResComPower.Text), 0, 
                        customer.CustomerType);
                }
                customers.Add(customer);
                BindCustomerData(); //writes data to list box
                ClearForm(); //clears form for next entry

            }
        }

        private void BindCustomerData()
        {
            decimal sumResCharges = 0;
            decimal sumComCharges = 0;
            decimal sumIndCharges = 0;
            decimal sumAll = 0;

            lstCustomers.Items.Clear();
            foreach (Customer cust in customers)
            {
                //writes out the 4 fields for each customer record
                lstCustomers.Items.Add(cust.ToString());

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
