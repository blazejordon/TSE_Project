namespace TSE
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void UserStats_Click(object sender, EventArgs e)
        {
            StatisticsScreen Stats = new StatisticsScreen();
            Stats.Show();
            this.Hide();
        }

        private void EndProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Signout_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            this.Hide(); //change to remove eventually maybe
        }
    }
}