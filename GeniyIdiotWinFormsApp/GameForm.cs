using GeniyIdiot.Common;
// using Microsoft.VisualBasic.ApplicationServices;
//using User = GeniyIdiotConsoleApp.User;


namespace GeniyIdiotWinFormsApp;

public partial class GameForm : Form
{
    public Game game;
    public User user;
    Question currentQuestion;
    public GameForm()
    {
        InitializeComponent();
        Timer.Start();
    }
    private void questionTextLabel_Click(object sender, EventArgs e)
    {
    }
    private void MainForm_Load_1(object sender, EventArgs e)
    {
        var s = Convert.ToInt32(10);

        ShowNextQuestion();
    }
    public void ShowNextQuestion()
    {
        Timer.Start();
        currentQuestion = game.ShowNextQuestion();
        questionTextLabel.Text = currentQuestion.Text;
        questionNumberLabel.Text = game.GetQuestionNextNumber();
    }
    private void NextButton_Click(object sender, EventArgs e)
    {
        var gotNumber = InputInspector.TryGetNumber(userAnswerTextBox.Text, out int userAnswers, out string errorMessage);
        if (!gotNumber)
        {
            MessageBox.Show(errorMessage);
        }
        else
        {
            game.CompareUserAnswer(userAnswers);
            userAnswerTextBox.Clear();
            if (game.EndGame())
            {
                var message = game.GetResultDiagnose();
                MessageBox.Show(message);
                this.Close();
                var choiceForm = new ChoiceForm();
                choiceForm.ShowDialog();
            }
            else
            {
                ShowNextQuestion();
            }
        }
    } 
    public void Timer_Tick(object sender, EventArgs e)
    {
        var h = Convert.ToInt32(0);
        var m = Convert.ToInt32(0);
        var s = Convert.ToInt32(10);
        
        label2.Text = Convert.ToString(s);
        
        s = s - 1;
        if (s == -1)
        {
            m = m - 1;
            s = 59;
        }
        if (h == 0 && m == 0 && s == 0)
        {
            Timer.Stop();
            MessageBox.Show("Время вышло!");
        }
    }
}
    
    

