namespace GeniyIdiot.Common;

public class Game
{
    public List<Question> questions { get; set; }
    public Question currentQuestion { get; set; }
    public User User { get; set; }

    int questionsCount;
    int questionNumber = 0;

    public Game(User user)
    {
        User = user;
        questions = QuestionStorage.GetAll();
        questionsCount = questions.Count;
    }

    public Question ShowNextQuestion()
    {
        var random = new Random();
        var randomQuestion = random.Next(questions.Count);
        currentQuestion = questions[randomQuestion];

        questionNumber++;
        return currentQuestion;
    }

    public void CompareUserAnswer(int userAnswers)
    {
        var rightAnswer = currentQuestion.Answer;
        if (userAnswers == rightAnswer)
        {
            User.GetRightAnswer();
        }
        questions.Remove(currentQuestion);
    }

    public string GetQuestionNextNumber()
    {
        return "Вопрос №" + questionNumber;
    }

    public bool EndGame()
    {
        return questions.Count == 0;
    }

    public string GetResultDiagnose()
    {
        var diagnose = DiagnoseCalculate.Calculate(User.RightAnswersCount, questionsCount);
        User.Diagnoses = diagnose;
        var value = $"{User.Name}, Вы: {User.Diagnoses}, количество правильных ответов: {User.RightAnswersCount}";
        UserResultStorage.SaveUserResult(User);
        return value;
    }
}




