namespace ContactManagerMaster2022
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param firstName="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPasswort = new System.Windows.Forms.TextBox();
            this.CmdLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblLoginWrong = new System.Windows.Forms.Label();
            this.LblSymbolPasswort = new System.Windows.Forms.Label();
            this.LblSymbolBenutzer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtUsername
            // 
            this.TxtUsername.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtUsername.Location = new System.Drawing.Point(30, 140);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TxtUsername.Multiline = true;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(528, 34);
            this.TxtUsername.TabIndex = 0;
            // 
            // TxtPasswort
            // 
            this.TxtPasswort.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPasswort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtPasswort.Location = new System.Drawing.Point(30, 203);
            this.TxtPasswort.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TxtPasswort.Multiline = true;
            this.TxtPasswort.Name = "TxtPasswort";
            this.TxtPasswort.Size = new System.Drawing.Size(528, 34);
            this.TxtPasswort.TabIndex = 1;
            this.TxtPasswort.Enter += new System.EventHandler(this.TxtPasswort_Insert);
            this.TxtPasswort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPasswort_KeyPress);
            // 
            // CmdLogin
            // 
            this.CmdLogin.Location = new System.Drawing.Point(421, 248);
            this.CmdLogin.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.CmdLogin.Name = "CmdLogin";
            this.CmdLogin.Size = new System.Drawing.Size(135, 29);
            this.CmdLogin.TabIndex = 2;
            this.CmdLogin.Text = "Anmeldung";
            this.CmdLogin.UseVisualStyleBackColor = true;
            this.CmdLogin.Click += new System.EventHandler(this.CmdLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Anmeldung Contact Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Benutzername";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Passwort";
            // 
            // LblLoginWrong
            // 
            this.LblLoginWrong.AutoSize = true;
            this.LblLoginWrong.BackColor = System.Drawing.Color.MistyRose;
            this.LblLoginWrong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblLoginWrong.ForeColor = System.Drawing.Color.Red;
            this.LblLoginWrong.Location = new System.Drawing.Point(30, 77);
            this.LblLoginWrong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLoginWrong.Name = "LblLoginWrong";
            this.LblLoginWrong.Size = new System.Drawing.Size(0, 15);
            this.LblLoginWrong.TabIndex = 6;
            // 
            // LblSymbolPasswort
            // 
            this.LblSymbolPasswort.AutoSize = true;
            this.LblSymbolPasswort.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblSymbolPasswort.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblSymbolPasswort.ForeColor = System.Drawing.Color.Red;
            this.LblSymbolPasswort.Location = new System.Drawing.Point(506, 210);
            this.LblSymbolPasswort.Name = "LblSymbolPasswort";
            this.LblSymbolPasswort.Size = new System.Drawing.Size(0, 20);
            this.LblSymbolPasswort.TabIndex = 7;
            // 
            // LblSymbolBenutzer
            // 
            this.LblSymbolBenutzer.AutoSize = true;
            this.LblSymbolBenutzer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblSymbolBenutzer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblSymbolBenutzer.ForeColor = System.Drawing.Color.Red;
            this.LblSymbolBenutzer.Location = new System.Drawing.Point(506, 146);
            this.LblSymbolBenutzer.Name = "LblSymbolBenutzer";
            this.LblSymbolBenutzer.Size = new System.Drawing.Size(0, 20);
            this.LblSymbolBenutzer.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(573, 338);
            this.Controls.Add(this.LblSymbolPasswort);
            this.Controls.Add(this.LblSymbolBenutzer);
            this.Controls.Add(this.LblLoginWrong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdLogin);
            this.Controls.Add(this.TxtPasswort);
            this.Controls.Add(this.TxtUsername);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPasswort;
        private System.Windows.Forms.Button CmdLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label LblLoginWrong;
        private Label LblSymbolPasswort;
        private Label LblSymbolBenutzer;
    }
}