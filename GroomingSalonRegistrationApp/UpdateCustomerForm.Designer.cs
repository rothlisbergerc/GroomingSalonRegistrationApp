
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(253, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(136, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(253, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(136, 101);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(253, 20);
            this.textBox4.TabIndex = 9;
            // 
            // UpdateCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 201);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}