using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class QuestionAnswerForm : Form
    {
        public Password adminPassword;
        public QuestionAnswerForm(Password adminPassword)
        {
            this.adminPassword = adminPassword;
            InitializeComponent();
        }
        private void ShowQuestionsButton_MouseHover(object sender, EventArgs e)
        {
            ShowQuestionsButton.BackColor = Color.Gray;
        }
        private void ShowQuestionsButton_MouseLeave(object sender, EventArgs e)
        {
            ShowQuestionsButton.BackColor = Color.LightGray;
        }
        private void ShowQuestionsButton_Click(object sender, EventArgs e)
        {
            var showQuestion = new ShowQuestion();
            showQuestion.ShowDialog();
        }

        private void AddQuestionButton_MouseHover(object sender, EventArgs e)
        {
            AddQuestionButton.BackColor = Color.Gray;
        }
        private void AddQuestionButton_MouseLeave(object sender, EventArgs e)
        {
            AddQuestionButton.BackColor = Color.LightGray;
        }
        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            var addQuestionForm = new AddQuestionForm();
            addQuestionForm.ShowDialog();
        }

        private void RemoveQuestionButton_MouseHover(object sender, EventArgs e)
        {
            RemoveQuestionButton.BackColor = Color.Gray;
        }
        private void RemoveQuestionButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveQuestionButton.BackColor = Color.LightGray;
        }
        private void RemoveQuestionButton_Click(object sender, EventArgs e)
        {
            var removeQuestionForm = new RemoveQuestionForm();
            removeQuestionForm.ShowDialog();
        }

        private void changePasswordButton_MouseHover(object sender, EventArgs e)
        {
            changePasswordButton.BackColor = Color.Gray;
        }
        private void changePasswordButton_MouseLeave(object sender, EventArgs e)
        {
            changePasswordButton.BackColor = Color.LightGray;
        }
        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            СhangePasswordForm changePasswordForm = new СhangePasswordForm();
            changePasswordForm.ShowDialog();
        }
    }
}
