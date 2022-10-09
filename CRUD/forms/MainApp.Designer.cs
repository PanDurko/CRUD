namespace CRUD
{
    partial class MainApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IdTb = new System.Windows.Forms.TextBox();
            this.fNameTb = new System.Windows.Forms.TextBox();
            this.lNameTb = new System.Windows.Forms.TextBox();
            this.IdText = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.ReadButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdTb
            // 
            this.IdTb.Location = new System.Drawing.Point(108, 14);
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(165, 23);
            this.IdTb.TabIndex = 0;
            // 
            // fNameTb
            // 
            this.fNameTb.Location = new System.Drawing.Point(108, 58);
            this.fNameTb.Name = "fNameTb";
            this.fNameTb.Size = new System.Drawing.Size(165, 23);
            this.fNameTb.TabIndex = 1;
            // 
            // lNameTb
            // 
            this.lNameTb.Location = new System.Drawing.Point(108, 101);
            this.lNameTb.Name = "lNameTb";
            this.lNameTb.Size = new System.Drawing.Size(165, 23);
            this.lNameTb.TabIndex = 2;
            // 
            // IdText
            // 
            this.IdText.AutoSize = true;
            this.IdText.Location = new System.Drawing.Point(25, 22);
            this.IdText.Name = "IdText";
            this.IdText.Size = new System.Drawing.Size(43, 15);
            this.IdText.TabIndex = 4;
            this.IdText.Text = "User Id";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(25, 61);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(64, 15);
            this.FirstNameLabel.TabIndex = 5;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(25, 104);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(63, 15);
            this.LastNameLabel.TabIndex = 6;
            this.LastNameLabel.Text = "Last Name";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(23, 159);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(77, 53);
            this.CreateButton.TabIndex = 7;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(106, 159);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(77, 53);
            this.ReadButton.TabIndex = 8;
            this.ReadButton.Text = "Read";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(189, 159);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(77, 53);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(272, 159);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(77, 53);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 226);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.IdText);
            this.Controls.Add(this.lNameTb);
            this.Controls.Add(this.fNameTb);
            this.Controls.Add(this.IdTb);
            this.Name = "MainApp";
            this.Text = "CRUD ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox IdTb;
        private TextBox fNameTb;
        private TextBox lNameTb;
        private Label IdText;
        private Label FirstNameLabel;
        private Label LastNameLabel;
        private Button CreateButton;
        private Button ReadButton;
        private Button UpdateButton;
        private Button DeleteButton;
    }
}