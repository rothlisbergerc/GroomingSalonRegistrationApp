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

            List<Pet> allPets = SalonDb.getAllPets();
            petList(allPets);
        }


        private void custList(List<Customer> custs)
        {
            custListBox.Items.Clear();
            foreach (Customer c in custs)
            {
                custListBox.Items.Add(c);
            }
        }

        private void petList(List<Pet> pets)
        {
            petComboBox.Items.Clear();
            foreach (Pet p in pets)
            {
                petComboBox.Items.Add(p);
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

            List<Pet> allPets = SalonDb.getAllPets();
            petList(allPets);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            //If the customer has only a name selected will update them otherwise will update pet.
            if (custListBox.SelectedIndex > -1 && petComboBox.SelectedIndex == -1)
            {
                Customer selectCust = custListBox.SelectedItem as Customer;
                AddCustomerForm updateCust = new AddCustomerForm(selectCust);
                updateCust.ShowDialog();
                custList(SalonDb.getAllCustomers());

                //Resets the selected indexes after being updated.
                custListBox.SelectedIndex = -1;
                petComboBox.SelectedIndex = -1;
            }
            else
            {
                Pet selectPet = petComboBox.SelectedItem as Pet;
                AddPetForm updatePet = new AddPetForm(selectPet);
                updatePet.ShowDialog();
                petList(SalonDb.getAllPets());

                //Same as above.
                custListBox.SelectedIndex = -1;
                petComboBox.SelectedIndex = -1;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(custListBox.SelectedIndex < 0)
            {
                MessageBox.Show("You need a customer to delete");
            }
            else
            {
                Customer selectCust = custListBox.SelectedItem as Customer;
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {selectCust}","Delete?",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    custListBox.SelectedIndex = -1;
                    SalonDb.DeleteCust(selectCust);
                    custList(SalonDb.getAllCustomers());
                }
            }
        }
    }
}
