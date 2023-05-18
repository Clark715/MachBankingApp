namespace MachBankingApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginWindow = new LoginForm();
            loginWindow.ShowDialog();
            if (loginWindow.loginSuccess)
            {
                UserDashboard userDashboard = new UserDashboard();
                userDashboard.ShowDialog();
            }
        }

        private void NewUserButton_Click(object sender, EventArgs e)
        {
            NewAccountForm newAccountForm = new NewAccountForm();
            newAccountForm.ShowDialog();
        }
    }
}