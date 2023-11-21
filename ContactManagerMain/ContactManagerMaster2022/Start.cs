using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ContactManagerMaster2022
{

    public partial class Start : Form
    {
        private readonly ContactForm contactForm;
        // set filepath, personlist and dropdown value translation list
        //string filepath = @"c:\temp\contactmanager\data.data"; 
        //string folderpath = @"c:\temp\contactmanager";
        List<Person> dataSet;
        string[,] dropd_codes;
        int lineCount;

        public Start()
        {
            string filepath = ContactForm.filepath; 
            string folderpath = ContactForm.folderpath;
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            // set default values and init components
            DefineArray();
            DefineDataGrid();
            dataSet = ReadFile();
            SetNumLineLoadCount(dataSet.Count);
            FillDataGrid(dataSet);
            DropdFilter.SelectedIndex = 0;
            cbCustPriv.Checked = true;
            cbCustComp.Checked = true;
            cbEmployee.Checked = true;
            cbTrainee.Checked = true;
            // set default sorting
            DataSearchResults.Sort(DataSearchResults.Columns[3], System.ComponentModel.ListSortDirection.Ascending);
        }

        // reads file and returns list of objects
        private List<Person> ReadFile()
        {
            ContactForm.CheckFolder(ContactForm.folderpath); // checks file path

            // gets person list to new empty list
            List<Person> persons = new List<Person>();
            if (File.Exists(ContactForm.filepath))
            {
                IFormatter formatter = new BinaryFormatter();
                try
                {
                    using (Stream mystream = File.OpenRead(ContactForm.filepath))
                    {
                        persons = (List<Person>)formatter.Deserialize(mystream);
                    }
                }
                catch (Exception em)
                {
                    Console.WriteLine(em.Message);
                }
            }
            return persons;
        }

        // filters objects according to dropdown and search input
        private List<Person> FilterPersons(List<Person> persons, string search)
        {
            // creates a list of all persons matching search criteria
            List<Person> filterList = new List<Person>();
            search = search.ToLower(); // formats all to lower to make search non-case-sensitive
            if (search.Length > 0)
            {
                switch (dropd_codes.GetValue(DropdFilter.SelectedIndex, 1))
                {
                    case "firstName":
                        filterList = persons.FindAll(s => s.FirstName.ToLower().Contains(search));
                        break;
                    case "surname":
                        filterList = persons.FindAll(s => s.Surname.ToLower().Contains(search));
                        break;
                    case "phone":
                        filterList = persons.FindAll(s => s.Phone.ToLower().Contains(search));
                        break;
                    case "email":
                        filterList = persons.FindAll(s => s.Email.ToLower().Contains(search));
                        break;
                    default:
                        foreach (Person person in persons)
                        {
                            if (person.SearchForData(search))
                            {
                                filterList.Add(person);
                            }
                        }
                        break;
                }
            }
            else
            {
                filterList = persons;
            }
            return FilterType(filterList); // returns the filtered user list
        }

        // filters the given list according to type
        private List<Person> FilterType(List<Person> filterList)
        {
            // creates new empty list and only add persons matching criteria
            List<Person> filteredList = new List<Person>();
            foreach (Person person in filterList)
            {
                if (cbCustPriv.Checked && person.Type == 1)
                    filteredList.Add(person);
                else
                    if (cbCustComp.Checked && person.Type == 2)
                    filteredList.Add(person);
                else
                        if (cbEmployee.Checked && person.Type == 3)
                    filteredList.Add(person);
                else
                            if (cbTrainee.Checked && person.Type == 4)
                    filteredList.Add(person);
            }
            return filteredList; // returns filtered list
        }

        // set row limiter
        private void SetNumLineLoadCount(int count)
        {
            NumLineLoadCount.Maximum = count;
            NumLineLoadCount.Value = count;
        }


        private void DefineArray()
        {
            // defines the 2d array for assignment of dropdown to search value
            dropd_codes = new string[5, 2]
            {
            {"---","none"},
            {"Vorname","firstName"},
            {"Nachname","surname"},
            {"Telefonnummer","phone"},
            {"E-Mail-Adresse","email"}
            };

            // inits the dropdown with the needed values
            for (int i = 0; i < dropd_codes.Length / 2; i++)
            {
                DropdFilter.Items.Add(dropd_codes[i, 0]);
            }
        }

        private void DefineDataGrid()
        {
            // adds the needed columns to the datagrid
            DataSearchResults.ColumnCount = 9;
            DataSearchResults.Columns[0].Visible = false;
            DataSearchResults.Columns[0].Name = "ID";
            DataSearchResults.Columns[1].Name = "Typ";
            DataSearchResults.Columns[2].Name = "Anrede";
            DataSearchResults.Columns[3].Name = "Vorname";
            DataSearchResults.Columns[4].Name = "Nachname";
            DataSearchResults.Columns[5].Name = "Strasse";
            DataSearchResults.Columns[6].Name = "PLZ";
            DataSearchResults.Columns[7].Name = "Stadt";
            DataSearchResults.Columns[8].Name = "E-Mail";

            // add btn to last column to enable edit of row
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            DataSearchResults.Columns.Add(btn);
            btn.HeaderText = "Edit Record";
            btn.Text = "Edit";
            btn.Name = "btnEditPerson";
            btn.UseColumnTextForButtonValue = true;
        }

        // opens object in new window when button is pressed
        private void DataSearchResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // only if edit button is pressed and row is in range
            if (e.ColumnIndex == 9 && e.RowIndex >= 0 && e.RowIndex <= DataSearchResults.RowCount)
            {
                // call row to edit by providing GUID
                Form newPerson = new ContactForm(DataSearchResults.Rows[e.RowIndex].Cells[0].Value.ToString());
                // MessageBox.Show(DataSearchResults.Rows[e.RowIndex].Cells[0].Value.ToString());
                newPerson.ShowDialog();
                dataSet = ReadFile();
                SetNumLineLoadCount(dataSet.Count);
                FillDataGrid(dataSet);
            }
        }

        // fills the datagrid according to provided list
        private void FillDataGrid(List<Person> persons)
        {
            DataSearchResults.Rows.Clear();
            string[] data = new string[9];

            int count = 0;
            foreach (Person person in persons)
            {
                data[0] = person.Id;
                int typenum = person.Type;
                string typestring;
                switch (typenum)
                {
                    case 1:
                        typestring = "Privatkunde";
                        break;
                    case 2:
                        typestring = "Firmenkunde";
                        break;
                    case 3:
                        typestring = "Mitarbeiter";
                        break;
                    case 4:
                        typestring = "Auszubildender";
                        break;
                    default:
                        typestring = "k/A";
                        break;
                }
                data[1] = typestring;
                data[2] = person.FormOfAddress;
                data[3] = person.FirstName;
                data[4] = person.Surname;
                data[5] = person.Street;
                data[6] = person.Postcode;
                data[7] = person.City;
                data[8] = person.Email;
                DataSearchResults.Rows.Add(data);

                // only loads as many rows as defined in gui
                count++;
                if (count >= NumLineLoadCount.Value)
                    break;
            }
            GetCurrentStatsForDashboard();
        }

        // opens form to create new object
        private void BtnNeuerKunde_Click(object sender, EventArgs e)
        {
            Form FormController = new ContactForm("");
            FormController.ShowDialog();
            dataSet = ReadFile();
            SetNumLineLoadCount(dataSet.Count);
            FillDataGrid(dataSet);
            DataSearchResults.Sort(DataSearchResults.Columns[3], System.ComponentModel.ListSortDirection.Ascending);
        }

        // searches according to provided parameters
        private void CmdSearch_Click(object sender, EventArgs e)
        {
            FillDataGrid(FilterPersons(dataSet, TxtSearch.Text));
        }

        // searches on enter according to provided parameters
        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                FillDataGrid(FilterPersons(dataSet, TxtSearch.Text));
            }
        }

        // searches on events of various control according to provided parameters
        private void ReloadData_Event(object sender, EventArgs e)
        {
            FillDataGrid(FilterPersons(dataSet, TxtSearch.Text));
        }

        // logs user out and shows login mask
        private void CmdLogout_Click(object sender, EventArgs e)
        {
            // return to login mask
            Login nextForm = new Login();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        // gets the stats for the dashboard
        private void GetCurrentStatsForDashboard()
        {
            List<Person> statpersons = ReadFile();
            int privcust = 0;
            int busscust = 0;
            int empl = 0;
            int train = 0;
            int active = 0;
            int inactiv = 0;

            // loops trough element to get stats
            foreach (Person person in statpersons)
            {
                if (person.Type == 1)
                    privcust++;
                else if (person.Type == 2)
                    busscust++;
                else if (person.Type == 3)
                    empl++;
                else if (person.Type == 4)
                    train++;

                if (person.State)
                    active++;
                else
                    inactiv++;
            }

            lblPrivatCustomer.Text = "" + privcust;
            lblBusinessCustomer.Text = "" + busscust;
            lblEmployee.Text = "" + empl;
            lblTrainee.Text = "" + train;
            lblActive.Text = "" + active;
            lblInactive.Text = "" + inactiv;
        }

        private bool ImportCSV()
        {
            string csvFileLoc = GetCSVFileLocation(); // returns full path to file

            // calls csv reader if file exists
            if (File.Exists(csvFileLoc))
            {
                try
                {
                    return ReadCsvFile(csvFileLoc) ? true : false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
            else
                return false;
        }

        // saves file to harddisk
        private void Savefile(List<Person> persons)
        {
            IFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.Create(ContactForm.filepath))
            {
                formatter.Serialize(stream, persons);
            }
        }

        // opens explorer window to get csv file
        private string GetCSVFileLocation()
        {
            string fileloc = "";
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Select a CSV File to Import";
            openDialog.Filter = "Text Files (*.csv)| *.csv";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                fileloc = openDialog.FileName;
            }
            return fileloc;
        }

        // handles the click on the csv import button
        private void CmdCsvImport_Click(object sender, EventArgs e)
        {
            // calls functions to get and read csv file
            lineCount = 0;
            if (ImportCSV())
                if (lineCount >= 1)
                    MessageBox.Show("Der Import von " + lineCount + " Datensätzen war erfolgreich!");
                else
                    MessageBox.Show("Keine eindeutigen Datensätze gefunden!");
            else
                MessageBox.Show("Der Import ist fehlgeschlagen oder der Vorgang wurde durch den User beendet!");

            // reinits the data
            dataSet = ReadFile();
            SetNumLineLoadCount(dataSet.Count);
            FillDataGrid(dataSet);
            DropdFilter.SelectedIndex = 0;
            // set default sorting
            DataSearchResults.Sort(DataSearchResults.Columns[3], System.ComponentModel.ListSortDirection.Ascending);
        }

        // 
        private bool ReadCsvFile(String filepath)
        {
            // creates new dictionary
            List<Dictionary<String, String>> records = new List<Dictionary<String, String>>();
            bool successful = false;
            int tries = 0;

            do
            {
                try
                {
                    // sets the keys in the dictionary
                    using (BinaryReader reader = new BinaryReader(File.Open(filepath, FileMode.Open)))
                    {
                        String line;
                        String[] header;
                        line = ReadLine(reader);

                        if (line != null)
                        {
                            header = line.Split(',');
                        }
                        else
                        {
                            header = null;
                            return false;
                        }

                        // sets the values in the dictionary
                        while ((line = ReadLine(reader)) != null)
                        {
                            String[] values = line.Split(',');
                            Dictionary<String, String> record = new Dictionary<string, string>();
                            for (int i = 0; i < values.Length; i++)
                            {
                                if (i < header.Length && header != null)
                                {
                                    record.Add(header[i].Trim(), values[i].Trim());
                                }
                                else
                                {
                                    //invalid format of fields -> will be caught later
                                }
                            }

                            records.Add(record);
                        }
                    }
                    successful = true;
                }
                catch (FileNotFoundException e)
                {
                    throw new FileNotFoundException("Das File wurde nicht gefunden  " + filepath + " .");
                }
                catch (IOException e)
                {
                    tries++;
                    System.Threading.Thread.Sleep(500); // 0.5 sec
                }
                catch
                {
                    throw new Exception("Fehler in der Formatierung des CSVs!");
                }

            } while (tries < 5 && !successful);

            if (successful)
            {
                // gets the dictionary key/value assignment and writes to new object
                List<Person> templist = new List<Person>(ReadFile());
                lineCount = templist.Count;
                string templog = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" + "\r\n" + DateTime.Now.ToString() + "\r\n";
                foreach (Dictionary<string, string> tmprec in records)
                {
                    tmprec.TryGetValue("Personentyp", out string persontype);
                    tmprec.TryGetValue("Anrede", out string formofaddress);
                    tmprec.TryGetValue("Titel", out string title);
                    tmprec.TryGetValue("Nationalität", out string nationality);
                    tmprec.TryGetValue("Vorname", out string name);
                    tmprec.TryGetValue("Nachname", out string surname);
                    tmprec.TryGetValue("Strasse", out string street);
                    tmprec.TryGetValue("Plz", out string plz);
                    tmprec.TryGetValue("Ort", out string city);
                    tmprec.TryGetValue("Land", out string country);
                    tmprec.TryGetValue("Geburtsdatum", out string bday);
                    tmprec.TryGetValue("Geschlecht", out string sex);
                    tmprec.TryGetValue("Telefon", out string phone);
                    tmprec.TryGetValue("Mobile", out string mobile);
                    tmprec.TryGetValue("Email", out string email);
                    tmprec.TryGetValue("Bemerkung", out string custlog);
                    tmprec.TryGetValue("Kundentyp", out string custtype);
                    tmprec.TryGetValue("Firmenname", out string compname);
                    tmprec.TryGetValue("Faxnummer", out string fax);

                    if (custlog.Length > 0)
                        custlog = templog + custlog;

                    try
                    {
                        Customer person = new Customer("", Convert.ToInt32(persontype), true, formofaddress, title, nationality, name, surname, street, plz, city, country, DateTime.Parse(bday), Convert.ToChar(sex.Substring(0, 1)), phone, mobile, email, custlog, DateTime.Now.ToString() + " - User via CSV importiert!", Convert.ToChar(custtype.Substring(0, 1)), compname, fax);
                        if (EmailIsUnique(dataSet, email))
                        {
                            templist.Add(person);
                        }
                    }
                    catch { }
                }
                // saves the file and returns number of succesfully created rows
                Savefile(templist);
                lineCount = templist.Count - lineCount;
                return true;
            }
            else
                return false;
        }

        // reads one line of file and returns line as string
        private string ReadLine(BinaryReader reader)
        {
            var result = new StringBuilder();
            bool foundEndOfLine = false;
            char ch;
            while (!foundEndOfLine)
            {
                try
                {
                    ch = reader.ReadChar();
                }
                catch (EndOfStreamException ex)
                {
                    if (result.Length == 0) return null;
                    else break;
                }

                switch (ch)
                {
                    case '\r':
                        if (reader.PeekChar() == '\n') reader.ReadChar();
                        foundEndOfLine = true;
                        break;
                    case '\n':
                        foundEndOfLine = true;
                        break;
                    default:
                        result.Append(ch);
                        break;
                }
            }
            return result.ToString();
        }

        // checks if email is unique
        private bool EmailIsUnique(List<Person> persons, string email)
        {
            foreach (Person person in persons)
            {
                if (email.Trim() == person.Email)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
