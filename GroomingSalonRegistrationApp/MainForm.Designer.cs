
namespace GroomingSalonRegistrationApp
{
    partial class MainForm
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
            this.custListBox = new System.Windows.Forms.ListBox();
            this.petComboBox = new System.Windows.Forms.ComboBox();
            this.custListBoxLabel = new System.Windows.Forms.Label();
            this.petCboLabel = new System.Windows.Forms.Label();
            this.addCustBtn = new System.Windows.Forms.Button();
            this.addPetBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // custListBox
            // 
            this.custListBox.FormattingEnabled = true;
            this.custListBox.Location = new System.Drawing.Point(26, 43);
            this.custListBox.Name = "custListBox";
            this.custListBox.Size = new System.Drawing.Size(206, 121);
            this.custListBox.TabIndex = 0;
            // 
            // petComboBox
            // 
            this.petComboBox.FormattingEnabled = true;
            this.petComboBox.Location = new System.Drawing.Point(26, 185);
            this.petComboBox.Name = "petComboBox";
            this.petComboBox.Size = new System.Drawing.Size(206, 21);
            this.petComboBox.TabIndex = 1;
            // 
            // custListBoxLabel
            // 
            this.custListBoxLabel.AutoSize = true;
            this.custListBoxLabel.Location = new System.Drawing.Point(23, 27);
            this.custListBoxLabel.Name = "custListBoxLabel";
            this.custListBoxLabel.Size = new System.Drawing.Size(51, 13);
            this.custListBoxLabel.TabIndex = 2;
            this.custListBoxLabel.Text = "Customer";
            // 
            // petCboLabel
            // 
            this.petCboLabel.AutoSize = true;
            this.petCboLabel.Location = new System.Drawing.Point(23, 169);
            this.petCboLabel.Name = "petCboLabel";
            this.petCboLabel.Size = new System.Drawing.Size(23, 13);
            this.petCboLabel.TabIndex = 3;
            this.petCboLabel.Text = "Pet";
            // 
            // addCustBtn
            // 
            this.addCustBtn.Location = new System.Drawing.Point(257, 43);
            this.addCustBtn.Name = "addCustBtn";
            this.addCustBtn.Size = new System.Drawing.Size(138, 29);
            this.addCustBtn.TabIndex = 4;
            this.addCustBtn.Text = "Add Customer";
            this.addCustBtn.UseVisualStyleBackColor = true;
            this.addCustBtn.Click += new System.EventHandler(this.addCustBtn_Click);
            // 
            // addPetBtn
            // 
            this.addPetBtn.Location = new System.Drawing.Point(257, 87);
            this.addPetBtn.Name = "addPetBtn";
            this.addPetBtn.Size = new System.Drawing.Size(138, 29);
            this.addPetBtn.TabIndex = 5;
            this.addPetBtn.Text = "Add Pet";
            this.addPetBtn.UseVisualStyleBackColor = true;
            this.addPetBtn.Click += new System.EventHandler(this.addPetBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(257, 135);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(138, 29);
            this.updateBtn.TabIndex = 6;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(257, 177);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(138, 29);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 262);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addPetBtn);
            this.Controls.Add(this.addCustBtn);
            this.Controls.Add(this.petCboLabel);
            this.Controls.Add(this.custListBoxLabel);
            this.Controls.Add(this.petComboBox);
            this.Controls.Add(this.custListBox);
            this.Name = "MainForm";
            this.Text = "Grooming Salon Registration";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox custListBox;
        private System.Windows.Forms.ComboBox petComboBox;
        private System.Windows.Forms.Label custListBoxLabel;
        private System.Windows.Forms.Label petCboLabel;
        private System.Windows.Forms.Button addCustBtn;
        private System.Windows.Forms.Button addPetBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}

