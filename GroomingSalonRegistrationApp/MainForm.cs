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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<Customer> allCustomers = SalonDb.getAllCustomers();
            custList(allCustomers);
        }

        private void custList(List<Customer> custs)
        {
            custListBox.Items.Clear();
            foreach(Customer c in custs)
            {
                custListBox.Items.Add(c);
            }
        }

        private void addCustBtn_Click(object sender, EventArgs e)
        {
            AddCustomerForm newCust = new AddCustomerForm();
            newCust.ShowDialog();

            List<Customer> allCustomers = SalonDb.getAllCustomers();
            custList(allCustomers);
        }

        private void addPetBtn_Click(object sender, EventArgs e)
        {
            AddPetForm newPet = new AddPetForm();
            newPet.ShowDialog();
        }
    }
}
