namespace GeniyIdiotWinFormsApp;
public partial class ChoiceForm : Form
{
    public ChoiceForm()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen;
    }

    public void ChoiceForm_Load(object sender, EventArgs e)
    {
    }

    private void ShowRulesButton_MouseHover(object sender, EventArgs e)
    {
        ShowRulesButton.BackColor = Color.Gray;
    }

    private void ShowRulesButton_MouseLeave(object sender, EventArgs e)
    {
        ShowRulesButton.BackColor = Color.LightGray;
    }

    private void ShowRulesButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show($"Это шуточный тест! Не воспринимайте его буквально!" +
            "Обратите внимание, что для ответа на вопросы требуется вводить числовое выражение!" +
            " На каждый ответ Вам дается 10 секунд! Если не успеваете ответить - ответ не засчитывается!" +
                       "Для начала игры нажмите кнопку: Начать играть!");
    }

    private void StartGameButton_MouseHover(object sender, EventArgs e)
    {
        StartGameButton.BackColor = Color.Gray;
    }
    private void StartGameButton_MouseLeave(object sender, EventArgs e)
    {
        StartGameButton.BackColor = Color.LightGray;
    }
    private void StartGameButton_Click_1(object sender, EventArgs e)
    {
        WelcomeFormGame welcomeForm = new WelcomeFormGame();
        welcomeForm.Show();
        this.Hide();
    }

    private void ShowResultButton_MouseHover(object sender, EventArgs e)
    {
        ShowResultButton.BackColor = Color.Gray;
    }
    private void ShowResultButton_MouseLeave(object sender, EventArgs e)
    {
        ShowResultButton.BackColor = Color.LightGray;
    }
    private void ShowResultButton_Click(object sender, EventArgs e)
    {
        var resultsForm = new ResultsForm();
        resultsForm.ShowDialog();
    }

    private void GetAdminButton_MouseHover(object sender, EventArgs e)
    {
        GetAdminButton.BackColor = Color.Gray;
    }
    private void GetAdminButton_MouseLeave_1(object sender, EventArgs e)
    {
        GetAdminButton.BackColor = Color.LightGray;
    }
    private void GetAdminButton_Click(object sender, EventArgs e)
    {
        AdminForm adminForm = new AdminForm();
        adminForm.ShowDialog();
    }

    private void ExitGameButton_MouseHover_1(object sender, EventArgs e)
    {
        ExitGameButton.BackColor = Color.Gray;
    }
    private void ExitGameButton_MouseLeave(object sender, EventArgs e)
    {
        ExitGameButton.BackColor = Color.LightGray;
    }
    public void ExitGameButton_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
