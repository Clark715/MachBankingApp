using MySql.Data.MySqlClient;

namespace MachBankingApp
{
    public partial class DepositFormWindow : Form
    {
        // MYSQL INFO WOULD GO HERE //
        MySqlConnection depcon = new MySqlConnection("datasource=0000;port=0000;Initial Catalog=0000;username=0000;password=0000");

        public DepositFormWindow()
        {
            InitializeComponent();
        }

        // CHECK FOR VALID INPUT AND UPDATE DB TO NEW AMOUNT //
        private void depositSubmit_Click(object sender, EventArgs e)
        {
            decimal depositAmount = 0;

            try
            {
                bool checkInput = decimal.TryParse(textboxDeposit.Text, out depositAmount);
                if (checkInput)
                {
                    depcon.Open();
                    CurrentUserData.accountBalance = CurrentUserData.accountBalance + depositAmount;
                    MySqlCommand deposit = new MySqlCommand($"UPDATE logindb SET ACCOUNT_AMOUNT = '{CurrentUserData.accountBalance}' WHERE USERID = @USERID", depcon);
                    deposit.Parameters.AddWithValue("@USERID", CurrentUserData.userID);
                    if (deposit.ExecuteNonQuery() == 1) { MessageBox.Show("Deposit Successful!", "Success"); }
                    else { MessageBox.Show("Something went wrong. Please check your connection and try again.", "Oops!"); }
                    depcon.Close();
                    this.Close();
                }
                else { MessageBox.Show("Please make sure the deposit field is not blank and contains only numbers and decimals.", "Oops!"); }
            }
            catch (Exception ex) { MessageBox.Show("Please make sure the deposit field is not blank and contains only numbers or decimals.", "Oops!"); } 
        }

        private void depositCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
