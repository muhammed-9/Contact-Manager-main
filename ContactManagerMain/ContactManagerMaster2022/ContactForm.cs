using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ContactManagerMaster2022;

public partial class ContactForm : Form
{
    //Datei und Ordner Pfad
    public const string folderpath = @"c:\temp\contactmanager";
    public const string filepath = @"c:\temp\contactmanager\data.data";

    //Persontype setzen und Liste der Personen holen
    private List<Person> dataSet;
    private int personType;
    private int personTypeOnLoad = -1;
    private string userGuid = "";

    public ContactForm(string guid)
    {
        //Benutzer GUID global setzen
        userGuid = guid;

        InitializeComponent();
    }

    private void ContactForm_Load(object sender, EventArgs e)
    {
        //Setzt den Standardmodus
        if (userGuid.Length < 1)
        {
            CmdEdit.Text = "Sperren";
        }

        //Überprüft ob der Zielordner existiert und verfügbar ist
        if (CheckFolder(folderpath))
        {
            if (!InitializeControl())
            {
                Close();
            }
        }
        else
        {
            Close();
        }

        //Setzt den Audittrail auf Schreibgeschützt
        TxtAuditTrail.ReadOnly = true;
    }

    //Wenn ein Problem beim laden eines bereits vorhandenen Kontaktes besteht, gibt diese Methode false zurück. 
    //In den erfolgreichen Fällen, wird die Applikaiton für die Benutzung initialisiert
    private bool InitializeControl()
    {
        //Bereits existente Kontaktdaten in Applikation laden
        dataSet = ReadFile(filepath);

        //Unterscheidet ob ein neuer Kontakt erstellt oder ein bereits vorhandener gesucht wird. 
        var selectedPerson = FindSelectedUser(userGuid, dataSet);
        if (selectedPerson != null)
        {
            if (LoadPerson(selectedPerson))
            {
                SetControlStatus();
                return true;
            }

            MessageBox.Show("Fehler beim Laden des Kontaktes.");
            return false;
        }

        //Setzt den Standardwert des Personentyps, wenn ein neuer Kontakt angelegt wird 
        if (!RadPrivat.Checked && !RadBusinessCustomer.Checked && !RadEmployee.Checked)
        {
            RadPrivat.Checked = true;
            personType = 1;
        }

        return true;
    }

    private bool LoadPerson(Person person)
    {
        //Wenn kein neuer Kontakt erstellt wird, wird der bereits vorhandene Kontakt in der Variable zwischengespeichert
        if (userGuid.Length > 1)
        {
            personTypeOnLoad = person.Type;
        }

        //Ladet alle Daten nach Kontakttyp 
        if (person.Type >= 0 && person.Type < 5)
        {
            RadPrivat.Checked = false;
            RadBusinessCustomer.Checked = false;
            RadEmployee.Checked = false;
            ChkTrainee.Checked = false;

            if (person.Type == 1)
            {
                RadPrivat.Checked = true;
            }

            if (person.Type == 2)
            {
                RadBusinessCustomer.Checked = true;
            }

            if (person.Type == 3)
            {
                RadEmployee.Checked = true;
            }

            if (person.Type == 4)
            {
                RadEmployee.Checked = true;
                ChkTrainee.Checked = true;
            }

            //Daten gemäss Typ laden
            switch (person.Type)
            {
                case 1: //gehe zu case 2
                case 2:
                    var customerTmp = (Customer) person;
                    TxtCompanyname.Text = customerTmp.CompanyName;
                    TxtFax.Text = customerTmp.FaxNumb;
                    DrpdCusttype.Text = Convert.ToString(customerTmp.CustType);
                    goto default;

                case 3:
                    var employee = (Employee) person;
                    TxtEmployeenumb.Text = employee.EmployeeNumber;
                    DrpdDept.Text = employee.Department;
                    TxtSocialsecurity.Text = employee.SocialSecurityNumber;
                    DrpdFunction.Text = employee.Function;
                    DateStartDate.Value = employee.StartDate;
                    DateLeaveDate.Value = employee.LeaveDate;
                    NumEmploymentpercent.Value = employee.EmploymentPercent;
                    NumMgmtLvl.Value = employee.ManagementLevel;
                    goto default;

                case 4:
                    var traineeTmp = (Trainee) person;
                    NumApprenticeshipcurrentyear.Value = traineeTmp.CurrentYearOfTraining;
                    NumApprenticeshipyears.Value = traineeTmp.YearsOfTraining;
                    goto case 3;

                default:
                    ChkState.Checked = person.State;
                    DrpdFormOfAddress.Text = person.FormOfAddress;
                    TxtName.Text = person.FirstName;
                    DrpdTitle.Text = person.Title;
                    TxtSurname.Text = person.Surname;
                    TxtPhone.Text = person.Phone;
                    DateBday.Value = person.Birthday;
                    TxtMobile.Text = person.Mobile;
                    DrpdSex.Text = Convert.ToString(person.Sex);
                    TxtEmail.Text = person.Email;
                    DrpdNationality.Text = person.Nationality;
                    TxtStreet.Text = person.Street;
                    TxtCity.Text = person.City;
                    TxtPostcode.Text = person.Postcode;
                    DrpdCountry.Text = person.Country;
                    TxtLogOutput.Text = person.Log;
                    TxtAuditTrail.Text = person.AuditTrail;
                    break;
            }

            return true;
        }

        // Gibt einen Fehler zurück, wenn der Kontakt nicht geladen werden konnte
        MessageBox.Show("Fehler beim Laden des Kontaktes!");
        return false;
    }

