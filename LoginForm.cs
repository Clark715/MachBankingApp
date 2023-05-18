using MySql.Data.MySqlClient;

namespace MachBankingApp
{
    public partial class LoginForm : Form
    {
        // MYSQL INFO WOULD GO HERE //
        MySqlConnection logincon = new MySqlConnection("datasource=0000;port=0000;Initial Catalog=0000;username=0000;password=0000");

        // LOGIN CREDENTIALS STATUS //
        public bool loginSuccess;
        private bool loginUser;
        private bool loginPass;
        private string dbUser;
        private string dbPass;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string enteredUser = TextboxUser.Text.Trim();
            string enteredPass = TextboxPassword.Text.Trim();

            logincon.Open();

            if (!String.IsNullOrEmpty(enteredUser) && !String.IsNullOrEmpty(enteredPass))
            {
                try
                {

                    // CHECK LOGIN CREDENTIALS // 
                    MySqlCommand getUser = new MySqlCommand("SELECT USERNAME FROM logindb WHERE USERNAME = @USERNAME", logincon);
                    getUser.Parameters.AddWithValue("@USERNAME", enteredUser);

                    MySqlCommand getPass = new MySqlCommand("SELECT PASSWORD FROM logindb WHERE USERNAME = @USERNAME", logincon);
                    getPass.Parameters.AddWithValue("@USERNAME", enteredUser);

                    dbUser = getUser.ExecuteScalar().ToString();
                    dbPass = getPass.ExecuteScalar().ToString();

                    if (enteredUser.Equals(dbUser)) { loginUser = true; }

                    if (Encrypt.HashString(enteredPass).Equals(dbPass)) { loginPass = true; }

                }
                catch (Exception ex) { MessageBox.Show("Incorrect username or password.", "Oops!"); }
            }

            // GATHER USER INFORMATION //
            if (loginUser && loginPass)
            {
                MySqlCommand fetchUserID = new MySqlCommand("SELECT USERID FROM logindb WHERE USERNAME = @USERNAME", logincon);
                fetchUserID.Parameters.AddWithValue("@USERNAME", enteredUser);
                CurrentUserData.userID = fetchUserID.ExecuteScalar().ToString();
                
                MySqlCommand fetchUserFirstname = new MySqlCommand("SELECT FIRSTNAME FROM logindb WHERE USERNAME = @USERNAME", logincon);
                fetchUserFirstname.Parameters.AddWithValue("@USERNAME", enteredUser);
                CurrentUserData.nameFirst = fetchUserFirstname.ExecuteScalar().ToString();

                MySqlCommand fetchUserLastname = new MySqlCommand("SELECT LASTNAME FROM logindb WHERE USERNAME = @USERNAME", logincon);
                fetchUserLastname.Parameters.AddWithValue("@USERNAME", enteredUser);
                CurrentUserData.nameLast = fetchUserLastname.ExecuteScalar().ToString();

                MySqlCommand fetchUserBalance = new MySqlCommand("SELECT ACCOUNT_AMOUNT FROM logindb WHERE USERNAME = @USERNAME", logincon);
                fetchUserBalance.Parameters.AddWithValue("@USERNAME", enteredUser);
                CurrentUserData.accountBalance = (decimal)fetchUserBalance.ExecuteScalar();

                MySqlCommand fetchLastLogin = new MySqlCommand("SELECT DATE_LAST FROM logindb WHERE USERNAME = @USERNAME", logincon);
                fetchLastLogin.Parameters.AddWithValue("@USERNAME", enteredUser);
                CurrentUserData.lastLogin = fetchLastLogin.ExecuteScalar().ToString();

                loginSuccess = true;
            }

            logincon.Close();
            this.Close();
        }
    }
}
