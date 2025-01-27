using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class AddQuestionForm : Form
    {
        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void AddButton_MouseHover(object sender, EventArgs e)
        {
            addButton.BackColor = Color.Gray;
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            addButton.BackColor = Color.LightGray;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var number = InputInspector.TryGetNumber(answerTextBox.Text, out int userAnswers, out string errorMessage);

            if (!number)
            {
                MessageBox.Show(errorMessage);
            }

            var newQuestion = new Question(questionTextBox.Text, userAnswers);
            QuestionStorage.Add(newQuestion);

            Close();
        }
    }
}
