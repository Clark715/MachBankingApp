using MySql.Data.MySqlClient;

namespace MachBankingApp
{
    public partial class WithdrawFormWindow : Form
    {
        // MYSQL INFO WOULD GO HERE //
        MySqlConnection withcon = new MySqlConnection("datasource=0000;port=0000;Initial Catalog=0000;username=0000;password=0000");

        public WithdrawFormWindow()
        {
            InitializeComponent();
        }

        // CHECK FOR VALID INPUT AND UPDATE DB TO NEW AMOUNT //
        private void withdrawSubmit_Click(object sender, EventArgs e)
        {
            decimal withdrawAmount = 0;

            try
            {
                bool checkInput = decimal.TryParse(textboxWithdraw.Text, out withdrawAmount);
                if (checkInput)
                {
                    withcon.Open();
                    CurrentUserData.accountBalance = CurrentUserData.accountBalance - withdrawAmount;
                    MySqlCommand withdraw = new MySqlCommand($"UPDATE logindb SET ACCOUNT_AMOUNT = '{CurrentUserData.accountBalance}' WHERE USERID = @USERID", withcon);
                    withdraw.Parameters.AddWithValue("@USERID", CurrentUserData.userID);
                    if (withdraw.ExecuteNonQuery() == 1) { MessageBox.Show("Withdrawal Successful!", "Success"); }
                    else { MessageBox.Show("Something went wrong. Please check your connection and try again.", "Oops!"); }
                    withcon.Close();
                    this.Close();
                }
                else { MessageBox.Show("Please make sure the withdraw field is not blank and contains only numbers and decimals.", "Oops!"); }
            }
            catch (Exception ex) { MessageBox.Show("Please make sure the withdraw field is not blank and contains only numbers or decimals.", "Oops!"); }
        }

        private void withdrawCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
