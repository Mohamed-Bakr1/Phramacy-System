namespace From2
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Pass = new System.Windows.Forms.Label();
            this.User_Name = new System.Windows.Forms.Label();
            this.Log_in = new System.Windows.Forms.Button();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.Pass);
            this.groupBox1.Controls.Add(this.User_Name);
            this.groupBox1.Controls.Add(this.Log_in);
            this.groupBox1.Controls.Add(this.PassBox);
            this.groupBox1.Controls.Add(this.UserBox);
            this.groupBox1.Location = new System.Drawing.Point(139, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log in";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Location = new System.Drawing.Point(108, 155);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(67, 16);
            this.Pass.TabIndex = 4;
            this.Pass.Text = "Password";
            // 
            // User_Name
            // 
            this.User_Name.AutoSize = true;
            this.User_Name.Location = new System.Drawing.Point(108, 82);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(76, 16);
            this.User_Name.TabIndex = 3;
            this.User_Name.Text = "User Name";
            // 
            // Log_in
            // 
            this.Log_in.Location = new System.Drawing.Point(214, 232);
            this.Log_in.Name = "Log_in";
            this.Log_in.Size = new System.Drawing.Size(87, 30);
            this.Log_in.TabIndex = 2;
            this.Log_in.Text = "Log in";
            this.Log_in.UseVisualStyleBackColor = true;
            this.Log_in.Click += new System.EventHandler(this.Log_in_Click);
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(234, 149);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(184, 22);
            this.PassBox.TabIndex = 1;
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(234, 76);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(184, 22);
            this.UserBox.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.Label User_Name;
        private System.Windows.Forms.Button Log_in;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox UserBox;
    }
}

