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
            Pet p = new Pet();
            if (exisitingPet == null)
            {
                if (validatePet(p))
                {
                    p.Age = float.Parse(petAgeTxt.Text);
                    p.Breed = petBreedTxt.Text;
                    p.Name = petNameTxt.Text;
                    SalonDb.Add(p);
                    cleanTextBoxes();
                }
            }
            else
            {
                if (validatePet(p))
                {
                    exisitingPet.Age = float.Parse(petAgeTxt.Text);
                    exisitingPet.Breed = petBreedTxt.Text;
                    exisitingPet.Name = petNameTxt.Text;
                    SalonDb.UpdatePet(exisitingPet);
                    cleanTextBoxes();
                }
            }
        }

        private void addPetCancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to exit?", "Really?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private bool validatePet(Pet p)
        {
            if (String.IsNullOrEmpty(petNameTxt.Text))
            {
                errorAddPetLbl.Text = "Every pet has a name";
                return false;
            }
            else if (String.IsNullOrEmpty(petBreedTxt.Text))
            {
                errorAddPetLbl.Text = "Need a pet breed";
                return false;
            }
            else if (String.IsNullOrEmpty(petAgeTxt.Text))
            {
                errorAddPetLbl.Text = "Your pet is at least some age.";
                return false;
            }
            else if(!Int32.TryParse(petAgeTxt.Text, out _))
            {
                errorAddPetLbl.Text = "Pet age needs to be a number";
                return false;
            }
            else
            {
                errorAddPetLbl.Text = "";
                return true;
            }
        }

        private void AddPetForm_Load(object sender, EventArgs e)
        {
            errorAddPetLbl.Text = "";
        }
    }
}
