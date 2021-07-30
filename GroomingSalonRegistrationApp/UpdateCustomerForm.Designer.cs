
namespace GroomingSalonRegistrationApp
{
    partial class UpdateCustomerForm
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
            this.updateCustSubmitBtn = new System.Windows.Forms.Button();
            this.updateCustCancelBtn = new System.Windows.Forms.Button();
            this.updateFirstNameLabel = new System.Windows.Forms.Label();
            this.updateLastNameLabel = new System.Windows.Forms.Label();
            this.updatePhoneLabel = new System.Windows.Forms.Label();
            this.updateAddressLabel = new System.Windows.Forms.Label();
            this.updateFirstNameTxt = new System.Windows.Forms.TextBox();
            this.updateLastNameTxt = new System.Windows.Forms.TextBox();
            this.updatePhoneTxt = new System.Windows.Forms.TextBox();
            this.updateAddressTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // updateCustSubmitBtn
            // 
            this.updateCustSubmitBtn.Location = new System.Drawing.Point(136, 139);
            this.updateCustSubmitBtn.Name = "updateCustSubmitBtn";
            this.updateCustSubmitBtn.Size = new System.Drawing.Size(105, 32);
            this.updateCustSubmitBtn.TabIndex = 0;
            this.updateCustSubmitBtn.Text = "Submit";
            this.updateCustSubmitBtn.UseVisualStyleBackColor = true;
            // 
            // updateCustCancelBtn
            // 
            this.updateCustCancelBtn.Location = new System.Drawing.Point(284, 139);
            this.updateCustCancelBtn.Name = "updateCustCancelBtn";
            this.updateCustCancelBtn.Size = new System.Drawing.Size(105, 32);
            this.updateCustCancelBtn.TabIndex = 1;
            this.updateCustCancelBtn.Text = "Cancel";
            this.updateCustCancelBtn.UseVisualStyleBackColor = true;
            // 
            // updateFirstNameLabel
            // 
            this.updateFirstNameLabel.AutoSize = true;
            this.updateFirstNameLabel.Location = new System.Drawing.Point(44, 30);
            this.updateFirstNameLabel.Name = "updateFirstNameLabel";
            this.updateFirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.updateFirstNameLabel.TabIndex = 2;
            this.updateFirstNameLabel.Text = "First Name";
            // 
            // updateLastNameLabel
            // 
            this.updateLastNameLabel.AutoSize = true;
            this.updateLastNameLabel.Location = new System.Drawing.Point(44, 56);
            this.updateLastNameLabel.Name = "updateLastNameLabel";
            this.updateLastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.updateLastNameLabel.TabIndex = 3;
            this.updateLastNameLabel.Text = "Last Name";
            // 
            // updatePhoneLabel
            // 
            this.updatePhoneLabel.AutoSize = true;
            this.updatePhoneLabel.Location = new System.Drawing.Point(44, 82);
            this.updatePhoneLabel.Name = "updatePhoneLabel";
            this.updatePhoneLabel.Size = new System.Drawing.Size(78, 13);
            this.updatePhoneLabel.TabIndex = 4;
            this.updatePhoneLabel.Text = "Phone Number";
            // 
            // updateAddressLabel
            // 
            this.updateAddressLabel.AutoSize = true;
            this.updateAddressLabel.Location = new System.Drawing.Point(44, 108);
            this.updateAddressLabel.Name = "updateAddressLabel";
            this.updateAddressLabel.Size = new System.Drawing.Size(45, 13);
            this.updateAddressLabel.TabIndex = 5;
            this.updateAddressLabel.Text = "Address";
            // 
            // updateFirstNameTxt
            // 
            this.updateFirstNameTxt.Location = new System.Drawing.Point(136, 23);
            this.updateFirstNameTxt.Name = "updateFirstNameTxt";
            this.updateFirstNameTxt.Size = new System.Drawing.Size(253, 20);
            this.updateFirstNameTxt.TabIndex = 6;
            // 
            // updateLastNameTxt
            // 
            this.updateLastNameTxt.Location = new System.Drawing.Point(136, 49);
            this.updateLastNameTxt.Name = "updateLastNameTxt";
            this.updateLastNameTxt.Size = new System.Drawing.Size(253, 20);
            this.updateLastNameTxt.TabIndex = 7;
            // 
            // updatePhoneTxt
            // 
            this.updatePhoneTxt.Location = new System.Drawing.Point(136, 75);
            this.updatePhoneTxt.Name = "updatePhoneTxt";
            this.updatePhoneTxt.Size = new System.Drawing.Size(253, 20);
            this.updatePhoneTxt.TabIndex = 8;
            // 
            // updateAddressTxt
            // 
            this.updateAddressTxt.Location = new System.Drawing.Point(136, 101);
            this.updateAddressTxt.Name = "updateAddressTxt";
            this.updateAddressTxt.Size = new System.Drawing.Size(253, 20);
            this.updateAddressTxt.TabIndex = 9;
            // 
            // UpdateCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 201);
            this.Controls.Add(this.updateAddressTxt);
            this.Controls.Add(this.updatePhoneTxt);
            this.Controls.Add(this.updateLastNameTxt);
            this.Controls.Add(this.updateFirstNameTxt);
            this.Controls.Add(this.updateAddressLabel);
            this.Controls.Add(this.updatePhoneLabel);
            this.Controls.Add(this.updateLastNameLabel);
            this.Controls.Add(this.updateFirstNameLabel);
            this.Controls.Add(this.updateCustCancelBtn);
            this.Controls.Add(this.updateCustSubmitBtn);
            this.Name = "UpdateCustomerForm";
            this.Text = "Update Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateCustSubmitBtn;
        private System.Windows.Forms.Button updateCustCancelBtn;
        private System.Windows.Forms.Label updateFirstNameLabel;
        private System.Windows.Forms.Label updateLastNameLabel;
        private System.Windows.Forms.Label updatePhoneLabel;
        private System.Windows.Forms.Label updateAddressLabel;
        private System.Windows.Forms.TextBox updateFirstNameTxt;
        private System.Windows.Forms.TextBox updateLastNameTxt;
        private System.Windows.Forms.TextBox updatePhoneTxt;
        private System.Windows.Forms.TextBox updateAddressTxt;
    }
}