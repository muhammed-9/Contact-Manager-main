using System.Text.RegularExpressions;

namespace ContactManagerMaster2022;

[Serializable]
class Employee : Person
{
    private string department;
    private string employeeNumber;
    private int employmentPercent;

    private string filepath = @"c:\temp\contactmanager\employeeNumber.txt";

    private string socialSecurityNumber;

    private string function;
    private DateTime leaveDate;
    private int managementLevel;
    private DateTime startDate;

    private List<string> validDepartment = new()
    {
        "IT",
        "HR",
        "Technik",
        "Verkauf",
        "Geschäftsleitung",
        "Payroll"
    };

    // Constructor
    public Employee(string id, int type, bool state, string formOfAddress, string title, string nationality,
        string firstName, string surname, string street, string postcode, string city, string country,
        DateTime birthday, char sex, string phone, string mobile, string email, string log, string auditTrail,
        string employeeNumber, string department, string socialSecurityNumber, string function, DateTime startDate,
        DateTime leaveDate, int employmentPercent, int managementLevel) : base(id, type, state, formOfAddress, title,
        nationality, firstName, surname, street, postcode, city, country, birthday, sex, phone, mobile, email, log,
        auditTrail)
    {
        SocialSecurityNumber = socialSecurityNumber;
        EmployeeNumber = employeeNumber;
        Department = department;
        Function = function;
        StartDate = startDate;
        LeaveDate = leaveDate;
        EmploymentPercent = employmentPercent;
        ManagementLevel = managementLevel;
    }

    public string EmployeeNumber
    {
        get => employeeNumber;
        set
        {
            if (value != null && value.Length > 0)
            {
                employeeNumber = value;
            }
            else
            {
                employeeNumber = GetNextEmployeeNumber();
            }
        }
    }

    public string Department
    {
        get => department;
        set
        {
            if (validDepartment.Contains(value))
            {
                department = value;
            }
            else
            {
                throw new Exception("Abteilung ungültig!");
            }
        }
    }

    public string SocialSecurityNumber
    {
        get => socialSecurityNumber;
        set => socialSecurityNumber = value;
    }

    public string Function
    {
        get => function;
        set
        {
            if (value != null && value.Length >= 2)
            {
                function = value;
            }
            else
            {
                throw new Exception("Funktion ungültig!");
            }
        }
    }

    public DateTime StartDate
    {
        get => startDate;
        set
        {
            if (value > DateTime.MinValue && value <= DateTime.MaxValue && value != DateTime.Parse("01/01/1800"))
            {
                startDate = value;
            }
            else
            {
                throw new Exception("Startdatum ungültig!");
            }
        }
    }

    public DateTime LeaveDate
    {
        get => leaveDate;
        set
        {
            if (value > DateTime.MinValue && value <= DateTime.MaxValue && value > StartDate)
            {
                leaveDate = value;
            }
            else
            {
                leaveDate = DateTime.Parse("01/01/1800");
            }
        }
    }

    public int EmploymentPercent
    {
        get => employmentPercent;
        set
        {
            if (value >= 0 && value <= 100)
            {
                employmentPercent = value;
            }
            else
            {
                throw new Exception("Beschäftigungsgrad ungültig!");
            }
        }
    }

    public int ManagementLevel
    {
        get => managementLevel;
        set
        {
            if (value >= 0 && value <= 5)
            {
                managementLevel = value;
            }
            else
            {
                throw new Exception("Kaderstufe ungültig!");
            }
        }
    }

    private string GetNextEmployeeNumber()
    {
        string newNumber;
        if (File.Exists(filepath))
        {
            newNumber = File.ReadAllText(filepath);
        }
        else
        {
            newNumber = "1";
        }

        File.WriteAllText(filepath, Convert.ToString(Convert.ToInt32(newNumber) + 1));
        return newNumber;
    }

    //Überprüft ob die Daten im Objekt existieren
    public override bool SearchForData(string search)
    {
        if (employeeNumber.ToLower().Contains(search) || department.ToLower().Contains(search) ||
            socialSecurityNumber.ToLower().Contains(search) || function.ToLower().Contains(search) ||
            startDate.ToString().ToLower().Contains(search) || leaveDate.ToString().ToLower().Contains(search) ||
            employmentPercent.ToString().ToLower().Contains(search) ||
            managementLevel.ToString().ToLower().Contains(search) || base.SearchForData(search))
        {
            return true;
        }

        return false;
    }
}