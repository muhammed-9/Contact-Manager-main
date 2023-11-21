using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactManagerMaster2022;

namespace ContactManagerMaster2022
{

    [Serializable]
    class Customer : Person
    {

        // Properties
        private char customerType; // A - E
        private string companyName;
        private string faxNumber;

        // Constructor
        public Customer(string id, int type, bool state, string formOfAddress, string title, string nationality, string firstName, string surname, string street, string postcode, string city, string country, DateTime birthday, char sex, string phone, string mobile, string email, string log, string auditTrail, char customerType, string companyname, string faxNumber) : base(id, type, state, formOfAddress, title, nationality, firstName, surname, street, postcode, city, country, birthday, sex, phone, mobile, email, log, auditTrail)
        {
            CustType = customerType;
            CompanyName = companyname;
            FaxNumb = faxNumber;
        }

        public char CustType
        {
            get { return customerType; }
            set
            {
                value = Char.ToUpper(value);
                if (value >= 'A' && value <= 'E')
                    customerType = value;
                else
                    throw new Exception("Kundentyp ist ungültig.");
            }
        }

        public string CompanyName
        {
            get { return companyName; }
            set
            {
                if (value != null && value.Length >= 3 && base.Type == 2)
                    companyName = value;
                else if (base.Type == 1)
                    companyName = "";
                else
                    throw new Exception("Firemnname ist ungültig.");
            }
        }

        public string FaxNumb
        {
            get { return faxNumber; }
            set
            {
                if (value != null && value.Length >= 3 && base.Type == 2)
                    faxNumber = value;
                else 
                    faxNumber = "";
            }
        }

        //Überprüft ob die Daten im Objekt existieren
        public override bool SearchForData(string search)
        {
            if (companyName.ToLower().Contains(search) ||
                faxNumber.ToLower().Contains(search) ||
                base.SearchForData(search))
                return true;
            else
                return false;
        }
    }
}
