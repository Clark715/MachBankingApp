using System.Net.Mail;
using MySql.Data.MySqlClient;

namespace MachBankingApp
{
    public partial class NewAccountForm : Form
    {
        // MYSQL INFO WOULD GO HERE //
        MySqlConnection connection = new MySqlConnection("datasource=0000;port=0000;Initial Catalog=0000;username=0000;password=0000");

        // REQUIRED INFORMATION CHECKS //
        private bool nameFirstStatus;
        private bool nameLastStatus;
        private bool usernameStatus;
        private bool passwordStatus;
        private bool emailStatus;
        private bool phoneStatus;

        public NewAccountForm()
        {
            InitializeComponent();
        }

        // GATHER USER INFORMATION FROM CREATE ACCOUNT FORM AND CREATE NEW ACCOUNT //
        private void ButtonCreateAccount_Click(object sender, EventArgs e)
        {
            // TO FETCH FROM USER //
            string firstname = TextboxFirstName.Text.Trim();
            string lastname = TextboxLastName.Text.Trim();
            string username = TextboxUser.Text.Trim();
            string password = TextboxPass.Text.Trim();
            string email = TextboxEmail.Text.Trim();
            string phone = TextboxPhoneNum.Text.Trim();

            // AUTO GENERATED //
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy");
            decimal accountAmount = 0;

            // CHECK ALL FIELDS //
            if (!String.IsNullOrEmpty(firstname) && firstname.All(Char.IsLetter) && firstname.Length > 1) { nameFirstStatus = true; }
            else { MessageBox.Show("Please make sure your first name contains only letters and is not blank.", "Oops!"); }

            if (!String.IsNullOrEmpty(lastname) && lastname.All(Char.IsLetter) && lastname.Length > 1) { nameLastStatus = true; }
            else { MessageBox.Show("Please make sure your last name contains only letters and is not blank.", "Oops!"); }

            if (!String.IsNullOrEmpty(username) && username.Length > 8) { usernameStatus = true; }
            else { MessageBox.Show("Please enter a username. Must be greater than 8 characters, and less than 20 characters.", "Oops!"); }

            if (!String.IsNullOrEmpty(password) && password.Length > 8) { passwordStatus = true; }
            else { MessageBox.Show("Please enter a password. Must be greater than 8 characters, and less than 20 characters.", "Oops!"); }

            if (MailAddress.TryCreate(email, out var address)) { emailStatus = true; }
            else { MessageBox.Show("Please enter a valid email address.", "Oops!"); }

            if (!String.IsNullOrEmpty(phone) && phone.All(Char.IsNumber) && phone.Length == 10) { phoneStatus = true; }
            else { MessageBox.Show("Please enter a valid 10 digit phone number. Do not include dashes.", "Oops!"); }

            // IF ALL PREREQUISITES ARE MET - UPLOAD INFORMATION //
            if (nameFirstStatus && nameLastStatus && usernameStatus && passwordStatus && emailStatus && phoneStatus)
            {
                connection.Open();

                MySqlCommand checkIfTaken = new MySqlCommand("SELECT COUNT(*) FROM logindb WHERE USERNAME = @USERNAME", connection);
                checkIfTaken.Parameters.AddWithValue("@USERNAME", username);
                int userCount = Convert.ToInt32(checkIfTaken.ExecuteScalar());
                if (userCount > 0) { MessageBox.Show("The username entered has already been taken.", "Oops!"); }
                else
                {
                    string insertQuery = "INSERT INTO logindb(FIRSTNAME, LASTNAME, USERNAME, PASSWORD, " +
                     "EMAIL, PHONE, DATE_CREATED, DATE_LAST, ACCOUNT_AMOUNT) VALUES" +
                     "('" + firstname + "','" + lastname + "','" + username + "','" + Encrypt.HashString(password) + "'," +
                     "'" + email + "','" + phone + "','" + currentDate + "','" + currentDate + "','" + accountAmount + "')";

                    MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Account Created! You may now use the login function on the main window.", "Success!");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Account could not be created.", "Error");
                    }
                    connection.Close();
                    this.Close();
                }


            }
        }
    }
}
