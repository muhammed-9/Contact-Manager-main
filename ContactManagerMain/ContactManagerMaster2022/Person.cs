using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace ContactManagerMaster2022
{
    [Serializable]
    class Person
    {

        //Eigenschaften
        private string id;
        private int type; // 1 = Privat / 2 = Firma / 3 = Angestellt / 4 = Lehrling
        private bool state; // true = aktiv
        private string formOfAddress;
        private string title;
        private string nationality;
        private string firstName;
        private string surname;
        private string street;
        private string postcode;
        private string city;
        private string country;
        private DateTime birthday;
        private char sex; // m / w / d
        private string phone;
        private string mobile;
        private string email;
        private string log;
        private string auditTrail;

        // Constructor
        public Person(string id, int type, bool state, string formOfAddress, string title, string nationality, string firstName, string surname, string street, string postcode, string city, string country, DateTime birthday, char sex, string phone, string mobile, string email, string log, string auditTrail)
        {
            Id = id;
            Type = type;
            State = state;
            FormOfAddress = formOfAddress;
            Title = title;
            Nationality = nationality;
            FirstName = firstName;
            Surname = surname;
            Street = street;
            Postcode = postcode;
            City = city;
            Country = country;
            Birthday = birthday;
            Sex = sex;
            Phone = phone;
            Mobile = mobile;
            Email = email;
            Log = log;
            AuditTrail = auditTrail;
        }

        public string Id
        {
            get { return id; }
            set
            {
                if (value != null && value.Length > 0)
                    id = value;
                else
                    id = Convert.ToString(Guid.NewGuid());
            }
        }

        public int Type
        {
            get { return type; }
            set
            {
                if (value > 0 && value < 5)
                    type = value;
                else
                    throw new Exception("Personentyp ist ungültig.");
            }
        }

        public bool State
        {
            get { return state; }
            set
            {
                state = value;
            }
        }

        public string FormOfAddress
        {
            get { return formOfAddress; }
            set
            {
                if (value != null && (value == "Herr" | value == "Frau"))
                    formOfAddress = value;
                else
                    formOfAddress = "";
            }
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (value != null && (value == "Dr." | value == "Prof." | value == "Prof. Dr."))
                    title = value;
                else
                    title = "";
            }
        }

        public string Nationality
        {
            get { return nationality; }
            set
            {
                if (value != null && value.Length >= 2)
                    nationality = value;
                else
                    nationality = "";
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value != null && value.Length >= 2)
                    firstName = value;
                else
                    throw new Exception("Vorname ist ungültig");
            }
        }

        public string Surname
        {
            get { return surname; }
            set
            {
                if (value != null && value.Length >= 2)
                    surname = value;
                else
                    throw new Exception("Nachname ist ungültig.");
            }
        }

        public string Street
        {
            get { return street; }
            set
            {
                if (value != null && value.Length >= 2)
                    street = value;
                else
                    street = "";
            }
        }

        public string Postcode
        {
            get { return postcode; }
            set
            {
                if (value != null && value.Length >= 2)
                    postcode = value;
                else
                    postcode = "";
            }
        }

        public string City
        {
            get { return city; }
            set
            {
                if (value != null && value.Length >= 2)
                    city = value;
                else
                    city = "";
            }
        }

        public string Country
        {
            get { return country; }
            set
            {
                if (value != null && value.Length >= 2)
                    country = value;
                else
                    country = "";
            }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set
            {
                if (value > DateTime.MinValue && value <= DateTime.Now)
                    birthday = value;
                else
                    throw new Exception("Geburtstagsdatum ist ungültig.");
            }
        }

        public char Sex
        {
            get { return sex; }
            set
            {
                value = Convert.ToChar(value.ToString().ToLower());
                if (value != '\0' && (value == 'm' || value == 'w' || value == 'd'))

                    sex = value;
                else
                    sex = 'd';
            }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                if (value != null && value.Length >= 3)
                    phone = value;
                else
                    phone = "";
            }
        }

        public string Mobile
        {
            get { return mobile; }
            set
            {
                if (value != null && value.Length >= 3)
                    mobile = value;
                else
                    mobile = "";
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                try
                {
                    MailAddress m = new MailAddress(value);
                    email = value.Trim();
                }
                catch (FormatException)
                {
                    throw new Exception("E-Mail Adresse ist ungültig.");
                }
            }
        }

        public string Log
        {
            get { return log; }
            set
            {
                if (value != null && value.Length >= 1)
                    log = value;
            }
        }

        public string AuditTrail
        {
            get { return auditTrail; }
            set
            {
                if (value != null && value.Length >= 1)
                    auditTrail = value;
            }
        }

        //Überprüft ob die Daten im Objekt existieren
        public virtual bool SearchForData(string search)
        {
            if (formOfAddress.ToLower().Contains(search) ||
                title.ToLower().Contains(search) ||
                firstName.ToLower().Contains(search) ||
                surname.ToLower().Contains(search) ||
                street.ToLower().Contains(search) ||
                postcode.ToLower().Contains(search) ||
                city.ToLower().Contains(search) ||
                country.ToLower().Contains(search) ||
                birthday.ToString().ToLower().Contains(search) ||
                sex.ToString().ToLower().Contains(search) ||
                phone.ToLower().Contains(search) ||
                mobile.ToLower().Contains(search) ||
                email.ToLower().Contains(search))
                return true;
            else
                return false;
        }
    }
}