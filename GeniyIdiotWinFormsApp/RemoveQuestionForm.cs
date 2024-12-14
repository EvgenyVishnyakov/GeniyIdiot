using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class RemoveQuestionForm : Form
    {      
        public RemoveQuestionForm()
        {
            InitializeComponent();
        }
        private void RemoveQuestionForm_Load(object sender, EventArgs e)
        {
            var questions = QuestionStorage.GetAll();
            foreach (var question in questions)
            {
                questionsDataGridView.Rows.Add(question.Text, question.Answer);
            }
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var valueQuestion = questionsDataGridView.SelectedRows;
            if (valueQuestion.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления");
                return;                  
            }
            var questionsText = valueQuestion[0].Cells[0].Value.ToString();
            if(questionsText != null)
            {
                QuestionStorage.RemoveForm(questionsText);
            }
            Close();
        }
    }
}
