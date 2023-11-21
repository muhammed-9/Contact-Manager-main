
namespace ContactManagerMaster2022
{
    partial class Start
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
            this.CmdSearch = new System.Windows.Forms.Button();
            this.Suchen = new System.Windows.Forms.GroupBox();
            this.CmdCsvImport = new System.Windows.Forms.Button();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.cbTrainee = new System.Windows.Forms.CheckBox();
            this.cbEmployee = new System.Windows.Forms.CheckBox();
            this.cbCustComp = new System.Windows.Forms.CheckBox();
            this.cbCustPriv = new System.Windows.Forms.CheckBox();
            this.DropdFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmdNewPerson = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DataSearchResults = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumLineLoadCount = new System.Windows.Forms.NumericUpDown();
            this.CmdLogout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrivatCustomer = new System.Windows.Forms.Label();
            this.lblBusinessCustomer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTrainee = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblInactive = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Suchen.SuspendLayout();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSearchResults)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLineLoadCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdSearch
            // 
            this.CmdSearch.Location = new System.Drawing.Point(12, 295);
            this.CmdSearch.Margin = new System.Windows.Forms.Padding(4);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(203, 36);
            this.CmdSearch.TabIndex = 20;
            this.CmdSearch.Text = "Suchen";
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // Suchen
            // 
            this.Suchen.Controls.Add(this.CmdCsvImport);
            this.Suchen.Controls.Add(this.grpFilter);
            this.Suchen.Controls.Add(this.label2);
            this.Suchen.Controls.Add(this.CmdNewPerson);
            this.Suchen.Controls.Add(this.TxtSearch);
            this.Suchen.Controls.Add(this.CmdSearch);
            this.Suchen.Location = new System.Drawing.Point(14, 14);
            this.Suchen.Margin = new System.Windows.Forms.Padding(4);
            this.Suchen.Name = "Suchen";
            this.Suchen.Padding = new System.Windows.Forms.Padding(4);
            this.Suchen.Size = new System.Drawing.Size(477, 360);
            this.Suchen.TabIndex = 1;
            this.Suchen.TabStop = false;
            // 
            // CmdCsvImport
            // 
            this.CmdCsvImport.Location = new System.Drawing.Point(258, 30);
            this.CmdCsvImport.Margin = new System.Windows.Forms.Padding(2);
            this.CmdCsvImport.Name = "CmdCsvImport";
            this.CmdCsvImport.Size = new System.Drawing.Size(202, 60);
            this.CmdCsvImport.TabIndex = 1000;
            this.CmdCsvImport.Text = "CSV Import";
            this.CmdCsvImport.UseVisualStyleBackColor = true;
            this.CmdCsvImport.Click += new System.EventHandler(this.CmdCsvImport_Click);
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.cbTrainee);
            this.grpFilter.Controls.Add(this.cbEmployee);
            this.grpFilter.Controls.Add(this.cbCustComp);
            this.grpFilter.Controls.Add(this.cbCustPriv);
            this.grpFilter.Controls.Add(this.DropdFilter);
            this.grpFilter.Location = new System.Drawing.Point(257, 191);
            this.grpFilter.Margin = new System.Windows.Forms.Padding(4);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Padding = new System.Windows.Forms.Padding(4);
            this.grpFilter.Size = new System.Drawing.Size(203, 154);
            this.grpFilter.TabIndex = 98;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter";
            // 
            // cbTrainee
            // 
            this.cbTrainee.AutoSize = true;
            this.cbTrainee.Location = new System.Drawing.Point(27, 94);
            this.cbTrainee.Margin = new System.Windows.Forms.Padding(2);
            this.cbTrainee.Name = "cbTrainee";
            this.cbTrainee.Size = new System.Drawing.Size(113, 19);
            this.cbTrainee.TabIndex = 70;
            this.cbTrainee.Text = "Auszubildende*r";
            this.cbTrainee.UseVisualStyleBackColor = true;
            this.cbTrainee.CheckedChanged += new System.EventHandler(this.ReloadData_Event);
            // 
            // cbEmployee
            // 
            this.cbEmployee.AutoSize = true;
            this.cbEmployee.Location = new System.Drawing.Point(27, 71);
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(99, 19);
            this.cbEmployee.TabIndex = 60;
            this.cbEmployee.Text = "Mitarbeiter*in";
            this.cbEmployee.UseVisualStyleBackColor = true;
            this.cbEmployee.CheckedChanged += new System.EventHandler(this.ReloadData_Event);
            // 
            // cbCustComp
            // 
            this.cbCustComp.AutoSize = true;
            this.cbCustComp.Location = new System.Drawing.Point(27, 51);
            this.cbCustComp.Margin = new System.Windows.Forms.Padding(2);
            this.cbCustComp.Name = "cbCustComp";
            this.cbCustComp.Size = new System.Drawing.Size(105, 19);
            this.cbCustComp.TabIndex = 50;
            this.cbCustComp.Text = "Firmenkund*in";
            this.cbCustComp.UseVisualStyleBackColor = true;
            this.cbCustComp.CheckedChanged += new System.EventHandler(this.ReloadData_Event);
            // 
            // cbCustPriv
            // 
            this.cbCustPriv.AutoSize = true;
            this.cbCustPriv.Location = new System.Drawing.Point(27, 30);
            this.cbCustPriv.Margin = new System.Windows.Forms.Padding(2);
            this.cbCustPriv.Name = "cbCustPriv";
            this.cbCustPriv.Size = new System.Drawing.Size(98, 19);
            this.cbCustPriv.TabIndex = 40;
            this.cbCustPriv.Text = "Privatkund*in";
            this.cbCustPriv.UseVisualStyleBackColor = true;
            this.cbCustPriv.CheckedChanged += new System.EventHandler(this.ReloadData_Event);
            // 
            // DropdFilter
            // 
            this.DropdFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropdFilter.FormattingEnabled = true;
            this.DropdFilter.Location = new System.Drawing.Point(27, 115);
            this.DropdFilter.Margin = new System.Windows.Forms.Padding(4);
            this.DropdFilter.Name = "DropdFilter";
            this.DropdFilter.Size = new System.Drawing.Size(140, 23);
            this.DropdFilter.TabIndex = 80;
            this.DropdFilter.SelectedIndexChanged += new System.EventHandler(this.ReloadData_Event);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Suchbegriff";
            // 
            // CmdNewPerson
            // 
            this.CmdNewPerson.Location = new System.Drawing.Point(12, 30);
            this.CmdNewPerson.Margin = new System.Windows.Forms.Padding(4);
            this.CmdNewPerson.Name = "CmdNewPerson";
            this.CmdNewPerson.Size = new System.Drawing.Size(202, 60);
            this.CmdNewPerson.TabIndex = 30;
            this.CmdNewPerson.Text = "Neue Person hinzufügen";
            this.CmdNewPerson.UseVisualStyleBackColor = true;
            this.CmdNewPerson.Click += new System.EventHandler(this.BtnNeuerKunde_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(12, 261);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(202, 23);
            this.TxtSearch.TabIndex = 10;
            this.TxtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearch_KeyPress);
            // 
            // DataSearchResults
            // 
            this.DataSearchResults.AllowUserToAddRows = false;
            this.DataSearchResults.AllowUserToDeleteRows = false;
            this.DataSearchResults.AllowUserToResizeRows = false;
            this.DataSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSearchResults.Location = new System.Drawing.Point(7, 22);
            this.DataSearchResults.Margin = new System.Windows.Forms.Padding(4);
            this.DataSearchResults.MultiSelect = false;
            this.DataSearchResults.Name = "DataSearchResults";
            this.DataSearchResults.RowHeadersVisible = false;
            this.DataSearchResults.RowHeadersWidth = 82;
            this.DataSearchResults.Size = new System.Drawing.Size(1141, 239);
            this.DataSearchResults.TabIndex = 11;
            this.DataSearchResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataSearchResults_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataSearchResults);
            this.groupBox2.Location = new System.Drawing.Point(14, 424);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1155, 268);
            this.groupBox2.TabIndex = 999;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Suchresultate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 398);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Anzahl Suchresultate:";
            // 
            // NumLineLoadCount
            // 
            this.NumLineLoadCount.Location = new System.Drawing.Point(158, 397);
            this.NumLineLoadCount.Margin = new System.Windows.Forms.Padding(2);
            this.NumLineLoadCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumLineLoadCount.Name = "NumLineLoadCount";
            this.NumLineLoadCount.Size = new System.Drawing.Size(65, 23);
            this.NumLineLoadCount.TabIndex = 90;
            this.NumLineLoadCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumLineLoadCount.ValueChanged += new System.EventHandler(this.ReloadData_Event);
            // 
            // CmdLogout
            // 
            this.CmdLogout.Location = new System.Drawing.Point(1080, 14);
            this.CmdLogout.Margin = new System.Windows.Forms.Padding(2);
            this.CmdLogout.Name = "CmdLogout";
            this.CmdLogout.Size = new System.Drawing.Size(90, 26);
            this.CmdLogout.TabIndex = 100;
            this.CmdLogout.Text = "Abmelden";
            this.CmdLogout.UseVisualStyleBackColor = true;
            this.CmdLogout.Click += new System.EventHandler(this.CmdLogout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Anzahl Privat Kunden";
            // 
            // lblPrivatCustomer
            // 
            this.lblPrivatCustomer.AutoSize = true;
            this.lblPrivatCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrivatCustomer.Location = new System.Drawing.Point(576, 220);
            this.lblPrivatCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrivatCustomer.Name = "lblPrivatCustomer";
            this.lblPrivatCustomer.Size = new System.Drawing.Size(18, 20);
            this.lblPrivatCustomer.TabIndex = 19;
            this.lblPrivatCustomer.Text = "0";
            // 
            // lblBusinessCustomer
            // 
            this.lblBusinessCustomer.AutoSize = true;
            this.lblBusinessCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBusinessCustomer.Location = new System.Drawing.Point(576, 340);
            this.lblBusinessCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusinessCustomer.Name = "lblBusinessCustomer";
            this.lblBusinessCustomer.Size = new System.Drawing.Size(18, 20);
            this.lblBusinessCustomer.TabIndex = 22;
            this.lblBusinessCustomer.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(577, 321);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Anzahl Firmen Kunden";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmployee.Location = new System.Drawing.Point(833, 220);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(18, 20);
            this.lblEmployee.TabIndex = 25;
            this.lblEmployee.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(834, 202);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Anzahl Mitarbeiter";
            // 
            // lblTrainee
            // 
            this.lblTrainee.AutoSize = true;
            this.lblTrainee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTrainee.Location = new System.Drawing.Point(1048, 220);
            this.lblTrainee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrainee.Name = "lblTrainee";
            this.lblTrainee.Size = new System.Drawing.Size(18, 20);
            this.lblTrainee.TabIndex = 28;
            this.lblTrainee.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1049, 201);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Anzahl Auszubildende";
            // 
            // lblInactive
            // 
            this.lblInactive.AutoSize = true;
            this.lblInactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInactive.Location = new System.Drawing.Point(1048, 339);
            this.lblInactive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInactive.Name = "lblInactive";
            this.lblInactive.Size = new System.Drawing.Size(18, 20);
            this.lblInactive.TabIndex = 34;
            this.lblInactive.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1049, 321);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 15);
            this.label11.TabIndex = 32;
            this.label11.Text = "Inaktive Personen";
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActive.Location = new System.Drawing.Point(833, 340);
            this.lblActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(18, 20);
            this.lblActive.TabIndex = 31;
            this.lblActive.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(834, 322);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "Aktive Personen";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ContactManagerMaster2022.Properties.Resources.forbidden1;
            this.pictureBox5.Location = new System.Drawing.Point(971, 299);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 74);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 33;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ContactManagerMaster2022.Properties.Resources.active1;
            this.pictureBox6.Location = new System.Drawing.Point(756, 300);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(70, 74);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 30;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ContactManagerMaster2022.Properties.Resources.boy;
            this.pictureBox4.Location = new System.Drawing.Point(971, 180);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 74);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ContactManagerMaster2022.Properties.Resources.employee;
            this.pictureBox3.Location = new System.Drawing.Point(756, 180);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 74);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ContactManagerMaster2022.Properties.Resources.companycustomer1;
            this.pictureBox2.Location = new System.Drawing.Point(499, 300);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ContactManagerMaster2022.Properties.Resources.customer;
            this.pictureBox1.Location = new System.Drawing.Point(499, 180);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1177, 637);
            this.Controls.Add(this.lblInactive);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblTrainee);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblBusinessCustomer);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPrivatCustomer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmdLogout);
            this.Controls.Add(this.NumLineLoadCount);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Suchen);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.Suchen.ResumeLayout(false);
            this.Suchen.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSearchResults)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumLineLoadCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdSearch;
        private System.Windows.Forms.GroupBox Suchen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Button CmdNewPerson;
        private System.Windows.Forms.DataGridView DataSearchResults;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox DropdFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumLineLoadCount;
        private System.Windows.Forms.CheckBox cbTrainee;
        private System.Windows.Forms.CheckBox cbEmployee;
        private System.Windows.Forms.CheckBox cbCustComp;
        private System.Windows.Forms.CheckBox cbCustPriv;
        private System.Windows.Forms.Button CmdLogout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPrivatCustomer;
        private System.Windows.Forms.Label lblBusinessCustomer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTrainee;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblInactive;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button CmdCsvImport;
    }
}