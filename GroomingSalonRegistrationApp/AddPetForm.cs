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
    public partial class AddPetForm : Form
    {
        public AddPetForm()
        {
            InitializeComponent();
        }

        //Similar to customer where itll be needed for update.
        Pet exisitingPet;
        public AddPetForm(Pet p)
        {
            InitializeComponent();
            //Had to put to the left in order to parse.
            petAgeTxt.Text = p.Age.ToString();
            petBreedTxt.Text = p.Breed;
            petNameTxt.Text = p.Name;

            exisitingPet = p;
        }

        private void cleanTextBoxes()
        {
            petBreedTxt.Text = "";
            petAgeTxt.Text = "";
            petNameTxt.Text = "";
        }

        private void addPetSubmitBtn_Click(object sender, EventArgs e)
        {
            if (exisitingPet == null)
            {
                Pet p = new Pet()
                {
                    Age = float.Parse(petAgeTxt.Text),
                    Breed = petBreedTxt.Text,
                    Name = petNameTxt.Text
                };
                SalonDb.Add(p);
                cleanTextBoxes();
            }
            else
            {
                exisitingPet.Age = float.Parse(petAgeTxt.Text);
                exisitingPet.Breed = petBreedTxt.Text;
                exisitingPet.Name = petNameTxt.Text;
                SalonDb.UpdatePet(exisitingPet);
                cleanTextBoxes();
            }
        }

        private void addPetCancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to stop adding a pet?", "Really?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