    //Überprüfen ob Ordner zur Ablage der Daten vorhanden ist
    public static bool CheckFolder(string folderpath)
    {
        try
        {
            //Erstellen des Ordners
            Directory.CreateDirectory(folderpath);
        }
        catch
        {
            //Wenn der Ordner nicht erstellt werden konnte, wird diese Meldung zurückgegeben.
            MessageBox.Show(
                "Fehler in der Datenbankerstellung. Bitte überprüfen Sie, dass der Pfad C:\\temp verfübar und erreichbar ist.");
            return false;
        }

        return true;
    }

    private List<Person> ReadFile(string filepath)
    {
        //Ladet die Daten aus der Datenbank in das Programm
        IFormatter formatter = new BinaryFormatter();

        try
        {
            using (Stream stream = File.OpenRead(filepath))
            {
                var persons = (List<Person>) formatter.Deserialize(stream);
                return persons;
            }
        }
        catch (Exception em)
        {
            Console.WriteLine(em.Message);
        }

        //return new List<Person>();
        var empty = new List<Person>();
        return empty;
    }

    //Sucht die ausgewählte Person
    private Person FindSelectedUser(string userGuid, List<Person> persons)
    {
        if (userGuid.Length > 0 && persons != null)
        {
            foreach (var selectedPerson in persons)
            {
                if (selectedPerson.Id == userGuid)
                {
                    personType = selectedPerson.Type;
                    return selectedPerson;
                }
            }
        }

        return null;
    }

    private void SetControlStatus()
    {
        // Initialisieren der Steuerelemente
        groupType.Visible = true;
        groupPerson.Visible = true;
        groupAddress.Visible = true;
        LblCompanyname.Visible = false;
        TxtCompanyname.Visible = false;
        LblApprenticeshipcurrentyear.Visible = false;
        NumApprenticeshipcurrentyear.Visible = false;
        LblApprenticeshipyears.Visible = false;
        NumApprenticeshipyears.Visible = false;
        DateLeaveDate.Enabled = false;
        TxtLogInput.Enabled = false;
        LblFax.Visible = false;
        TxtFax.Visible = false;
        TxtEmployeenumb.Enabled = false;

        if (CbEndDate.Checked)
        {
            DateLeaveDate.Enabled = true;
        }
        else
        {
            DateLeaveDate.Enabled = true;
            DateLeaveDate.Value = DateTime.Parse("01/01/1800");
            DateLeaveDate.Enabled = false;
        }

        switch (personType)
        {
            case 1:

                goto case 5;

            case 2:
                LblCompanyname.Visible = true;
                TxtCompanyname.Visible = true;
                LblFax.Visible = true;
                TxtFax.Visible = true;
                goto case 5;

            case 3:

                goto case 6;

            case 4:
                LblApprenticeshipcurrentyear.Visible = true;
                NumApprenticeshipcurrentyear.Visible = true;
                LblApprenticeshipyears.Visible = true;
                NumApprenticeshipyears.Visible = true;
                goto case 6;

            case 5: //Effektiv im Fall 1 und 2
                groupEmployee.Visible = false;
                LblCusttype.Visible = true;
                DrpdCusttype.Visible = true;
                break;

            case 6: //Effektib im Fall 3 und 4
                groupEmployee.Visible = true;
                LblCusttype.Visible = false;
                DrpdCusttype.Visible = false;


                break;
        }

        if (ChkState.Checked)
        {
            if (userGuid.Length > 1)
            {
                TxtLogInput.Enabled = true;
            }

            if (CmdEdit.Text == "Sperren")
            {
                groupType.Enabled = true;
                groupPerson.Enabled = true;
                groupAddress.Enabled = true;
                groupEmployee.Enabled = true;
            }
            else
            {
                groupType.Enabled = false;
                groupPerson.Enabled = false;
                groupAddress.Enabled = false;
                groupEmployee.Enabled = false;
            }
        }
        else
        {
            groupType.Enabled = false;
            groupPerson.Enabled = false;
            groupAddress.Enabled = false;
            groupEmployee.Enabled = false;
        }
    }

