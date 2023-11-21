
namespace ContactManagerMaster2022
{
    partial class ContactForm
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
            this.TxtLogInput = new System.Windows.Forms.TextBox();
            this.RadPrivat = new System.Windows.Forms.RadioButton();
            this.groupType = new System.Windows.Forms.GroupBox();
            this.RadBusinessCustomer = new System.Windows.Forms.RadioButton();
            this.RadEmployee = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtLogOutput = new System.Windows.Forms.TextBox();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdEdit = new System.Windows.Forms.Button();
            this.CmdAbort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DrpdFormOfAddress = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DateBday = new System.Windows.Forms.DateTimePicker();
            this.DrpdSex = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DrpdTitle = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtMobile = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.ChkState = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtEmployeenumb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtSocialsecurity = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.DrpdNationality = new System.Windows.Forms.ComboBox();
            this.DateStartDate = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.DateLeaveDate = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.ChkTrainee = new System.Windows.Forms.CheckBox();
            this.LblApprenticeshipcurrentyear = new System.Windows.Forms.Label();
            this.LblApprenticeshipyears = new System.Windows.Forms.Label();
            this.LblCompanyname = new System.Windows.Forms.Label();
            this.TxtCompanyname = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtStreet = new System.Windows.Forms.TextBox();
            this.TxtPostcode = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.DrpdCountry = new System.Windows.Forms.ComboBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.NumMgmtLvl = new System.Windows.Forms.NumericUpDown();
            this.LblCusttype = new System.Windows.Forms.Label();
            this.DrpdCusttype = new System.Windows.Forms.ComboBox();
            this.groupAddress = new System.Windows.Forms.GroupBox();
            this.LblFax = new System.Windows.Forms.Label();
            this.TxtFax = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.groupEmployee = new System.Windows.Forms.GroupBox();
            this.CbEndDate = new System.Windows.Forms.CheckBox();
            this.DrpdFunction = new System.Windows.Forms.ComboBox();
            this.DrpdDept = new System.Windows.Forms.ComboBox();
            this.NumApprenticeshipyears = new System.Windows.Forms.NumericUpDown();
            this.NumApprenticeshipcurrentyear = new System.Windows.Forms.NumericUpDown();
            this.NumEmploymentpercent = new System.Windows.Forms.NumericUpDown();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.groupPerson = new System.Windows.Forms.GroupBox();
            this.CmdSaveAndClose = new System.Windows.Forms.Button();
            this.tabLogs = new System.Windows.Forms.TabControl();
            this.tabCustLogs = new System.Windows.Forms.TabPage();
            this.CmdSaveLog = new System.Windows.Forms.Button();
            this.tabAuditTrail = new System.Windows.Forms.TabPage();
            this.TxtAuditTrail = new System.Windows.Forms.TextBox();
            this.groupType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumMgmtLvl)).BeginInit();
            this.groupAddress.SuspendLayout();
            this.groupEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumApprenticeshipyears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumApprenticeshipcurrentyear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEmploymentpercent)).BeginInit();
            this.groupPerson.SuspendLayout();
            this.tabLogs.SuspendLayout();
            this.tabCustLogs.SuspendLayout();
            this.tabAuditTrail.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtLogInput
            // 
            this.TxtLogInput.Location = new System.Drawing.Point(4, 21);
            this.TxtLogInput.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLogInput.Name = "TxtLogInput";
            this.TxtLogInput.Size = new System.Drawing.Size(447, 23);
            this.TxtLogInput.TabIndex = 0;
            this.TxtLogInput.TabStop = false;
            this.TxtLogInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLogInput_KeyPress);
            // 
            // RadPrivat
            // 
            this.RadPrivat.AutoSize = true;
            this.RadPrivat.Location = new System.Drawing.Point(18, 38);
            this.RadPrivat.Margin = new System.Windows.Forms.Padding(4);
            this.RadPrivat.Name = "RadPrivat";
            this.RadPrivat.Size = new System.Drawing.Size(92, 19);
            this.RadPrivat.TabIndex = 1;
            this.RadPrivat.Text = "Privat Kunde";
            this.RadPrivat.UseVisualStyleBackColor = true;
            this.RadPrivat.CheckedChanged += new System.EventHandler(this.RadButtons_CheckedChanged);
            // 
            // groupType
            // 
            this.groupType.Controls.Add(this.RadBusinessCustomer);
            this.groupType.Controls.Add(this.RadEmployee);
            this.groupType.Controls.Add(this.RadPrivat);
            this.groupType.Location = new System.Drawing.Point(10, 89);
            this.groupType.Margin = new System.Windows.Forms.Padding(4);
            this.groupType.Name = "groupType";
            this.groupType.Padding = new System.Windows.Forms.Padding(4);
            this.groupType.Size = new System.Drawing.Size(154, 202);
            this.groupType.TabIndex = 9910;
            this.groupType.TabStop = false;
            this.groupType.Text = "Personen Typ *";
            // 
            // RadBusinessCustomer
            // 
            this.RadBusinessCustomer.AutoSize = true;
            this.RadBusinessCustomer.Location = new System.Drawing.Point(18, 73);
            this.RadBusinessCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.RadBusinessCustomer.Name = "RadBusinessCustomer";
            this.RadBusinessCustomer.Size = new System.Drawing.Size(99, 19);
            this.RadBusinessCustomer.TabIndex = 2;
            this.RadBusinessCustomer.Text = "Firmen Kunde";
            this.RadBusinessCustomer.UseVisualStyleBackColor = true;
            this.RadBusinessCustomer.CheckedChanged += new System.EventHandler(this.RadButtons_CheckedChanged);
            // 
            // RadEmployee
            // 
            this.RadEmployee.AutoSize = true;
            this.RadEmployee.Location = new System.Drawing.Point(18, 109);
            this.RadEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.RadEmployee.Name = "RadEmployee";
            this.RadEmployee.Size = new System.Drawing.Size(83, 19);
            this.RadEmployee.TabIndex = 3;
            this.RadEmployee.Text = "Mitarbeiter";
            this.RadEmployee.UseVisualStyleBackColor = true;
            this.RadEmployee.CheckedChanged += new System.EventHandler(this.RadButtons_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Protokoll";
            // 
            // TxtLogOutput
            // 
            this.TxtLogOutput.Location = new System.Drawing.Point(2, 51);
            this.TxtLogOutput.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLogOutput.Multiline = true;
            this.TxtLogOutput.Name = "TxtLogOutput";
            this.TxtLogOutput.ReadOnly = true;
            this.TxtLogOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtLogOutput.Size = new System.Drawing.Size(515, 192);
            this.TxtLogOutput.TabIndex = 4;
            this.TxtLogOutput.TabStop = false;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(402, 586);
            this.CmdSave.Margin = new System.Windows.Forms.Padding(4);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(122, 26);
            this.CmdSave.TabIndex = 310;
            this.CmdSave.Text = "Speichern";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdEdit
            // 
            this.CmdEdit.Location = new System.Drawing.Point(10, 586);
            this.CmdEdit.Margin = new System.Windows.Forms.Padding(4);
            this.CmdEdit.Name = "CmdEdit";
            this.CmdEdit.Size = new System.Drawing.Size(122, 26);
            this.CmdEdit.TabIndex = 320;
            this.CmdEdit.Text = "Bearbeiten";
            this.CmdEdit.UseVisualStyleBackColor = true;
            this.CmdEdit.Click += new System.EventHandler(this.CmdEdit_Click);
            // 
            // CmdAbort
            // 
            this.CmdAbort.Location = new System.Drawing.Point(140, 586);
            this.CmdAbort.Margin = new System.Windows.Forms.Padding(4);
            this.CmdAbort.Name = "CmdAbort";
            this.CmdAbort.Size = new System.Drawing.Size(122, 26);
            this.CmdAbort.TabIndex = 330;
            this.CmdAbort.Text = "Abbrechen";
            this.CmdAbort.UseVisualStyleBackColor = true;
            this.CmdAbort.Click += new System.EventHandler(this.CmdAbort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Anrede";
            // 
            // DrpdFormOfAddress
            // 
            this.DrpdFormOfAddress.BackColor = System.Drawing.SystemColors.Window;
            this.DrpdFormOfAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrpdFormOfAddress.FormattingEnabled = true;
            this.DrpdFormOfAddress.Items.AddRange(new object[] {
            "k/A",
            "Herr",
            "Frau"});
            this.DrpdFormOfAddress.Location = new System.Drawing.Point(25, 44);
            this.DrpdFormOfAddress.Margin = new System.Windows.Forms.Padding(4);
            this.DrpdFormOfAddress.Name = "DrpdFormOfAddress";
            this.DrpdFormOfAddress.Size = new System.Drawing.Size(125, 23);
            this.DrpdFormOfAddress.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Vorname *";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(25, 132);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(125, 23);
            this.TxtName.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nachname *";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(25, 176);
            this.TxtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(125, 23);
            this.TxtSurname.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Geburtsdatum *";
            // 
            // DateBday
            // 
            this.DateBday.CustomFormat = "";
            this.DateBday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateBday.Location = new System.Drawing.Point(180, 88);
            this.DateBday.Margin = new System.Windows.Forms.Padding(4);
            this.DateBday.Name = "DateBday";
            this.DateBday.Size = new System.Drawing.Size(125, 23);
            this.DateBday.TabIndex = 60;
            // 
            // DrpdSex
            // 
            this.DrpdSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrpdSex.FormattingEnabled = true;
            this.DrpdSex.Items.AddRange(new object[] {
            "m",
            "w",
            "d"});
            this.DrpdSex.Location = new System.Drawing.Point(25, 220);
            this.DrpdSex.Margin = new System.Windows.Forms.Padding(4);
            this.DrpdSex.Name = "DrpdSex";
            this.DrpdSex.Size = new System.Drawing.Size(125, 23);
            this.DrpdSex.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 205);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Geschlecht";
            // 
            // DrpdTitle
            // 
            this.DrpdTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrpdTitle.FormattingEnabled = true;
            this.DrpdTitle.Items.AddRange(new object[] {
            "k/A",
            "Prof. Dr.",
            "Prof.",
            "Dr."});
            this.DrpdTitle.Location = new System.Drawing.Point(25, 88);
            this.DrpdTitle.Margin = new System.Windows.Forms.Padding(4);
            this.DrpdTitle.Name = "DrpdTitle";
            this.DrpdTitle.Size = new System.Drawing.Size(125, 23);
            this.DrpdTitle.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Titel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 161);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Telefonnummer";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(180, 176);
            this.TxtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(125, 23);
            this.TxtPhone.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(181, 205);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "Mobilnummer";
            // 
            // TxtMobile
            // 
            this.TxtMobile.Location = new System.Drawing.Point(180, 220);
            this.TxtMobile.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMobile.Name = "TxtMobile";
            this.TxtMobile.Size = new System.Drawing.Size(125, 23);
            this.TxtMobile.TabIndex = 70;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(180, 44);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(125, 23);
            this.TxtEmail.TabIndex = 90;
            // 
            // ChkState
            // 
            this.ChkState.AutoSize = true;
            this.ChkState.Checked = true;
            this.ChkState.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkState.Location = new System.Drawing.Point(15, 36);
            this.ChkState.Margin = new System.Windows.Forms.Padding(4);
            this.ChkState.Name = "ChkState";
            this.ChkState.Size = new System.Drawing.Size(96, 19);
            this.ChkState.TabIndex = 299;
            this.ChkState.TabStop = false;
            this.ChkState.Text = "Status (Aktiv)";
            this.ChkState.UseVisualStyleBackColor = true;
            this.ChkState.CheckedChanged += new System.EventHandler(this.ChkState_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(165, 55);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 15);
            this.label13.TabIndex = 34;
            this.label13.Text = "Mitarbeiternummer";
            // 
            // TxtEmployeenumb
            // 
            this.TxtEmployeenumb.Location = new System.Drawing.Point(169, 70);
            this.TxtEmployeenumb.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEmployeenumb.Name = "TxtEmployeenumb";
            this.TxtEmployeenumb.Size = new System.Drawing.Size(176, 23);
            this.TxtEmployeenumb.TabIndex = 190;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 55);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 15);
            this.label14.TabIndex = 36;
            this.label14.Text = "Abteilung *";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(165, 98);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 15);
            this.label15.TabIndex = 38;
            this.label15.Text = "AHV Nummer *";
            // 
            // TxtSocialsecurity
            // 
            this.TxtSocialsecurity.Location = new System.Drawing.Point(169, 114);
            this.TxtSocialsecurity.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSocialsecurity.Name = "TxtSocialsecurity";
            this.TxtSocialsecurity.Size = new System.Drawing.Size(176, 23);
            this.TxtSocialsecurity.TabIndex = 220;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(178, 117);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 15);
            this.label18.TabIndex = 46;
            this.label18.Text = "Nationalität";
            // 
            // DrpdNationality
            // 
            this.DrpdNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrpdNationality.FormattingEnabled = true;
            this.DrpdNationality.Items.AddRange(new object[] {
            "k/A",
            "Afghanistan",
            "Ägypten",
            "Albanien",
            "Algerien",
            "Andorra",
            "Angola",
            "Antigua und Barbuda",
            "Äquatorialguinea",
            "Argentinien",
            "Armenien",
            "Aserbaidschan",
            "Äthiopien",
            "Australien",
            "Bahamas",
            "Bahrain",
            "Bangladesch",
            "Barbados",
            "Belgien",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivien",
            "Bosnien und Herzegowina",
            "Botsuana",
            "Brasilien",
            "Brunei",
            "Bulgarien",
            "Burkina Faso",
            "Burundi",
            "Chile",
            "China",
            "Costa Rica",
            "Dänemark",
            "Demokratische Republik Kongo",
            "Deutschland",
            "Dominica",
            "Dominikanische Republik",
            "Dschibuti",
            "Ecuador",
            "El Salvador",
            "Elfenbeinküste",
            "England",
            "Eritrea",
            "Estland",
            "Färöer-Inseln",
            "Fidschi",
            "Finnland",
            "Frankreich",
            "Gabun",
            "Gambia",
            "Georgien",
            "Ghana",
            "Grenada",
            "Griechenland",
            "Grönland",
            "Großbritannien",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hongkong",
            "Indien",
            "Indonesien",
            "Irak",
            "Iran",
            "Irland",
            "Island",
            "Israel",
            "Italien",
            "Jamaika",
            "Japan",
            "Jemen",
            "Jordanien",
            "Kambodscha",
            "Kamerun",
            "Kanada",
            "Kap Verde",
            "Kasachstan",
            "Katar",
            "Kenia",
            "Kirgisistan",
            "Kiribati",
            "Kolumbien",
            "Komoren",
            "Kongo",
            "Kosovo",
            "Kroatien",
            "Kuba",
            "Kuwait",
            "Laos",
            "Lesotho",
            "Lettland",
            "Libanon",
            "Liberia",
            "Libyen",
            "Liechtenstein",
            "Litauen",
            "Luxemburg",
            "Macau",
            "Madagaskar",
            "Malawi",
            "Malaysia",
            "Malediven",
            "Mali",
            "Malta",
            "Marokko",
            "Marshallinseln",
            "Mauretanien",
            "Mauritius",
            "Mazedonien",
            "Mexiko",
            "Mikronesien",
            "Moldau",
            "Monaco",
            "Mongolei",
            "Montenegro",
            "Mosambik",
            "Myanmar",
            "Namibia",
            "Nauru",
            "Nepal",
            "Neuseeland",
            "Nicaragua",
            "Niederlande",
            "Niger",
            "Nigeria",
            "Nordkorea",
            "Norwegen",
            "Oman",
            "Österreich",
            "Pakistan",
            "Palästina",
            "Palau",
            "Panama",
            "Papua-Neuguinea",
            "Paraguay",
            "Peru",
            "Philippinen",
            "Polen",
            "Portugal",
            "Puerto Rico",
            "Republik Kongo",
            "(auch: Kongo-Brazzaville)",
            "Ruanda",
            "Rumänien",
            "Russland",
            "Salomonen",
            "Sambia",
            "Samoa",
            "San Marino",
            "Saudi-Arabien",
            "Schottland",
            "Schweden",
            "Schweiz",
            "Senegal",
            "Serbien",
            "Seychellen",
            "Sierra Leone",
            "Simbabwe",
            "Singapur",
            "Slowakei",
            "Slowenien",
            "Somalia",
            "Spanien",
            "Sri Lanka",
            "St. Kitts und Nevis",
            "St. Lucia",
            "St. Vincent und die Grenadinen",
            "Südafrika",
            "Sudan",
            "Südkorea",
            "Suriname",
            "Swasiland",
            "Syrien",
            "São Tomé und Príncipe",
            "Tadschikistan",
            "Taiwan",
            "Tansania",
            "Thailand",
            "Tibet",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad und Tobago",
            "Tschad",
            "Tschechische Republik",
            "Tunesien",
            "Türkei",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "Ungarn",
            "Uruguay",
            "USA",
            "Usbekistan",
            "Vanuatu",
            "Vatikanstadt",
            "Venezuela",
            "Vereinigte Arabische Emirate",
            "Vietnam",
            "Wales",
            "Weißrussland",
            "Zentralafrikanische Republik",
            "Zypern"});
            this.DrpdNationality.Location = new System.Drawing.Point(180, 132);
            this.DrpdNationality.Margin = new System.Windows.Forms.Padding(4);
            this.DrpdNationality.Name = "DrpdNationality";
            this.DrpdNationality.Size = new System.Drawing.Size(125, 23);
            this.DrpdNationality.TabIndex = 100;
            // 
            // DateStartDate
            // 
            this.DateStartDate.Checked = false;
            this.DateStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateStartDate.Location = new System.Drawing.Point(389, 70);
            this.DateStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.DateStartDate.Name = "DateStartDate";
            this.DateStartDate.Size = new System.Drawing.Size(116, 23);
            this.DateStartDate.TabIndex = 200;
            this.DateStartDate.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(385, 53);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 15);
            this.label19.TabIndex = 48;
            this.label19.Text = "Startdatum Job *";
            // 
            // DateLeaveDate
            // 
            this.DateLeaveDate.Checked = false;
            this.DateLeaveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateLeaveDate.Location = new System.Drawing.Point(389, 140);
            this.DateLeaveDate.Margin = new System.Windows.Forms.Padding(4);
            this.DateLeaveDate.Name = "DateLeaveDate";
            this.DateLeaveDate.Size = new System.Drawing.Size(116, 23);
            this.DateLeaveDate.TabIndex = 230;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(385, 122);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 15);
            this.label20.TabIndex = 50;
            this.label20.Text = "Enddatum Job";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 152);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 15);
            this.label21.TabIndex = 53;
            this.label21.Text = "Beschäftigungsgrad *";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 98);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(62, 15);
            this.label22.TabIndex = 55;
            this.label22.Text = "Funktion *";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(165, 148);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 15);
            this.label23.TabIndex = 57;
            this.label23.Text = "Kaderstufe *";
            // 
            // ChkTrainee
            // 
            this.ChkTrainee.AutoSize = true;
            this.ChkTrainee.Location = new System.Drawing.Point(24, 230);
            this.ChkTrainee.Margin = new System.Windows.Forms.Padding(4);
            this.ChkTrainee.Name = "ChkTrainee";
            this.ChkTrainee.Size = new System.Drawing.Size(113, 19);
            this.ChkTrainee.TabIndex = 260;
            this.ChkTrainee.Text = "Auszubildender?";
            this.ChkTrainee.UseVisualStyleBackColor = true;
            this.ChkTrainee.CheckedChanged += new System.EventHandler(this.RadButtons_CheckedChanged);
            // 
            // LblApprenticeshipcurrentyear
            // 
            this.LblApprenticeshipcurrentyear.AutoSize = true;
            this.LblApprenticeshipcurrentyear.Location = new System.Drawing.Point(169, 211);
            this.LblApprenticeshipcurrentyear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblApprenticeshipcurrentyear.Name = "LblApprenticeshipcurrentyear";
            this.LblApprenticeshipcurrentyear.Size = new System.Drawing.Size(107, 15);
            this.LblApprenticeshipcurrentyear.TabIndex = 60;
            this.LblApprenticeshipcurrentyear.Text = "aktuelles Lehrjahr *";
            // 
            // LblApprenticeshipyears
            // 
            this.LblApprenticeshipyears.AutoSize = true;
            this.LblApprenticeshipyears.Location = new System.Drawing.Point(306, 211);
            this.LblApprenticeshipyears.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblApprenticeshipyears.Name = "LblApprenticeshipyears";
            this.LblApprenticeshipyears.Size = new System.Drawing.Size(103, 15);
            this.LblApprenticeshipyears.TabIndex = 62;
            this.LblApprenticeshipyears.Text = "Anzahl Lehrjahre *";
            // 
            // LblCompanyname
            // 
            this.LblCompanyname.AutoSize = true;
            this.LblCompanyname.Location = new System.Drawing.Point(250, 100);
            this.LblCompanyname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCompanyname.Name = "LblCompanyname";
            this.LblCompanyname.Size = new System.Drawing.Size(82, 15);
            this.LblCompanyname.TabIndex = 64;
            this.LblCompanyname.Text = "Firmenname *";
            // 
            // TxtCompanyname
            // 
            this.TxtCompanyname.Location = new System.Drawing.Point(250, 116);
            this.TxtCompanyname.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCompanyname.Name = "TxtCompanyname";
            this.TxtCompanyname.Size = new System.Drawing.Size(194, 23);
            this.TxtCompanyname.TabIndex = 160;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 58);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 15);
            this.label16.TabIndex = 75;
            this.label16.Text = "Strasse";
            // 
            // TxtStreet
            // 
            this.TxtStreet.Location = new System.Drawing.Point(18, 74);
            this.TxtStreet.Margin = new System.Windows.Forms.Padding(4);
            this.TxtStreet.Name = "TxtStreet";
            this.TxtStreet.Size = new System.Drawing.Size(195, 23);
            this.TxtStreet.TabIndex = 110;
            // 
            // TxtPostcode
            // 
            this.TxtPostcode.Location = new System.Drawing.Point(18, 116);
            this.TxtPostcode.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPostcode.Name = "TxtPostcode";
            this.TxtPostcode.Size = new System.Drawing.Size(195, 23);
            this.TxtPostcode.TabIndex = 120;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 100);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 15);
            this.label17.TabIndex = 77;
            this.label17.Text = "PLZ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(15, 187);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(33, 15);
            this.label27.TabIndex = 79;
            this.label27.Text = "Land";
            // 
            // DrpdCountry
            // 
            this.DrpdCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrpdCountry.FormattingEnabled = true;
            this.DrpdCountry.Items.AddRange(new object[] {
            "k/A",
            "Afghanistan",
            "Ägypten",
            "Albanien",
            "Algerien",
            "Andorra",
            "Angola",
            "Antigua und Barbuda",
            "Äquatorialguinea",
            "Argentinien",
            "Armenien",
            "Aserbaidschan",
            "Äthiopien",
            "Australien",
            "Bahamas",
            "Bahrain",
            "Bangladesch",
            "Barbados",
            "Belgien",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivien",
            "Bosnien und Herzegowina",
            "Botsuana",
            "Brasilien",
            "Brunei",
            "Bulgarien",
            "Burkina Faso",
            "Burundi",
            "Chile",
            "China",
            "Costa Rica",
            "Dänemark",
            "Demokratische Republik Kongo",
            "Deutschland",
            "Dominica",
            "Dominikanische Republik",
            "Dschibuti",
            "Ecuador",
            "El Salvador",
            "Elfenbeinküste",
            "England",
            "Eritrea",
            "Estland",
            "Färöer-Inseln",
            "Fidschi",
            "Finnland",
            "Frankreich",
            "Gabun",
            "Gambia",
            "Georgien",
            "Ghana",
            "Grenada",
            "Griechenland",
            "Grönland",
            "Großbritannien",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hongkong",
            "Indien",
            "Indonesien",
            "Irak",
            "Iran",
            "Irland",
            "Island",
            "Israel",
            "Italien",
            "Jamaika",
            "Japan",
            "Jemen",
            "Jordanien",
            "Kambodscha",
            "Kamerun",
            "Kanada",
            "Kap Verde",
            "Kasachstan",
            "Katar",
            "Kenia",
            "Kirgisistan",
            "Kiribati",
            "Kolumbien",
            "Komoren",
            "Kongo",
            "Kosovo",
            "Kroatien",
            "Kuba",
            "Kuwait",
            "Laos",
            "Lesotho",
            "Lettland",
            "Libanon",
            "Liberia",
            "Libyen",
            "Liechtenstein",
            "Litauen",
            "Luxemburg",
            "Macau",
            "Madagaskar",
            "Malawi",
            "Malaysia",
            "Malediven",
            "Mali",
            "Malta",
            "Marokko",
            "Marshallinseln",
            "Mauretanien",
            "Mauritius",
            "Mazedonien",
            "Mexiko",
            "Mikronesien",
            "Moldau",
            "Monaco",
            "Mongolei",
            "Montenegro",
            "Mosambik",
            "Myanmar",
            "Namibia",
            "Nauru",
            "Nepal",
            "Neuseeland",
            "Nicaragua",
            "Niederlande",
            "Niger",
            "Nigeria",
            "Nordkorea",
            "Norwegen",
            "Oman",
            "Österreich",
            "Pakistan",
            "Palästina",
            "Palau",
            "Panama",
            "Papua-Neuguinea",
            "Paraguay",
            "Peru",
            "Philippinen",
            "Polen",
            "Portugal",
            "Puerto Rico",
            "Republik Kongo",
            "(auch: Kongo-Brazzaville)",
            "Ruanda",
            "Rumänien",
            "Russland",
            "Salomonen",
            "Sambia",
            "Samoa",
            "San Marino",
            "Saudi-Arabien",
            "Schottland",
            "Schweden",
            "Schweiz",
            "Senegal",
            "Serbien",
            "Seychellen",
            "Sierra Leone",
            "Simbabwe",
            "Singapur",
            "Slowakei",
            "Slowenien",
            "Somalia",
            "Spanien",
            "Sri Lanka",
            "St. Kitts und Nevis",
            "St. Lucia",
            "St. Vincent und die Grenadinen",
            "Südafrika",
            "Sudan",
            "Südkorea",
            "Suriname",
            "Swasiland",
            "Syrien",
            "São Tomé und Príncipe",
            "Tadschikistan",
            "Taiwan",
            "Tansania",
            "Thailand",
            "Tibet",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad und Tobago",
            "Tschad",
            "Tschechische Republik",
            "Tunesien",
            "Türkei",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "Ungarn",
            "Uruguay",
            "USA",
            "Usbekistan",
            "Vanuatu",
            "Vatikanstadt",
            "Venezuela",
            "Vereinigte Arabische Emirate",
            "Vietnam",
            "Wales",
            "Weißrussland",
            "Zentralafrikanische Republik",
            "Zypern"});
            this.DrpdCountry.Location = new System.Drawing.Point(16, 205);
            this.DrpdCountry.Margin = new System.Windows.Forms.Padding(4);
            this.DrpdCountry.Name = "DrpdCountry";
            this.DrpdCountry.Size = new System.Drawing.Size(196, 23);
            this.DrpdCountry.TabIndex = 140;
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(16, 160);
            this.TxtCity.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(196, 23);
            this.TxtCity.TabIndex = 130;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(14, 143);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(34, 15);
            this.label28.TabIndex = 81;
            this.label28.Text = "Stadt";
            // 
            // NumMgmtLvl
            // 
            this.NumMgmtLvl.Location = new System.Drawing.Point(169, 166);
            this.NumMgmtLvl.Margin = new System.Windows.Forms.Padding(4);
            this.NumMgmtLvl.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumMgmtLvl.Name = "NumMgmtLvl";
            this.NumMgmtLvl.Size = new System.Drawing.Size(176, 23);
            this.NumMgmtLvl.TabIndex = 250;
            // 
            // LblCusttype
            // 
            this.LblCusttype.AutoSize = true;
            this.LblCusttype.Location = new System.Drawing.Point(250, 55);
            this.LblCusttype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCusttype.Name = "LblCusttype";
            this.LblCusttype.Size = new System.Drawing.Size(73, 15);
            this.LblCusttype.TabIndex = 93;
            this.LblCusttype.Text = "Kundentyp *";
            // 
            // DrpdCusttype
            // 
            this.DrpdCusttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrpdCusttype.FormattingEnabled = true;
            this.DrpdCusttype.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.DrpdCusttype.Location = new System.Drawing.Point(251, 74);
            this.DrpdCusttype.Margin = new System.Windows.Forms.Padding(4);
            this.DrpdCusttype.Name = "DrpdCusttype";
            this.DrpdCusttype.Size = new System.Drawing.Size(193, 23);
            this.DrpdCusttype.TabIndex = 150;
            // 
            // groupAddress
            // 
            this.groupAddress.Controls.Add(this.LblFax);
            this.groupAddress.Controls.Add(this.TxtFax);
            this.groupAddress.Controls.Add(this.LblCompanyname);
            this.groupAddress.Controls.Add(this.TxtCompanyname);
            this.groupAddress.Controls.Add(this.label16);
            this.groupAddress.Controls.Add(this.TxtStreet);
            this.groupAddress.Controls.Add(this.DrpdCusttype);
            this.groupAddress.Controls.Add(this.label17);
            this.groupAddress.Controls.Add(this.LblCusttype);
            this.groupAddress.Controls.Add(this.TxtPostcode);
            this.groupAddress.Controls.Add(this.label28);
            this.groupAddress.Controls.Add(this.TxtCity);
            this.groupAddress.Controls.Add(this.label27);
            this.groupAddress.Controls.Add(this.DrpdCountry);
            this.groupAddress.Location = new System.Drawing.Point(10, 299);
            this.groupAddress.Margin = new System.Windows.Forms.Padding(4);
            this.groupAddress.Name = "groupAddress";
            this.groupAddress.Padding = new System.Windows.Forms.Padding(4);
            this.groupAddress.Size = new System.Drawing.Size(514, 270);
            this.groupAddress.TabIndex = 9930;
            this.groupAddress.TabStop = false;
            this.groupAddress.Text = "Adresse";
            // 
            // LblFax
            // 
            this.LblFax.AutoSize = true;
            this.LblFax.Location = new System.Drawing.Point(250, 143);
            this.LblFax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFax.Name = "LblFax";
            this.LblFax.Size = new System.Drawing.Size(71, 15);
            this.LblFax.TabIndex = 96;
            this.LblFax.Text = "Faxnummer";
            // 
            // TxtFax
            // 
            this.TxtFax.Location = new System.Drawing.Point(251, 161);
            this.TxtFax.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFax.Name = "TxtFax";
            this.TxtFax.Size = new System.Drawing.Size(193, 23);
            this.TxtFax.TabIndex = 170;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(178, 29);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(49, 15);
            this.label35.TabIndex = 85;
            this.label35.Text = "E-Mail *";
            // 
            // groupEmployee
            // 
            this.groupEmployee.Controls.Add(this.CbEndDate);
            this.groupEmployee.Controls.Add(this.DrpdFunction);
            this.groupEmployee.Controls.Add(this.DrpdDept);
            this.groupEmployee.Controls.Add(this.NumApprenticeshipyears);
            this.groupEmployee.Controls.Add(this.NumApprenticeshipcurrentyear);
            this.groupEmployee.Controls.Add(this.NumEmploymentpercent);
            this.groupEmployee.Controls.Add(this.LblApprenticeshipcurrentyear);
            this.groupEmployee.Controls.Add(this.label22);
            this.groupEmployee.Controls.Add(this.label19);
            this.groupEmployee.Controls.Add(this.DateStartDate);
            this.groupEmployee.Controls.Add(this.label20);
            this.groupEmployee.Controls.Add(this.NumMgmtLvl);
            this.groupEmployee.Controls.Add(this.DateLeaveDate);
            this.groupEmployee.Controls.Add(this.label15);
            this.groupEmployee.Controls.Add(this.TxtSocialsecurity);
            this.groupEmployee.Controls.Add(this.label23);
            this.groupEmployee.Controls.Add(this.label21);
            this.groupEmployee.Controls.Add(this.label14);
            this.groupEmployee.Controls.Add(this.LblApprenticeshipyears);
            this.groupEmployee.Controls.Add(this.label13);
            this.groupEmployee.Controls.Add(this.TxtEmployeenumb);
            this.groupEmployee.Controls.Add(this.ChkTrainee);
            this.groupEmployee.Location = new System.Drawing.Point(556, 300);
            this.groupEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.groupEmployee.Name = "groupEmployee";
            this.groupEmployee.Padding = new System.Windows.Forms.Padding(4);
            this.groupEmployee.Size = new System.Drawing.Size(532, 269);
            this.groupEmployee.TabIndex = 9940;
            this.groupEmployee.TabStop = false;
            this.groupEmployee.Text = "Mitarbeiter";
            // 
            // CbEndDate
            // 
            this.CbEndDate.AutoSize = true;
            this.CbEndDate.Location = new System.Drawing.Point(389, 99);
            this.CbEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.CbEndDate.Name = "CbEndDate";
            this.CbEndDate.Size = new System.Drawing.Size(65, 19);
            this.CbEndDate.TabIndex = 229;
            this.CbEndDate.Text = "Austritt";
            this.CbEndDate.UseVisualStyleBackColor = true;
            this.CbEndDate.CheckedChanged += new System.EventHandler(this.CbEndDate_CheckedChanged);
            // 
            // DrpdFunction
            // 
            this.DrpdFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrpdFunction.FormattingEnabled = true;
            this.DrpdFunction.Items.AddRange(new object[] {
            "Mitarbeiter",
            "Teamleiter",
            "Linemanager",
            "Manager",
            "CEO",
            "CFO",
            "CTO",
            "CIO",
            "COO"});
            this.DrpdFunction.Location = new System.Drawing.Point(24, 113);
            this.DrpdFunction.Margin = new System.Windows.Forms.Padding(2);
            this.DrpdFunction.Name = "DrpdFunction";
            this.DrpdFunction.Size = new System.Drawing.Size(117, 23);
            this.DrpdFunction.TabIndex = 210;
            // 
            // DrpdDept
            // 
            this.DrpdDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrpdDept.FormattingEnabled = true;
            this.DrpdDept.Items.AddRange(new object[] {
            "IT",
            "HR",
            "Technik",
            "Verkauf",
            "Geschäftsleitung",
            "Payroll"});
            this.DrpdDept.Location = new System.Drawing.Point(23, 70);
            this.DrpdDept.Margin = new System.Windows.Forms.Padding(2);
            this.DrpdDept.Name = "DrpdDept";
            this.DrpdDept.Size = new System.Drawing.Size(117, 23);
            this.DrpdDept.TabIndex = 180;
            // 
            // NumApprenticeshipyears
            // 
            this.NumApprenticeshipyears.Location = new System.Drawing.Point(305, 230);
            this.NumApprenticeshipyears.Margin = new System.Windows.Forms.Padding(4);
            this.NumApprenticeshipyears.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.NumApprenticeshipyears.Name = "NumApprenticeshipyears";
            this.NumApprenticeshipyears.Size = new System.Drawing.Size(114, 23);
            this.NumApprenticeshipyears.TabIndex = 280;
            // 
            // NumApprenticeshipcurrentyear
            // 
            this.NumApprenticeshipcurrentyear.Location = new System.Drawing.Point(167, 230);
            this.NumApprenticeshipcurrentyear.Margin = new System.Windows.Forms.Padding(4);
            this.NumApprenticeshipcurrentyear.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.NumApprenticeshipcurrentyear.Name = "NumApprenticeshipcurrentyear";
            this.NumApprenticeshipcurrentyear.Size = new System.Drawing.Size(114, 23);
            this.NumApprenticeshipcurrentyear.TabIndex = 270;
            // 
            // NumEmploymentpercent
            // 
            this.NumEmploymentpercent.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumEmploymentpercent.Location = new System.Drawing.Point(24, 167);
            this.NumEmploymentpercent.Margin = new System.Windows.Forms.Padding(4);
            this.NumEmploymentpercent.Name = "NumEmploymentpercent";
            this.NumEmploymentpercent.Size = new System.Drawing.Size(117, 23);
            this.NumEmploymentpercent.TabIndex = 240;
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(272, 586);
            this.CmdDelete.Margin = new System.Windows.Forms.Padding(4);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(122, 26);
            this.CmdDelete.TabIndex = 340;
            this.CmdDelete.Text = "Löschen";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // groupPerson
            // 
            this.groupPerson.Controls.Add(this.DrpdFormOfAddress);
            this.groupPerson.Controls.Add(this.label3);
            this.groupPerson.Controls.Add(this.label35);
            this.groupPerson.Controls.Add(this.TxtName);
            this.groupPerson.Controls.Add(this.label4);
            this.groupPerson.Controls.Add(this.TxtSurname);
            this.groupPerson.Controls.Add(this.DrpdNationality);
            this.groupPerson.Controls.Add(this.label5);
            this.groupPerson.Controls.Add(this.label18);
            this.groupPerson.Controls.Add(this.label6);
            this.groupPerson.Controls.Add(this.label11);
            this.groupPerson.Controls.Add(this.label7);
            this.groupPerson.Controls.Add(this.DrpdSex);
            this.groupPerson.Controls.Add(this.label10);
            this.groupPerson.Controls.Add(this.TxtPhone);
            this.groupPerson.Controls.Add(this.DateBday);
            this.groupPerson.Controls.Add(this.TxtMobile);
            this.groupPerson.Controls.Add(this.DrpdTitle);
            this.groupPerson.Controls.Add(this.label8);
            this.groupPerson.Controls.Add(this.TxtEmail);
            this.groupPerson.Location = new System.Drawing.Point(186, 14);
            this.groupPerson.Margin = new System.Windows.Forms.Padding(2);
            this.groupPerson.Name = "groupPerson";
            this.groupPerson.Padding = new System.Windows.Forms.Padding(2);
            this.groupPerson.Size = new System.Drawing.Size(338, 277);
            this.groupPerson.TabIndex = 9920;
            this.groupPerson.TabStop = false;
            this.groupPerson.Text = "Person";
            // 
            // CmdSaveAndClose
            // 
            this.CmdSaveAndClose.Location = new System.Drawing.Point(556, 586);
            this.CmdSaveAndClose.Margin = new System.Windows.Forms.Padding(4);
            this.CmdSaveAndClose.Name = "CmdSaveAndClose";
            this.CmdSaveAndClose.Size = new System.Drawing.Size(532, 26);
            this.CmdSaveAndClose.TabIndex = 300;
            this.CmdSaveAndClose.Text = "Speichern und Schliessen";
            this.CmdSaveAndClose.UseCompatibleTextRendering = true;
            this.CmdSaveAndClose.UseMnemonic = false;
            this.CmdSaveAndClose.UseVisualStyleBackColor = true;
            this.CmdSaveAndClose.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(this.tabCustLogs);
            this.tabLogs.Controls.Add(this.tabAuditTrail);
            this.tabLogs.Location = new System.Drawing.Point(556, 14);
            this.tabLogs.Margin = new System.Windows.Forms.Padding(2);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.SelectedIndex = 0;
            this.tabLogs.Size = new System.Drawing.Size(532, 277);
            this.tabLogs.TabIndex = 9950;
            this.tabLogs.TabStop = false;
            // 
            // tabCustLogs
            // 
            this.tabCustLogs.BackColor = System.Drawing.SystemColors.Control;
            this.tabCustLogs.Controls.Add(this.CmdSaveLog);
            this.tabCustLogs.Controls.Add(this.label1);
            this.tabCustLogs.Controls.Add(this.TxtLogInput);
            this.tabCustLogs.Controls.Add(this.TxtLogOutput);
            this.tabCustLogs.Location = new System.Drawing.Point(4, 24);
            this.tabCustLogs.Margin = new System.Windows.Forms.Padding(2);
            this.tabCustLogs.Name = "tabCustLogs";
            this.tabCustLogs.Padding = new System.Windows.Forms.Padding(2);
            this.tabCustLogs.Size = new System.Drawing.Size(524, 249);
            this.tabCustLogs.TabIndex = 0;
            this.tabCustLogs.Text = "Kundenlogs";
            // 
            // CmdSaveLog
            // 
            this.CmdSaveLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdSaveLog.Location = new System.Drawing.Point(455, 20);
            this.CmdSaveLog.Margin = new System.Windows.Forms.Padding(2);
            this.CmdSaveLog.Name = "CmdSaveLog";
            this.CmdSaveLog.Size = new System.Drawing.Size(63, 24);
            this.CmdSaveLog.TabIndex = 5;
            this.CmdSaveLog.Text = "Speichern";
            this.CmdSaveLog.UseVisualStyleBackColor = true;
            this.CmdSaveLog.Click += new System.EventHandler(this.CmdSaveLog_Click);
            // 
            // tabAuditTrail
            // 
            this.tabAuditTrail.BackColor = System.Drawing.SystemColors.Control;
            this.tabAuditTrail.Controls.Add(this.TxtAuditTrail);
            this.tabAuditTrail.Location = new System.Drawing.Point(4, 24);
            this.tabAuditTrail.Margin = new System.Windows.Forms.Padding(2);
            this.tabAuditTrail.Name = "tabAuditTrail";
            this.tabAuditTrail.Padding = new System.Windows.Forms.Padding(2);
            this.tabAuditTrail.Size = new System.Drawing.Size(524, 249);
            this.tabAuditTrail.TabIndex = 1;
            this.tabAuditTrail.Text = "Audit Trail";
            // 
            // TxtAuditTrail
            // 
            this.TxtAuditTrail.Location = new System.Drawing.Point(4, 6);
            this.TxtAuditTrail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAuditTrail.Multiline = true;
            this.TxtAuditTrail.Name = "TxtAuditTrail";
            this.TxtAuditTrail.ReadOnly = true;
            this.TxtAuditTrail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtAuditTrail.Size = new System.Drawing.Size(515, 237);
            this.TxtAuditTrail.TabIndex = 5;
            this.TxtAuditTrail.TabStop = false;
            // 
            // FormController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1111, 625);
            this.Controls.Add(this.tabLogs);
            this.Controls.Add(this.CmdSaveAndClose);
            this.Controls.Add(this.groupPerson);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.groupEmployee);
            this.Controls.Add(this.groupAddress);
            this.Controls.Add(this.ChkState);
            this.Controls.Add(this.CmdAbort);
            this.Controls.Add(this.CmdEdit);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.groupType);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormController";
            this.Text = "Person";
            this.Load += new System.EventHandler(this.ContactForm_Load);
            this.groupType.ResumeLayout(false);
            this.groupType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumMgmtLvl)).EndInit();
            this.groupAddress.ResumeLayout(false);
            this.groupAddress.PerformLayout();
            this.groupEmployee.ResumeLayout(false);
            this.groupEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumApprenticeshipyears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumApprenticeshipcurrentyear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEmploymentpercent)).EndInit();
            this.groupPerson.ResumeLayout(false);
            this.groupPerson.PerformLayout();
            this.tabLogs.ResumeLayout(false);
            this.tabCustLogs.ResumeLayout(false);
            this.tabCustLogs.PerformLayout();
            this.tabAuditTrail.ResumeLayout(false);
            this.tabAuditTrail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtLogInput;
        private System.Windows.Forms.RadioButton RadPrivat;
        private System.Windows.Forms.GroupBox groupType;
        private System.Windows.Forms.RadioButton RadEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtLogOutput;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdEdit;
        private System.Windows.Forms.Button CmdAbort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DrpdFormOfAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DateBday;
        private System.Windows.Forms.ComboBox DrpdSex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox DrpdTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtMobile;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.CheckBox ChkState;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtEmployeenumb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtSocialsecurity;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox DrpdNationality;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker DateStartDate;
        private System.Windows.Forms.DateTimePicker DateLeaveDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox ChkTrainee;
        private System.Windows.Forms.Label LblApprenticeshipcurrentyear;
        private System.Windows.Forms.Label LblApprenticeshipyears;
        private System.Windows.Forms.Label LblCompanyname;
        private System.Windows.Forms.TextBox TxtCompanyname;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtStreet;
        private System.Windows.Forms.TextBox TxtPostcode;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton RadBusinessCustomer;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox DrpdCountry;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown NumMgmtLvl;
        private System.Windows.Forms.Label LblCusttype;
        private System.Windows.Forms.ComboBox DrpdCusttype;
        private System.Windows.Forms.GroupBox groupAddress;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.GroupBox groupEmployee;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Label LblFax;
        private System.Windows.Forms.TextBox TxtFax;
        private System.Windows.Forms.NumericUpDown NumEmploymentpercent;
        private System.Windows.Forms.NumericUpDown NumApprenticeshipyears;
        private System.Windows.Forms.NumericUpDown NumApprenticeshipcurrentyear;
        private System.Windows.Forms.ComboBox DrpdDept;
        private System.Windows.Forms.GroupBox groupPerson;
        private System.Windows.Forms.ComboBox DrpdFunction;
        private System.Windows.Forms.CheckBox CbEndDate;
        private System.Windows.Forms.Button CmdSaveAndClose;
        private System.Windows.Forms.TabControl tabLogs;
        private System.Windows.Forms.TabPage tabCustLogs;
        private System.Windows.Forms.TabPage tabAuditTrail;
        private System.Windows.Forms.TextBox TxtAuditTrail;
        private System.Windows.Forms.Button CmdSaveLog;
    }
}