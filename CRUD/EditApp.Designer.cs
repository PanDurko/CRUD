namespace CRUD
{
    partial class EditApp
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
            this.targetIdTb = new System.Windows.Forms.TextBox();
            this.newIdTb = new System.Windows.Forms.TextBox();
            this.newFirstNameTb = new System.Windows.Forms.TextBox();
            this.newLastNameTb = new System.Windows.Forms.TextBox();
            this.targetIdLabel = new System.Windows.Forms.Label();
            this.newIdLabel = new System.Windows.Forms.Label();
            this.newFirstNameLabel = new System.Windows.Forms.Label();
            this.newLastNameLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // targetIdTb
            // 
            this.targetIdTb.Location = new System.Drawing.Point(109, 33);
            this.targetIdTb.Name = "targetIdTb";
            this.targetIdTb.Size = new System.Drawing.Size(122, 23);
            this.targetIdTb.TabIndex = 0;
            // 
            // newIdTb
            // 
            this.newIdTb.Location = new System.Drawing.Point(109, 62);
            this.newIdTb.Name = "newIdTb";
            this.newIdTb.Size = new System.Drawing.Size(122, 23);
            this.newIdTb.TabIndex = 1;
            // 
            // newFirstNameTb
            // 
            this.newFirstNameTb.Location = new System.Drawing.Point(109, 91);
            this.newFirstNameTb.Name = "newFirstNameTb";
            this.newFirstNameTb.Size = new System.Drawing.Size(122, 23);
            this.newFirstNameTb.TabIndex = 2;
            // 
            // newLastNameTb
            // 
            this.newLastNameTb.Location = new System.Drawing.Point(109, 120);
            this.newLastNameTb.Name = "newLastNameTb";
            this.newLastNameTb.Size = new System.Drawing.Size(122, 23);
            this.newLastNameTb.TabIndex = 3;
            // 
            // targetIdLabel
            // 
            this.targetIdLabel.AutoSize = true;
            this.targetIdLabel.Location = new System.Drawing.Point(12, 36);
            this.targetIdLabel.Name = "targetIdLabel";
            this.targetIdLabel.Size = new System.Drawing.Size(48, 15);
            this.targetIdLabel.TabIndex = 4;
            this.targetIdLabel.Text = "Taget Id";
            // 
            // newIdLabel
            // 
            this.newIdLabel.AutoSize = true;
            this.newIdLabel.Location = new System.Drawing.Point(12, 65);
            this.newIdLabel.Name = "newIdLabel";
            this.newIdLabel.Size = new System.Drawing.Size(44, 15);
            this.newIdLabel.TabIndex = 5;
            this.newIdLabel.Text = "New Id";
            // 
            // newFirstNameLabel
            // 
            this.newFirstNameLabel.AutoSize = true;
            this.newFirstNameLabel.Location = new System.Drawing.Point(12, 94);
            this.newFirstNameLabel.Name = "newFirstNameLabel";
            this.newFirstNameLabel.Size = new System.Drawing.Size(91, 15);
            this.newFirstNameLabel.TabIndex = 6;
            this.newFirstNameLabel.Text = "New First Name";
            // 
            // newLastNameLabel
            // 
            this.newLastNameLabel.AutoSize = true;
            this.newLastNameLabel.Location = new System.Drawing.Point(12, 123);
            this.newLastNameLabel.Name = "newLastNameLabel";
            this.newLastNameLabel.Size = new System.Drawing.Size(90, 15);
            this.newLastNameLabel.TabIndex = 7;
            this.newLastNameLabel.Text = "New Last Name";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(109, 149);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(122, 42);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 203);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.newLastNameLabel);
            this.Controls.Add(this.newFirstNameLabel);
            this.Controls.Add(this.newIdLabel);
            this.Controls.Add(this.targetIdLabel);
            this.Controls.Add(this.newLastNameTb);
            this.Controls.Add(this.newFirstNameTb);
            this.Controls.Add(this.newIdTb);
            this.Controls.Add(this.targetIdTb);
            this.Name = "EditApp";
            this.Text = "EditApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox targetIdTb;
        private TextBox newIdTb;
        private TextBox newFirstNameTb;
        private TextBox newLastNameTb;
        private Label targetIdLabel;
        private Label newIdLabel;
        private Label newFirstNameLabel;
        private Label newLastNameLabel;
        private Button SaveButton;
    }
}