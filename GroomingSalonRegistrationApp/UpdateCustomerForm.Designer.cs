
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
            this.SuspendLayout();
            // 
            // updateCustSubmitBtn
            // 
            this.updateCustSubmitBtn.Location = new System.Drawing.Point(270, 158);
            this.updateCustSubmitBtn.Name = "updateCustSubmitBtn";
            this.updateCustSubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.updateCustSubmitBtn.TabIndex = 0;
            this.updateCustSubmitBtn.Text = "Submit";
            this.updateCustSubmitBtn.UseVisualStyleBackColor = true;
            // 
            // updateCustCancelBtn
            // 
            this.updateCustCancelBtn.Location = new System.Drawing.Point(374, 158);
            this.updateCustCancelBtn.Name = "updateCustCancelBtn";
            this.updateCustCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.updateCustCancelBtn.TabIndex = 1;
            this.updateCustCancelBtn.Text = "Cancel";
            this.updateCustCancelBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 216);
            this.Controls.Add(this.updateCustCancelBtn);
            this.Controls.Add(this.updateCustSubmitBtn);
            this.Name = "UpdateCustomerForm";
            this.Text = "Update Customer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateCustSubmitBtn;
        private System.Windows.Forms.Button updateCustCancelBtn;
    }
}