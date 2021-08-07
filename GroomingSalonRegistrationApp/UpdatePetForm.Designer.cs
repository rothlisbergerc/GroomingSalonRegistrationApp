
namespace GroomingSalonRegistrationApp
{
    partial class UpdatePetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePetForm));
            this.updatePetSubmitBtn = new System.Windows.Forms.Button();
            this.updatePetCancelBtn = new System.Windows.Forms.Button();
            this.updatePetNameLabel = new System.Windows.Forms.Label();
            this.updatePetBreedLabel = new System.Windows.Forms.Label();
            this.updatePetAgeLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // updatePetSubmitBtn
            // 
            this.updatePetSubmitBtn.Location = new System.Drawing.Point(117, 112);
            this.updatePetSubmitBtn.Name = "updatePetSubmitBtn";
            this.updatePetSubmitBtn.Size = new System.Drawing.Size(105, 38);
            this.updatePetSubmitBtn.TabIndex = 0;
            this.updatePetSubmitBtn.Text = "Submit";
            this.updatePetSubmitBtn.UseVisualStyleBackColor = true;
            // 
            // updatePetCancelBtn
            // 
            this.updatePetCancelBtn.Location = new System.Drawing.Point(260, 112);
            this.updatePetCancelBtn.Name = "updatePetCancelBtn";
            this.updatePetCancelBtn.Size = new System.Drawing.Size(105, 38);
            this.updatePetCancelBtn.TabIndex = 1;
            this.updatePetCancelBtn.Text = "Cancel";
            this.updatePetCancelBtn.UseVisualStyleBackColor = true;
            // 
            // updatePetNameLabel
            // 
            this.updatePetNameLabel.AutoSize = true;
            this.updatePetNameLabel.Location = new System.Drawing.Point(38, 25);
            this.updatePetNameLabel.Name = "updatePetNameLabel";
            this.updatePetNameLabel.Size = new System.Drawing.Size(35, 13);
            this.updatePetNameLabel.TabIndex = 2;
            this.updatePetNameLabel.Text = "Name";
            // 
            // updatePetBreedLabel
            // 
            this.updatePetBreedLabel.AutoSize = true;
            this.updatePetBreedLabel.Location = new System.Drawing.Point(38, 51);
            this.updatePetBreedLabel.Name = "updatePetBreedLabel";
            this.updatePetBreedLabel.Size = new System.Drawing.Size(35, 13);
            this.updatePetBreedLabel.TabIndex = 3;
            this.updatePetBreedLabel.Text = "Breed";
            // 
            // updatePetAgeLabel
            // 
            this.updatePetAgeLabel.AutoSize = true;
            this.updatePetAgeLabel.Location = new System.Drawing.Point(38, 77);
            this.updatePetAgeLabel.Name = "updatePetAgeLabel";
            this.updatePetAgeLabel.Size = new System.Drawing.Size(26, 13);
            this.updatePetAgeLabel.TabIndex = 4;
            this.updatePetAgeLabel.Text = "Age";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(248, 20);
            this.textBox3.TabIndex = 8;
            // 
            // UpdatePetForm
            // 
            this.AcceptButton = this.updatePetSubmitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(411, 182);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.updatePetAgeLabel);
            this.Controls.Add(this.updatePetBreedLabel);
            this.Controls.Add(this.updatePetNameLabel);
            this.Controls.Add(this.updatePetCancelBtn);
            this.Controls.Add(this.updatePetSubmitBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdatePetForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Pet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updatePetSubmitBtn;
        private System.Windows.Forms.Button updatePetCancelBtn;
        private System.Windows.Forms.Label updatePetNameLabel;
        private System.Windows.Forms.Label updatePetBreedLabel;
        private System.Windows.Forms.Label updatePetAgeLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}