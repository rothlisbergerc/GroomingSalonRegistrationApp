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
            if (existingCust == null)
            {
                Customer c = new Customer
                {
                    FirstName = custFirstNameTxt.Text,
                    LastName = custLastNameTxt.Text,
                    PhoneNumber = custPhoneTxt.Text,
                    HomeAddress = custAddressTxt.Text
                };
                SalonDb.Add(c);
                cleanTextBoxes();
            }
            else
            {
                existingCust.FirstName = custFirstNameTxt.Text;
                existingCust.LastName = custLastNameTxt.Text;
                existingCust.HomeAddress = custAddressTxt.Text;
                existingCust.PhoneNumber = custPhoneTxt.Text;
                SalonDb.UpdateCust(existingCust);
                cleanTextBoxes();
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
    }
}
