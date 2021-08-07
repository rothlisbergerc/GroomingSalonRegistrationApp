
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomerForm));
            this.custFirstNameLabel = new System.Windows.Forms.Label();
            this.custLastNameLabel = new System.Windows.Forms.Label();
            this.custPhoneLabel = new System.Windows.Forms.Label();
            this.custAddressLabel = new System.Windows.Forms.Label();
            this.custFirstNameTxt = new System.Windows.Forms.TextBox();
            this.custLastNameTxt = new System.Windows.Forms.TextBox();
            this.custPhoneTxt = new System.Windows.Forms.TextBox();
            this.custAddressTxt = new System.Windows.Forms.TextBox();
            this.addCustSubmitBtn = new System.Windows.Forms.Button();
            this.addCustCancelBtn = new System.Windows.Forms.Button();
            this.errorAddCustTxt = new System.Windows.Forms.TextBox();
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
            // addCustSubmitBtn
            // 
            this.addCustSubmitBtn.Location = new System.Drawing.Point(127, 171);
            this.addCustSubmitBtn.Name = "addCustSubmitBtn";
            this.addCustSubmitBtn.Size = new System.Drawing.Size(102, 34);
            this.addCustSubmitBtn.TabIndex = 8;
            this.addCustSubmitBtn.Text = "Submit";
            this.addCustSubmitBtn.UseVisualStyleBackColor = true;
            this.addCustSubmitBtn.Click += new System.EventHandler(this.addCustSubmitBtn_Click);
            // 
            // addCustCancelBtn
            // 
            this.addCustCancelBtn.Location = new System.Drawing.Point(260, 171);
            this.addCustCancelBtn.Name = "addCustCancelBtn";
            this.addCustCancelBtn.Size = new System.Drawing.Size(99, 34);
            this.addCustCancelBtn.TabIndex = 9;
            this.addCustCancelBtn.Text = "Cancel";
            this.addCustCancelBtn.UseVisualStyleBackColor = true;
            this.addCustCancelBtn.Click += new System.EventHandler(this.addCustCancelBtn_Click);
            // 
            // errorAddCustTxt
            // 
            this.errorAddCustTxt.Location = new System.Drawing.Point(127, 145);
            this.errorAddCustTxt.Name = "errorAddCustTxt";
            this.errorAddCustTxt.Size = new System.Drawing.Size(232, 20);
            this.errorAddCustTxt.TabIndex = 10;
            // 
            // AddCustomerForm
            // 
            this.AcceptButton = this.addCustSubmitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(408, 248);
            this.Controls.Add(this.errorAddCustTxt);
            this.Controls.Add(this.addCustCancelBtn);
            this.Controls.Add(this.addCustSubmitBtn);
            this.Controls.Add(this.custAddressTxt);
            this.Controls.Add(this.custPhoneTxt);
            this.Controls.Add(this.custLastNameTxt);
            this.Controls.Add(this.custFirstNameTxt);
            this.Controls.Add(this.custAddressLabel);
            this.Controls.Add(this.custPhoneLabel);
            this.Controls.Add(this.custLastNameLabel);
            this.Controls.Add(this.custFirstNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCustomerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button addCustSubmitBtn;
        private System.Windows.Forms.Button addCustCancelBtn;
        private System.Windows.Forms.TextBox errorAddCustTxt;
    }
}