namespace ContactManagerMaster2022;

[Serializable]
class Trainee : Employee
{
    // Properties
    private int currentYearOfTraining;
    private int yearsOfTraining;

    // Constructor
    public Trainee(string id, int type, bool state, string formOfAddress, string title, string nationality,
        string firstName, string surname, string street, string postcode, string city, string country,
        DateTime birthday, char sex, string phone, string mobile, string email, string log, string auditTrail,
        string employeeNumber, string department, string socialSecurityNumber, string function, DateTime startDate,
        DateTime leaveDate, int employmentPercent, int managementLevel, int currentYearOfTraining, int yearsOfTraining)
        : base(id, type, state, formOfAddress, title, nationality, firstName, surname, street, postcode, city, country,
            birthday, sex, phone, mobile, email, log, auditTrail, employeeNumber, department, socialSecurityNumber,
            function, startDate, leaveDate, employmentPercent, managementLevel)
    {
        CurrentYearOfTraining = currentYearOfTraining;
        YearsOfTraining = yearsOfTraining;
    }

    public int CurrentYearOfTraining
    {
        get => currentYearOfTraining;
        set
        {
            if (value >= 1 && value <= 9)
            {
                currentYearOfTraining = value;
            }
            else
            {
                throw new Exception("Aktuelles Lehrjahr ist ungültig.");
            }
        }
    }

    public int YearsOfTraining
    {
        get => yearsOfTraining;
        set
        {
            if (value >= 1 && value <= 9)
            {
                yearsOfTraining = value;
            }
            else
            {
                throw new Exception("Anzahl Lehrjahre ist ungültig.");
            }
        }
    }

    //Überprüft ob die Daten im Objekt existieren
    public override bool SearchForData(string search)
    {
        if (currentYearOfTraining.ToString().ToLower().Contains(search) ||
            yearsOfTraining.ToString().ToLower().Contains(search) || base.SearchForData(search))
        {
            return true;
        }

        return false;
    }
}