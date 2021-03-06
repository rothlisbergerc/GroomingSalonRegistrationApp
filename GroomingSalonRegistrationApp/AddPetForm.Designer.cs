
namespace GroomingSalonRegistrationApp
{
    partial class AddPetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPetForm));
            this.petNameLabel = new System.Windows.Forms.Label();
            this.petBreedLabel = new System.Windows.Forms.Label();
            this.petAgeLabel = new System.Windows.Forms.Label();
            this.petNameTxt = new System.Windows.Forms.TextBox();
            this.petBreedTxt = new System.Windows.Forms.TextBox();
            this.petAgeTxt = new System.Windows.Forms.TextBox();
            this.addPetSubmitBtn = new System.Windows.Forms.Button();
            this.addPetCancelBtn = new System.Windows.Forms.Button();
            this.errorAddPetLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // petNameLabel
            // 
            this.petNameLabel.AutoSize = true;
            this.petNameLabel.Location = new System.Drawing.Point(39, 28);
            this.petNameLabel.Name = "petNameLabel";
            this.petNameLabel.Size = new System.Drawing.Size(35, 13);
            this.petNameLabel.TabIndex = 0;
            this.petNameLabel.Text = "Name";
            // 
            // petBreedLabel
            // 
            this.petBreedLabel.AutoSize = true;
            this.petBreedLabel.Location = new System.Drawing.Point(39, 54);
            this.petBreedLabel.Name = "petBreedLabel";
            this.petBreedLabel.Size = new System.Drawing.Size(35, 13);
            this.petBreedLabel.TabIndex = 1;
            this.petBreedLabel.Text = "Breed";
            // 
            // petAgeLabel
            // 
            this.petAgeLabel.AutoSize = true;
            this.petAgeLabel.Location = new System.Drawing.Point(39, 80);
            this.petAgeLabel.Name = "petAgeLabel";
            this.petAgeLabel.Size = new System.Drawing.Size(26, 13);
            this.petAgeLabel.TabIndex = 2;
            this.petAgeLabel.Text = "Age";
            // 
            // petNameTxt
            // 
            this.petNameTxt.Location = new System.Drawing.Point(112, 21);
            this.petNameTxt.Name = "petNameTxt";
            this.petNameTxt.Size = new System.Drawing.Size(245, 20);
            this.petNameTxt.TabIndex = 3;
            // 
            // petBreedTxt
            // 
            this.petBreedTxt.Location = new System.Drawing.Point(112, 47);
            this.petBreedTxt.Name = "petBreedTxt";
            this.petBreedTxt.Size = new System.Drawing.Size(245, 20);
            this.petBreedTxt.TabIndex = 4;
            // 
            // petAgeTxt
            // 
            this.petAgeTxt.Location = new System.Drawing.Point(112, 73);
            this.petAgeTxt.Name = "petAgeTxt";
            this.petAgeTxt.Size = new System.Drawing.Size(245, 20);
            this.petAgeTxt.TabIndex = 5;
            // 
            // addPetSubmitBtn
            // 
            this.addPetSubmitBtn.Location = new System.Drawing.Point(112, 148);
            this.addPetSubmitBtn.Name = "addPetSubmitBtn";
            this.addPetSubmitBtn.Size = new System.Drawing.Size(108, 38);
            this.addPetSubmitBtn.TabIndex = 6;
            this.addPetSubmitBtn.Text = "Submit";
            this.addPetSubmitBtn.UseVisualStyleBackColor = true;
            this.addPetSubmitBtn.Click += new System.EventHandler(this.addPetSubmitBtn_Click);
            // 
            // addPetCancelBtn
            // 
            this.addPetCancelBtn.Location = new System.Drawing.Point(249, 148);
            this.addPetCancelBtn.Name = "addPetCancelBtn";
            this.addPetCancelBtn.Size = new System.Drawing.Size(108, 38);
            this.addPetCancelBtn.TabIndex = 7;
            this.addPetCancelBtn.Text = "Cancel";
            this.addPetCancelBtn.UseVisualStyleBackColor = true;
            this.addPetCancelBtn.Click += new System.EventHandler(this.addPetCancelBtn_Click);
            // 
            // errorAddPetLbl
            // 
            this.errorAddPetLbl.AutoSize = true;
            this.errorAddPetLbl.ForeColor = System.Drawing.Color.Red;
            this.errorAddPetLbl.Location = new System.Drawing.Point(185, 111);
            this.errorAddPetLbl.Name = "errorAddPetLbl";
            this.errorAddPetLbl.Size = new System.Drawing.Size(35, 13);
            this.errorAddPetLbl.TabIndex = 9;
            this.errorAddPetLbl.Text = "label1";
            // 
            // AddPetForm
            // 
            this.AcceptButton = this.addPetSubmitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(405, 220);
            this.Controls.Add(this.errorAddPetLbl);
            this.Controls.Add(this.addPetCancelBtn);
            this.Controls.Add(this.addPetSubmitBtn);
            this.Controls.Add(this.petAgeTxt);
            this.Controls.Add(this.petBreedTxt);
            this.Controls.Add(this.petNameTxt);
            this.Controls.Add(this.petAgeLabel);
            this.Controls.Add(this.petBreedLabel);
            this.Controls.Add(this.petNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPetForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Pet";
            this.Load += new System.EventHandler(this.AddPetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label petNameLabel;
        private System.Windows.Forms.Label petBreedLabel;
        private System.Windows.Forms.Label petAgeLabel;
        private System.Windows.Forms.TextBox petNameTxt;
        private System.Windows.Forms.TextBox petBreedTxt;
        private System.Windows.Forms.TextBox petAgeTxt;
        private System.Windows.Forms.Button addPetSubmitBtn;
        private System.Windows.Forms.Button addPetCancelBtn;
        private System.Windows.Forms.Label errorAddPetLbl;
    }
}