using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class AdminForm : Form
    {
        int amountChoice = 3;
        public Password adminPassword { get; set; }

        public AdminForm()
        {
            InitializeComponent();
        }

        private void ConformPasswordButton_MouseHover(object sender, EventArgs e)
        {
            ConformPasswordButton.BackColor = Color.Gray;
        }

        private void ConformPasswordButton_MouseLeave(object sender, EventArgs e)
        {
            ConformPasswordButton.BackColor = Color.LightGray;
        }

        public void ConformPasswordButton_Click(object sender, EventArgs e)
        {
            var input = Convert.ToString(UserPasswordTextBox.Text);
            var confirmAdmin = InputInspector.TryGetPassword(input);
            if (!confirmAdmin && amountChoice > 1)
            {
                amountChoice--;
                MessageBox.Show($"Введен неверный пароль. Осталось попыток: {amountChoice}");
                UserPasswordTextBox.Clear();
            }
            else if (confirmAdmin && amountChoice >= 1)
            {
                MessageBox.Show("Введен верный пароль.Доступ открыт.");
                var questionsAnswers = new QuestionAnswerForm();
                questionsAnswers.ShowDialog();
                UserPasswordTextBox.Enabled = false;
                Close();
            }
            else
            {
                MessageBox.Show("Вы не администратор");
                Close();
            }
        }
    }
}

