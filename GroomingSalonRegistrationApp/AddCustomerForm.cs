using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroomingSalonRegistrationApp
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        //Need an existing customer variable to be able to store for the update.
        Customer existingCust;
        public AddCustomerForm(Customer c)
        {
            InitializeComponent();
            custFirstNameTxt.Text = c.FirstName;
            custLastNameTxt.Text = c.LastName;
            custAddressTxt.Text = c.HomeAddress;
            custPhoneTxt.Text = c.PhoneNumber;

            existingCust = c;
        }

        private void addCustSubmitBtn_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            if (existingCust == null)
            {
                if (validateCustomer(c))
                {
                    c.FirstName = custFirstNameTxt.Text;
                    c.LastName = custLastNameTxt.Text;
                    c.PhoneNumber = custPhoneTxt.Text;
                    c.HomeAddress = custAddressTxt.Text;
                    SalonDb.Add(c);
                    cleanTextBoxes();
                }
            }
            else
            {
                if (validateCustomer(c))
                {
                    existingCust.FirstName = custFirstNameTxt.Text;
                    existingCust.LastName = custLastNameTxt.Text;
                    existingCust.HomeAddress = custAddressTxt.Text;
                    existingCust.PhoneNumber = custPhoneTxt.Text;
                    SalonDb.UpdateCust(existingCust);
                    cleanTextBoxes();
                }
            }
        }

        private void cleanTextBoxes()
        {
            custFirstNameTxt.Text = "";
            custLastNameTxt.Text = "";
            custPhoneTxt.Text = "";
            custAddressTxt.Text = "";
        }

        private void addCustCancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to exit?", "Really?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private bool validateCustomer(Customer c)
        {
            if(String.IsNullOrEmpty(custFirstNameTxt.Text))
            {
                errorAddCustLbl.Text = "Cannot be missing a first name";
                return false;
            }
            else if(String.IsNullOrEmpty(custLastNameTxt.Text))
            {
                errorAddCustLbl.Text = "Cannot be missing a last name";
                return false;
            }
            else if(String.IsNullOrEmpty(custPhoneTxt.Text))
            {
                errorAddCustLbl.Text = "You need to add a phone number";
                return false;
            }
            else if(!Int32.TryParse(custPhoneTxt.Text,out _))
            {
                errorAddCustLbl.Text = "Phone number needs to consist of numbers only";
                return false;
            }
            else if(String.IsNullOrEmpty(custAddressTxt.Text))
            {
                errorAddCustLbl.Text = "You need to have a home address";
                return false;
            }
            else
            {
                errorAddCustLbl.Text = "";
                return true;
            }
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            errorAddCustLbl.Text = "";
        }
    }
}
