
namespace GroomingSalonRegistrationApp
{
    partial class AddCustomerForm
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
            this.custFirstNameLabel = new System.Windows.Forms.Label();
            this.custLastNameLabel = new System.Windows.Forms.Label();
            this.custPhoneLabel = new System.Windows.Forms.Label();
            this.custAddressLabel = new System.Windows.Forms.Label();
            this.custFirstNameTxt = new System.Windows.Forms.TextBox();
            this.custLastNameTxt = new System.Windows.Forms.TextBox();
            this.custPhoneTxt = new System.Windows.Forms.TextBox();
            this.custAddressTxt = new System.Windows.Forms.TextBox();
            this.addCustSubmitbtn = new System.Windows.Forms.Button();
            this.addCustCancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // custFirstNameLabel
            // 
            this.custFirstNameLabel.AutoSize = true;
            this.custFirstNameLabel.Location = new System.Drawing.Point(35, 26);
            this.custFirstNameLabel.Name = "custFirstNameLabel";
            this.custFirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.custFirstNameLabel.TabIndex = 0;
            this.custFirstNameLabel.Text = "First Name";
            // 
            // custLastNameLabel
            // 
            this.custLastNameLabel.AutoSize = true;
            this.custLastNameLabel.Location = new System.Drawing.Point(35, 52);
            this.custLastNameLabel.Name = "custLastNameLabel";
            this.custLastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.custLastNameLabel.TabIndex = 1;
            this.custLastNameLabel.Text = "Last Name";
            // 
            // custPhoneLabel
            // 
            this.custPhoneLabel.AutoSize = true;
            this.custPhoneLabel.Location = new System.Drawing.Point(35, 78);
            this.custPhoneLabel.Name = "custPhoneLabel";
            this.custPhoneLabel.Size = new System.Drawing.Size(78, 13);
            this.custPhoneLabel.TabIndex = 2;
            this.custPhoneLabel.Text = "Phone Number";
            // 
            // custAddressLabel
            // 
            this.custAddressLabel.AutoSize = true;
            this.custAddressLabel.Location = new System.Drawing.Point(35, 104);
            this.custAddressLabel.Name = "custAddressLabel";
            this.custAddressLabel.Size = new System.Drawing.Size(45, 13);
            this.custAddressLabel.TabIndex = 3;
            this.custAddressLabel.Text = "Address";
            // 
            // custFirstNameTxt
            // 
            this.custFirstNameTxt.Location = new System.Drawing.Point(127, 19);
            this.custFirstNameTxt.Name = "custFirstNameTxt";
            this.custFirstNameTxt.Size = new System.Drawing.Size(232, 20);
            this.custFirstNameTxt.TabIndex = 4;
            // 
            // custLastNameTxt
            // 
            this.custLastNameTxt.Location = new System.Drawing.Point(127, 45);
            this.custLastNameTxt.Name = "custLastNameTxt";
            this.custLastNameTxt.Size = new System.Drawing.Size(232, 20);
            this.custLastNameTxt.TabIndex = 5;
            // 
            // custPhoneTxt
            // 
            this.custPhoneTxt.Location = new System.Drawing.Point(127, 71);
            this.custPhoneTxt.Name = "custPhoneTxt";
            this.custPhoneTxt.Size = new System.Drawing.Size(232, 20);
            this.custPhoneTxt.TabIndex = 6;
            // 
            // custAddressTxt
            // 
            this.custAddressTxt.Location = new System.Drawing.Point(127, 97);
            this.custAddressTxt.Name = "custAddressTxt";
            this.custAddressTxt.Size = new System.Drawing.Size(232, 20);
            this.custAddressTxt.TabIndex = 7;
            // 
            // addCustSubmitbtn
            // 
            this.addCustSubmitbtn.Location = new System.Drawing.Point(127, 135);
            this.addCustSubmitbtn.Name = "addCustSubmitbtn";
            this.addCustSubmitbtn.Size = new System.Drawing.Size(102, 34);
            this.addCustSubmitbtn.TabIndex = 8;
            this.addCustSubmitbtn.Text = "Submit";
            this.addCustSubmitbtn.UseVisualStyleBackColor = true;
            // 
            // addCustCancelbtn
            // 
            this.addCustCancelbtn.Location = new System.Drawing.Point(260, 135);
            this.addCustCancelbtn.Name = "addCustCancelbtn";
            this.addCustCancelbtn.Size = new System.Drawing.Size(99, 34);
            this.addCustCancelbtn.TabIndex = 9;
            this.addCustCancelbtn.Text = "Cancel";
            this.addCustCancelbtn.UseVisualStyleBackColor = true;
            // 
            // AddCustomerForm
            // 
            this.AcceptButton = this.addCustSubmitbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 194);
            this.Controls.Add(this.addCustCancelbtn);
            this.Controls.Add(this.addCustSubmitbtn);
            this.Controls.Add(this.custAddressTxt);
            this.Controls.Add(this.custPhoneTxt);
            this.Controls.Add(this.custLastNameTxt);
            this.Controls.Add(this.custFirstNameTxt);
            this.Controls.Add(this.custAddressLabel);
            this.Controls.Add(this.custPhoneLabel);
            this.Controls.Add(this.custLastNameLabel);
            this.Controls.Add(this.custFirstNameLabel);
            this.Name = "AddCustomerForm";
            this.Text = "Add Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label custFirstNameLabel;
        private System.Windows.Forms.Label custLastNameLabel;
        private System.Windows.Forms.Label custPhoneLabel;
        private System.Windows.Forms.Label custAddressLabel;
        private System.Windows.Forms.TextBox custFirstNameTxt;
        private System.Windows.Forms.TextBox custLastNameTxt;
        private System.Windows.Forms.TextBox custPhoneTxt;
        private System.Windows.Forms.TextBox custAddressTxt;
        private System.Windows.Forms.Button addCustSubmitbtn;
        private System.Windows.Forms.Button addCustCancelbtn;
    }
}