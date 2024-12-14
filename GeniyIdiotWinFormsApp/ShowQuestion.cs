using GeniyIdiot.Common;
namespace GeniyIdiotWinFormsApp
{
    public partial class ShowQuestion : Form
    {
        public ShowQuestion()
        {
            InitializeComponent();
        }
        public void ShowQuestion_Load(object sender, EventArgs e)
        {
            var questions = QuestionStorage.GetAll();
            foreach (var question in questions)
            {
               questionsDataGridView.Rows.Add(question.Text, question.Answer);
            }        
        }       
    }
}
