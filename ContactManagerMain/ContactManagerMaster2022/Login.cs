namespace ContactManagerMaster2022;

public partial class Login : Form
{
    private readonly string password = "zbw";

    // Definition Zugangsdaten
    private readonly string username = "Administrator";

    public Login()
    {
        InitializeComponent();
    }

    private void TxtPasswort_Insert(object sender, EventArgs e)
    {
        // Passworteingabe
        TxtPasswort.Text = "";
        TxtPasswort.PasswordChar = '*';
    }

    private void CmdLogin_Click(object sender, EventArgs e)
    {
        // Aufruf Anmeldung
        TryLogin();
    }

    private void TxtPasswort_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == 13)
        {
            TryLogin();
        }
    }

    private void TryLogin()
    {
        // Benutzername wird geprüft:
        if (TxtUsername.Text == username)
        {
            // Passwort wird geprüft:
            if (TxtPasswort.Text == password)
            {
                //Benutzer gibt die korrekten Logindaten ein:
                var nextForm = new Start();
                Hide();
                nextForm.ShowDialog();
                Close();
            }
            else
            {
                // Benutzer gibt ungültiges Passwort ein:
                LblLoginWrong.Text = "Anmeldung fehlgeschlagen! Passwort ungültig.";
                LblSymbolPasswort.Text = "!";
                LblSymbolBenutzer.Text = "";
                TxtPasswort.BackColor = Color.MistyRose;
                LblSymbolPasswort.BackColor = Color.MistyRose;
                TxtUsername.BackColor = Color.White;
                LblSymbolBenutzer.BackColor = Color.White;
            }
        }
        else
        {
            // Benutzer gibt keinen oder falschen Benutzernamen ein:
            LblLoginWrong.Text = "Anmeldung fehlgeschlagen! Bitte prüfen Sie den Benutzernamen.";
            LblSymbolBenutzer.Text = "!";
            LblSymbolPasswort.Text = "";
            TxtUsername.BackColor = Color.MistyRose;
            LblSymbolBenutzer.BackColor = Color.MistyRose;
            TxtPasswort.BackColor = Color.White;
        }

        // Passworteingabe löschen:
        TxtPasswort.Clear();
    }
}