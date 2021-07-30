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

        private void addCustSubmitBtn_Click(object sender, EventArgs e)
        {
            Customer c = new Customer
            {
                FirstName = custFirstNameTxt.Text,
                LastName = custLastNameTxt.Text,
                PhoneNumber = custPhoneTxt.Text,
                HomeAddress = custAddressTxt.Text
            };
            SalonDb.Add(c);
            custFirstNameTxt.Text = "";
            custLastNameTxt.Text = "";
            custPhoneTxt.Text = "";
            custAddressTxt.Text = "";
        }

        private void addCustCancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to stop adding a customer?", "Really?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