    //Weitergabe des Personentyps gemäss Auswahl  
    private void RadButtons_CheckedChanged(object sender, EventArgs e)
    {
        if (RadPrivat.Checked)
        {
            personType = 1;
        }
        else if (RadBusinessCustomer.Checked)
        {
            personType = 2;
        }
        else if (RadEmployee.Checked && !ChkTrainee.Checked)
        {
            personType = 3;
        }
        else if (RadEmployee.Checked && ChkTrainee.Checked)
        {
            personType = 4;
        }

        SetControlStatus();
    }

    // Speichern der Person in der Datenbank
    private void SavePersonList(List<Person> persons)
    {
        IFormatter formatter = new BinaryFormatter();

        using (var stream = File.Create(filepath))
        {
            formatter.Serialize(stream, persons);
        }
    }

    //Aufrufen der benötigten Funktionen um die aktuellen Daten zu speichern
    private void CmdSave_Click(object sender, EventArgs e)
    {
        //Überprüft ob das Austrittsdatum nach dem Eintrittsdatum liegt
        if (DateLeaveDate.Value > DateStartDate.Value || DateLeaveDate.Value == DateTime.Parse("01/01/1800"))
        {
            List<Person> persons = Save();
            if (persons != null)
            {
                SavePersonList(persons);
                InitializeControl();
                if (sender.ToString().Contains("Schliessen"))
                {
                    Close();
                }

                MessageBox.Show("Der Datensatz wurde erfolgreich gespeichert.");
            }
        }
        else
        {
            MessageBox.Show(
                "Bitte ein gültiges Austrittsdatum eingeben. Das Austrittsdatum muss nach dem Eintrittsdatum liegen.");
        }
    }

    //Überprüft die Einzigartigkeit der E-Mailadresse
    private bool EmailIsUnique(List<Person> persons)
    {
        foreach (var person in persons)
        {
            if (TxtEmail.Text.Trim() == person.Email && userGuid != person.Id)
            {
                return false;
            }
        }

        return true;
    }


