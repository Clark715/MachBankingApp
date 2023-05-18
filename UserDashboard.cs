using MySql.Data.MySqlClient;

namespace MachBankingApp
{
    public partial class UserDashboard : Form
    {
        // MYSQL INFO WOULD GO HERE //
        MySqlConnection dashcon = new MySqlConnection("datasource=0000;port=0000;Initial Catalog=0000;username=0000;password=0000");

        public UserDashboard()
        {
            InitializeComponent();
            SetDashInfo(CurrentUserData.nameFirst, CurrentUserData.lastLogin, CurrentUserData.accountBalance);
        }

        // FETCH USER INFO FOR DISPLAY IN DASHBOARD //
        private void SetDashInfo(string firstName, string lastDate, decimal accountBalance)
        {
            dashLabelGreeting.Text = $"Hello, {firstName}!";
            dashLabelLastLogin.Text = $"Last logged in: {lastDate}";
            textboxbalance.Text = String.Format("{0:C2}", accountBalance);
        }

        // OPEN DEPOSIT WINDOW - WHEN COMPLETE UPDATE DISPLAY //
        private void dashButtonDeposit_Click(object sender, EventArgs e)
        {
            DepositFormWindow depositFormWindow = new DepositFormWindow();
            depositFormWindow.ShowDialog();
            textboxbalance.Text = String.Format("{0:C2}", CurrentUserData.accountBalance);
        }

        // OPEN WITHDRAW WINDOW - WHEN COMPLETE UPDATE DISPLAY //
        private void dashButtonWithdraw_Click(object sender, EventArgs e)
        {
            WithdrawFormWindow withdrawFormWindow = new WithdrawFormWindow();
            withdrawFormWindow.ShowDialog();
            textboxbalance.Text = String.Format("{0:C2}", CurrentUserData.accountBalance);
        }

        // LOGOUT OF APP - UPDATE DB WITH LAST LOGIN INFO //
        private void dashButtonSignout_Click(object sender, EventArgs e)
        {
            dashcon.Open();
            MySqlCommand updateLastLogin = new MySqlCommand($"UPDATE logindb SET DATE_LAST = '{DateTime.Now.ToString("MM/dd/yyyy")}' WHERE USERID = @USERID", dashcon);
            updateLastLogin.Parameters.AddWithValue("@USERID", CurrentUserData.userID);
            if (updateLastLogin.ExecuteNonQuery() == 1) { MessageBox.Show("Successfully signed out.", "Success"); }
            else { MessageBox.Show("Something went wrong. Please check your connection and try again.", "Oops!"); }
            dashcon.Close();
            this.Close();
        }
    }
}
