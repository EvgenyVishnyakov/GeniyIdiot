using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{

    public partial class WelcomeFormGame : Form
    {
        public WelcomeFormGame()
        {
            InitializeComponent();
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
                gameForm.user = new User(name); ;
                gameForm.game = new Game(user); 
                gameForm.Show();
                //var timer = gameForm.Timer.Start();
                this.Close();
            }
        }        
    }
}
