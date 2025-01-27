using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp;

public partial class GameForm : Form
{
    public Game Game { get; set; }
    public User User { get; set; }
    private Question currentQuestion { get; set; }
    private System.Windows.Forms.Timer countdownTimer { get; set; }
    private int secondsRemaining { get; set; }
    private bool isTimeUp;

    public GameForm()
    {
        StartPosition = FormStartPosition.CenterScreen;
        InitializeComponent();
        InitializeCountdownTimer();
    }

    private void questionTextLabel_Click(object sender, EventArgs e)
    {
    }

    private void MainForm_Load_1(object sender, EventArgs e)
    {
        ShowNextQuestion();
    }

    private void InitializeCountdownTimer()
    {
        countdownTimer = new System.Windows.Forms.Timer();
        countdownTimer.Interval = 1000;
        countdownTimer.Tick += Timer_Tick;
        secondsRemaining = 10;
        isTimeUp = false;
    }

    public void ShowNextQuestion()
    {
        countdownTimer.Start();
        progressBar.Value = progressBar.Maximum;
        isTimeUp = false;
        currentQuestion = Game.ShowNextQuestion();
        questionTextLabel.Text = currentQuestion.Text;
        questionNumberLabel.Text = Game.GetQuestionNextNumber();
        secondsRemaining = 10;
        label2.Text = secondsRemaining.ToString();
    }

    private void NextButton_Click(object sender, EventArgs e)
    {
        var gotNumber = InputInspector.TryGetNumber(userAnswerTextBox.Text, out int userAnswers, out string errorMessage);
        if (!gotNumber)
        {
            MessageBox.Show(errorMessage);
            return;
        }
        GetGame(userAnswers);

    }

    private void GetGame(int userAnswers)
    {
        Game.CompareUserAnswer(userAnswers);
        userAnswerTextBox.Clear();
        if (Game.EndGame())
        {
            countdownTimer.Stop();
            isTimeUp = true;
            var message = Game.GetResultDiagnose();
            MessageBox.Show(message);
            var choiceForm = new ChoiceForm();
            choiceForm.ShowDialog();
            Close();
            return;
        }

        ShowNextQuestion();

    }

    public void Timer_Tick(object sender, EventArgs e)
    {
        if (secondsRemaining > 0)
        {
            secondsRemaining--;
            label2.Text = secondsRemaining.ToString();
            progressBar.Value = (int)((double)secondsRemaining / 10 * progressBar.Maximum);
            return;
        }
        if (!isTimeUp)
        {
            countdownTimer.Stop();
            isTimeUp = true;
            MessageBox.Show("Время вышло!");
            GetGame(-1);
        }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }
}