    //Startet das Überprüfen und den Initialisierungsprozess um den Kontakt zu speichern
    private List<Person> Save()
    {
        List<Person> templist = new List<Person>(dataSet);
        var guid = "";

        if (EmailIsUnique(templist))
        {
            try
            {
                var templog = "";
                var tempAuditTrail = "";
                if (userGuid.Length > 1)
                {
                    //Anpassung von Kunde zu Angestelltem oder Lehrling
                    if ((personTypeOnLoad == 1 || personTypeOnLoad == 2) && (RadEmployee.Checked || ChkTrainee.Checked))
                    {
                        tempAuditTrail = DateTime.Now + " - " + "Firmenname, Faxnummer und Kundentyp gelöscht." +
                                         "\r\n";
                        tempAuditTrail = AuditTrailOnObjectChange(1) + tempAuditTrail;
                    }
                    //Anpassung von Angestelltem zu Kunde
                    else if (personTypeOnLoad == 3 && (RadPrivat.Checked || RadBusinessCustomer.Checked))
                    {
                        tempAuditTrail = DateTime.Now + " - " +
                                         "Mitarbeiternummer, Abteilung, AHV-Nummer, Funktion, Startdatum, Enddatum, Beschäftigungsgrad und Kaderstufe gelöscht." +
                                         "\r\n" + tempAuditTrail;
                        tempAuditTrail = AuditTrailOnObjectChange(2) + tempAuditTrail;
                    }
                    //Anpassung von Lehrling zu Angestelltem
                    else if (personTypeOnLoad == 4 && RadEmployee.Checked && !ChkTrainee.Checked)
                    {
                        tempAuditTrail = DateTime.Now + " - " + "Anzahl Lehrjahre und Aktuelles Lehrjahr gelöscht." +
                                         "\r\n" + tempAuditTrail;
                        tempAuditTrail = AuditTrailOnObjectChange(3) + tempAuditTrail;
                    }
                    //Anpassung von Lehrling zu Kunde
                    else if (personTypeOnLoad == 4 && (personTypeOnLoad == 1 || personTypeOnLoad == 2))
                    {
                        tempAuditTrail = DateTime.Now + " - " +
                                         "Mitarbeiternummer, Abteilung, AHV-Nummer, Funktion, Startdatum, Enddatum, Beschäftigungsgrad und Kaderstufe gelöscht." +
                                         "\r\n" + tempAuditTrail;
                        tempAuditTrail = AuditTrailOnObjectChange(2) + tempAuditTrail;
                    }

                    //Erstellt den Log gemäss Personentyp
                    if (personTypeOnLoad == 1 || personTypeOnLoad == 2)
                    {
                        var logperson = (Customer) templist.Find(x => x.Id.Equals(userGuid));
                        templog = CreateCustomerLog(logperson);
                        tempAuditTrail = tempAuditTrail + CreateAuditTrail(logperson);
                    }
                    else if (personTypeOnLoad == 3)
                    {
                        var logperson = (Employee) templist.Find(x => x.Id.Equals(userGuid));
                        templog = CreateCustomerLog(logperson);
                        tempAuditTrail = tempAuditTrail + CreateAuditTrail(logperson);
                    }
                    else if (personTypeOnLoad == 4)
                    {
                        var logperson = (Trainee) templist.Find(x => x.Id.Equals(userGuid));
                        templog = CreateCustomerLog(logperson);
                        tempAuditTrail = tempAuditTrail + CreateAuditTrail(logperson);
                    }
                }

                //Wenn ein neuer Kontakt angelegt wurde wird in einer Zeile das Erstellen bestätigt
                if (tempAuditTrail.Length < 1)
                {
                    tempAuditTrail = DateTime.Now + " - " + "Der Kontakt wurde erfolgreich angelegt.";
                }

                templist.Remove(templist.Find(x => x.Id.Equals(userGuid)));

                //Setzt einen Standardwert, wenn das Geschlecht nicht ausgewählt wurde
                if (!(DrpdSex.Text.Length == 1))
                {
                    DrpdSex.Text = "d";
                }

                //Erstellt die Person nach Typ
                if (RadPrivat.Checked || RadBusinessCustomer.Checked)
                {
                    Customer person = new Customer(userGuid, personType, ChkState.Checked, DrpdFormOfAddress.Text,
                        DrpdTitle.Text, DrpdNationality.Text, TxtName.Text, TxtSurname.Text, TxtStreet.Text,
                        TxtPostcode.Text, TxtCity.Text, DrpdCountry.Text, DateBday.Value,
                        Convert.ToChar(DrpdSex.Text.Substring(0, 1)), TxtPhone.Text, TxtMobile.Text, TxtEmail.Text,
                        templog, tempAuditTrail, Convert.ToChar(DrpdCusttype.Text.Substring(0, 1)), TxtCompanyname.Text,
                        TxtFax.Text);
                    templist.Add(person);
                    guid = person.Id;
                }
                else if (RadEmployee.Checked && !ChkTrainee.Checked)
                {
                    Employee person = new Employee(userGuid, personType, ChkState.Checked, DrpdFormOfAddress.Text,
                        DrpdTitle.Text, DrpdNationality.Text, TxtName.Text, TxtSurname.Text, TxtStreet.Text,
                        TxtPostcode.Text, TxtCity.Text, DrpdCountry.Text, DateBday.Value,
                        Convert.ToChar(DrpdSex.Text.Substring(0, 1)), TxtPhone.Text, TxtMobile.Text, TxtEmail.Text,
                        templog, tempAuditTrail, TxtEmployeenumb.Text, DrpdDept.Text, TxtSocialsecurity.Text,
                        DrpdFunction.Text, DateStartDate.Value, DateLeaveDate.Value,
                        Convert.ToInt32(NumEmploymentpercent.Value), Convert.ToInt32(NumMgmtLvl.Value));
                    templist.Add(person);
                    guid = person.Id;
                }
                else if (RadEmployee.Checked && ChkTrainee.Checked)
                {
                    Trainee person = new Trainee(userGuid, personType, ChkState.Checked, DrpdFormOfAddress.Text,
                        DrpdTitle.Text, DrpdNationality.Text, TxtName.Text, TxtSurname.Text, TxtStreet.Text,
                        TxtPostcode.Text, TxtCity.Text, DrpdCountry.Text, DateBday.Value,
                        Convert.ToChar(DrpdSex.Text.Substring(0, 1)), TxtPhone.Text, TxtMobile.Text, TxtEmail.Text,
                        templog, tempAuditTrail, TxtEmployeenumb.Text, DrpdDept.Text, TxtSocialsecurity.Text,
                        DrpdFunction.Text, DateStartDate.Value, DateLeaveDate.Value,
                        Convert.ToInt32(NumEmploymentpercent.Value), Convert.ToInt32(NumMgmtLvl.Value),
                        Convert.ToChar(Convert.ToInt32(NumApprenticeshipcurrentyear.Value)),
                        Convert.ToChar(Convert.ToInt32(NumApprenticeshipyears.Value)));
                    templist.Add(person);
                    guid = person.Id;
                }
                else
                {
                    throw new Exception("Beim Speichern des des Datensatzes, ist ein Fehler aufgetreten.");
                }

                userGuid = guid;
                return templist;
            }
            catch (Exception es)
            {
                MessageBox.Show("Bitte alle Pflichtfelder ausfüllen. \r\n Problem: " + es.Message);
                return null;
            }
        }

        MessageBox.Show("Diese E-Mail Adresse wurde schon verwendet!");
        return null;
    }

