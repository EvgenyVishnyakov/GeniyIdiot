using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{

    public partial class WelcomeFormGame : Form
    {
        public WelcomeFormGame()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void StartUserButton_Click(object sender, EventArgs e)
        {
            var name = Convert.ToString(userNameTextBox.Text);
            if (name == string.Empty)
            {
                MessageBox.Show("Пожалуйста, обязательно введите свое имя! Попробуйте еще раз.");
            }
            else
            {
                var user = new User(name);
                GameForm gameForm = new GameForm();
                gameForm.User = new User(name); ;
                gameForm.Game = new Game(user);
                gameForm.Show();
                Close();
            }
        }
    }
}