    //Sobald Enter gedrückt wird, wird die Funktion aufgerufen und fügt einen Log hinzu
    private void TxtLogInput_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == 13)
        {
            AddCustLog();
        }
    }

    //Aktivieren und deaktivieren der Möglichkeit die Felder zu bearbeiten
    private void ChkState_CheckedChanged(object sender, EventArgs e)
    {
        if (ChkState.Checked)
        {
            SetControlStatus();
            ChkState.Text = "Status: Aktiv";
        }
        else
        {
            SetControlStatus();
            ChkState.Text = "Status: Inaktiv";
        }
    }

    //Aktiviern und deaktivieren der Daten gemäss Benutzereingabe 
    private void CbEndDate_CheckedChanged(object sender, EventArgs e)
    {
        SetControlStatus();
    }

    // Sperrt oder öffnet den Benutzer für Bearbeitung
    private void CmdEdit_Click(object sender, EventArgs e)
    {
        if (userGuid.Length > 1 && CmdEdit.Text == "Bearbeiten")
        {
            CmdEdit.Text = "Sperren";
            SetControlStatus();
        }
        else if (userGuid.Length > 1 && CmdEdit.Text == "Sperren")
        {
            CmdEdit.Text = "Bearbeiten";
            SetControlStatus();
        }
    }

    //Schliessen des Fensters wenn Abbrechen ausgewählt wurde
    private void CmdAbort_Click(object sender, EventArgs e)
    {
        Close();
    }

    //Abfragen ob der Benutzer gelöscht werden soll und bei ja löschen
    private void CmdDelete_Click(object sender, EventArgs e)
    {
        if ("Yes" == Convert.ToString(MessageBox.Show(this, "Wollen Sie den Datensatz wirklich löschen?", "test",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)))
        {
            var templist = dataSet;
            templist.Remove(templist.Find(x => x.Id.Equals(userGuid)));
            dataSet = templist;
            SavePersonList(templist);
            Close();
        }
    }

    //Gibt den templog zurück 
    private string CreateCustomerLog(Person personcustlog)
    {
        var templog = personcustlog.Log;
        var templine = "#####################################################################";
        if (TxtLogInput.Text != null && TxtLogInput.Text.Length >= 1)
        {
            templog = templine + "\r\n" + DateTime.Now + "\r\n" + TxtLogInput.Text + "\r\n" + "\r\n" + templog;
        }

        return templog;
    }

    //Protokollieren von Objektänderungen
    private string AuditTrailOnObjectChange(int icase)
    {
        var audit = "";

        if (icase == 1)
        {
            if (DrpdDept.SelectedIndex != -1)
            {
                audit = OutputService(audit, "Abteilung", (string) DrpdDept.SelectedItem);
            }

            if (TxtSocialsecurity.Text.Length > 1)
            {
                audit = OutputService(audit, "Sozialversicherungsnummer", TxtSocialsecurity.Text);
            }

            if (DrpdFunction.SelectedIndex != -1)
            {
                audit = OutputService(audit, "Funktion", (string) DrpdFunction.SelectedItem);
            }

            if (DateStartDate.Value != DateTime.Parse("01/01/1800"))
            {
                audit = OutputService(audit, "Startdatum", DateStartDate.Value.ToString());
            }

            if (DateLeaveDate.Value != DateTime.Parse("01/01/1800"))
            {
                audit = OutputService(audit, "Austrittsdatum", DateLeaveDate.Value.ToString());
            }

            if (NumEmploymentpercent.Value >= 0 && NumEmploymentpercent.Value <= 100)
            {
                audit = OutputService(audit, "Beschäftigungsgrad", NumEmploymentpercent.Value.ToString());
            }

            if (NumMgmtLvl.Value >= 0 && NumMgmtLvl.Value <= 5)
            {
                audit = OutputService(audit, "Managementlevel", NumMgmtLvl.Value.ToString());
            }

            if (NumApprenticeshipcurrentyear.Value >= 1 && NumApprenticeshipcurrentyear.Value <= 9)
            {
                audit = OutputService(audit, "Aktuelles Lehrjahr", NumApprenticeshipcurrentyear.Value.ToString());
            }

            if (NumApprenticeshipyears.Value >= 1 && NumApprenticeshipyears.Value <= 9)
            {
                audit = OutputService(audit, "Anzahl Lehrjahre", NumApprenticeshipyears.Value.ToString());
            }
        }
        else if (icase == 2)
        {
            if (DrpdCusttype.SelectedIndex != -1)
            {
                audit = OutputService(audit, "Kundentyp", DrpdCusttype.SelectedItem.ToString());
            }

            if (TxtCompanyname.Text.Length > 1)
            {
                audit = OutputService(audit, "Firmenname", TxtCompanyname.Text);
            }

            if (TxtFax.Text.Length > 1)
            {
                audit = OutputService(audit, "Faxnummer", TxtFax.Text);
            }
        }
        else if (icase == 3)
        {
            if (NumApprenticeshipcurrentyear.Value >= 1 && NumApprenticeshipcurrentyear.Value <= 9)
            {
                audit = OutputService(audit, "Aktuelles Lehrjahr", NumApprenticeshipcurrentyear.Value.ToString());
            }

            if (NumApprenticeshipyears.Value >= 1 && NumApprenticeshipyears.Value <= 9)
            {
                audit = OutputService(audit, "Anzahl Lehrjahre", NumApprenticeshipyears.Value.ToString());
            }
        }

        return audit;
    }

    //Protokollieren von Änderungen bei Kunden
    private string CreateAuditTrail(Customer customerAudit)
    {
        var audit = DefaultAuditTrail(customerAudit);

        if (DrpdCusttype.SelectedIndex != -1 &&
            customerAudit.CustType != Convert.ToChar((string) DrpdCusttype.SelectedItem))
        {
            audit = OutputService(audit, "Kundentyp", customerAudit.CustType.ToString(),
                (string) DrpdCusttype.SelectedItem);
        }

        if (customerAudit.CompanyName != TxtCompanyname.Text && customerAudit.CompanyName.Length < 1)
        {
            audit = OutputService(audit, "Firmenname", TxtCompanyname.Text);
        }
        else if (customerAudit.CompanyName != TxtCompanyname.Text)
        {
            audit = OutputService(audit, "Firmenname", customerAudit.CompanyName, TxtCompanyname.Text);
        }

        if (customerAudit.FaxNumb != null)
        {
            if (customerAudit.FaxNumb != TxtFax.Text && customerAudit.FaxNumb.Length < 1)
            {
                audit = OutputService(audit, "Faxnummer", TxtFax.Text);
            }
            else if (customerAudit.FaxNumb != TxtFax.Text && customerAudit.FaxNumb.Length > 0)
            {
                audit = OutputService(audit, "Faxnummer", customerAudit.FaxNumb, TxtFax.Text);
            }
        }

        return audit;
    }

    //Protokollieren von Änderungen bei Mitarbeitern 
    private string CreateAuditTrail(Employee employeeAudit)
    {
        var audit = DefaultAuditTrail(employeeAudit);

        if (DrpdDept.SelectedIndex != -1 && employeeAudit.Department != (string) DrpdDept.SelectedItem)
        {
            audit = OutputService(audit, "Abteilung", employeeAudit.Department, (string) DrpdDept.SelectedItem);
        }

        if (employeeAudit.SocialSecurityNumber != TxtSocialsecurity.Text)
        {
            audit = OutputService(audit, "Sozialversicherungsnummer", employeeAudit.SocialSecurityNumber,
                TxtSocialsecurity.Text);
        }

        if (DrpdFunction.SelectedIndex != -1 && employeeAudit.Function != (string) DrpdFunction.SelectedItem)
        {
            audit = OutputService(audit, "Funktion", employeeAudit.Function, (string) DrpdFunction.SelectedItem);
        }

        if (employeeAudit.StartDate != DateStartDate.Value)
        {
            audit = OutputService(audit, "Startdatum", employeeAudit.StartDate.ToShortDateString(),
                DateStartDate.Value.ToShortDateString());
        }

        if (!CbEndDate.Checked && employeeAudit.LeaveDate != DateLeaveDate.Value)
        {
            audit = OutputService(audit, "Austrittsdatum");
        }
        else if (employeeAudit.LeaveDate != DateLeaveDate.Value &&
                 employeeAudit.LeaveDate == DateTime.Parse("01/01/1800"))
        {
            audit = OutputService(audit, "Austrittsdatum", DateLeaveDate.Value.ToString());
        }
        else if (employeeAudit.LeaveDate != DateLeaveDate.Value)
        {
            audit = OutputService(audit, "Austrittsdatum", employeeAudit.LeaveDate.ToShortDateString(),
                DateLeaveDate.Value.ToString());
        }

        if (employeeAudit.EmploymentPercent != NumEmploymentpercent.Value)
        {
            audit = OutputService(audit, "Beschäftigungsgrad", employeeAudit.EmploymentPercent.ToString(),
                NumEmploymentpercent.Value.ToString());
        }

        if (employeeAudit.ManagementLevel != NumMgmtLvl.Value)
        {
            audit = OutputService(audit, "Managementlevel", employeeAudit.ManagementLevel.ToString(),
                NumMgmtLvl.Value.ToString());
        }

        return audit;
    }

    //Protokollieren der Lehrjahre bei Lehrlingen
    private string CreateAuditTrail(Trainee traineeAudit)
    {
        var audit = DefaultAuditTrail(traineeAudit);
        Employee employee = traineeAudit;
        audit = CreateAuditTrail(employee) + audit;

        if (traineeAudit.CurrentYearOfTraining != NumApprenticeshipcurrentyear.Value)
        {
            audit = OutputService(audit, "Aktuelles Lehrjahr", traineeAudit.CurrentYearOfTraining.ToString(),
                NumApprenticeshipcurrentyear.Value.ToString());
        }

        if (traineeAudit.YearsOfTraining != NumApprenticeshipyears.Value)
        {
            audit = OutputService(audit, "Anzahl Lehrjahre", traineeAudit.YearsOfTraining.ToString(),
                NumApprenticeshipyears.Value.ToString());
        }

        return audit;
    }

    //Protokollieren von grundlegenden Änderungen
    private string DefaultAuditTrail(Person personAudit)
    {
        var audit = personAudit.AuditTrail;

        if (personAudit.Type != personType)
        {
            audit = OutputService(audit, "Personentyp", personAudit.Type.ToString(), personType.ToString());
        }

        if (personAudit.State != ChkState.Checked)
        {
            audit = OutputService(audit, "Status", personAudit.State.ToString(), ChkState.Checked.ToString());
        }

        if (DrpdFormOfAddress.SelectedIndex != -1 &&
            personAudit.FormOfAddress != (string) DrpdFormOfAddress.SelectedItem &&
            personAudit.FormOfAddress.Length < 1)
        {
            audit = OutputService(audit, "Titel", (string) DrpdFormOfAddress.SelectedItem);
        }
        else if (DrpdFormOfAddress.SelectedIndex != -1 &&
                 personAudit.FormOfAddress != (string) DrpdFormOfAddress.SelectedItem)
        {
            audit = OutputService(audit, "Titel", personAudit.FormOfAddress, (string) DrpdFormOfAddress.SelectedItem);
        }

        if (DrpdTitle.SelectedIndex != -1 && personAudit.Title != (string) DrpdTitle.SelectedItem &&
            personAudit.Title.Length < 1)
        {
            audit = OutputService(audit, "Anrede", (string) DrpdTitle.SelectedItem);
        }
        else if (DrpdTitle.SelectedIndex != -1 && personAudit.Title != (string) DrpdTitle.SelectedItem)
        {
            audit = OutputService(audit, "Anrede", personAudit.Title, (string) DrpdTitle.SelectedItem);
        }

        if (DrpdCountry.SelectedIndex != -1 && personAudit.Country != (string) DrpdCountry.SelectedItem &&
            personAudit.Country.Length < 1)
        {
            audit = OutputService(audit, "Land", (string) DrpdCountry.SelectedItem);
        }
        else if (DrpdCountry.SelectedIndex != -1 && personAudit.Country != (string) DrpdCountry.SelectedItem)
        {
            audit = OutputService(audit, "Land", personAudit.Country, (string) DrpdCountry.SelectedItem);
        }

        if (DrpdNationality.SelectedIndex != -1 && personAudit.Nationality != (string) DrpdNationality.SelectedItem &&
            personAudit.Nationality.Length < 1)
        {
            audit = OutputService(audit, "Nationalität", (string) DrpdNationality.SelectedItem);
        }
        else if (DrpdNationality.SelectedIndex != -1 &&
                 personAudit.Nationality != (string) DrpdNationality.SelectedItem)
        {
            audit = OutputService(audit, "Nationalität", personAudit.Nationality,
                (string) DrpdNationality.SelectedItem);
        }

        if (personAudit.FirstName != TxtName.Text)
        {
            audit = OutputService(audit, "Vorname", personAudit.FirstName, TxtName.Text);
        }

        if (personAudit.Surname != TxtSurname.Text)
        {
            audit = OutputService(audit, "Nachname", personAudit.Surname, TxtSurname.Text);
        }

        if (personAudit.Street != TxtStreet.Text && personAudit.Street.Length < 1)
        {
            audit = OutputService(audit, "Strasse", TxtStreet.Text);
        }
        else if (personAudit.Street != TxtStreet.Text)
        {
            audit = OutputService(audit, "Strasse", personAudit.Street, TxtStreet.Text);
        }

        if (personAudit.Postcode != TxtPostcode.Text && personAudit.Postcode.Length < 1)
        {
            audit = OutputService(audit, "Postleitzahl", TxtPostcode.Text);
        }
        else if (personAudit.Postcode != TxtPostcode.Text)
        {
            audit = OutputService(audit, "Postleitzahl", personAudit.Postcode, TxtPostcode.Text);
        }

        if (personAudit.City != TxtCity.Text && personAudit.City.Length < 1)
        {
            audit = OutputService(audit, "Stadt", TxtCity.Text);
        }
        else if (personAudit.City != TxtCity.Text)
        {
            audit = OutputService(audit, "Stadt", personAudit.City, TxtCity.Text);
        }

        if (personAudit.Birthday != DateBday.Value)
        {
            audit = OutputService(audit, "Geburtstag", personAudit.Birthday.ToShortDateString(),
                DateBday.Value.ToShortDateString());
        }

        if (DrpdSex.SelectedIndex != -1 && personAudit.Sex != Convert.ToChar((string) DrpdSex.SelectedItem))
        {
            audit = OutputService(audit, "Geschlecht", personAudit.Sex.ToString(), (string) DrpdSex.SelectedItem);
        }

        if (personAudit.Phone != TxtPhone.Text && personAudit.Phone.Length < 1)
        {
            audit = OutputService(audit, "Telefonnummer", TxtPhone.Text);
        }
        else if (personAudit.Phone != TxtPhone.Text)
        {
            audit = OutputService(audit, "Telefonnummer", personAudit.Phone, TxtPhone.Text);
        }

        if (personAudit.Mobile != TxtMobile.Text && personAudit.Mobile.Length < 1)
        {
            audit = OutputService(audit, "Mobiltelefonnummer", TxtMobile.Text);
        }
        else if (personAudit.Mobile != TxtMobile.Text)
        {
            audit = OutputService(audit, "Mobiltelefonnummer", personAudit.Mobile, TxtMobile.Text);
        }

        if (personAudit.Email != TxtEmail.Text)
        {
            audit = OutputService(audit, "E-Mail", personAudit.Email, TxtEmail.Text);
        }

        return audit;
    }

    //Auditausgabe wenn ein Wert angepasst wurde
    private string OutputService(string audit, string term, string oldValue, string newValue)
    {
        audit = $"{DateTime.Now.ToString()} - {term} wurde von {oldValue} zu {newValue} gewechselt.\r\n" + audit;
        return audit;
    }

    //Auditausgabe wenn ein neuer Wert eingegeben wurde
    private string OutputService(string audit, string term, string newValue)
    {
        audit = $"{DateTime.Now.ToString()} - {term} wurde als {newValue} gesetzt. \r\n" + audit;
        return audit;
    }

    //Auditausgabe wenn ein Wert gelöscht wurde  
    private string OutputService(string audit, string term)
    {
        audit = $"{DateTime.Now.ToString()} - {term} wurde entfernt. \r\n" + audit;
        return audit;
    }

    private void CmdSaveLog_Click(object sender, EventArgs e)
    {
        AddCustLog();
    }

    //Log hinzufügen
    private void AddCustLog()
    {
        if (TxtLogInput.Text.Length > 1 && userGuid.Length > 1)
        {
            var persons = Save();
            if (persons != null)
            {
                SavePersonList(persons);
            }


            var selectedPerson = dataSet.Find(person => person.Id.Equals(userGuid));


            TxtLogOutput.Text = selectedPerson.Log;
            TxtLogInput.Clear();
            InitializeControl();
        }
        else
        {
            MessageBox.Show("Bitte Text einfügen!");
        }
    }
}