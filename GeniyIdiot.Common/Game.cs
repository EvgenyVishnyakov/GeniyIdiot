namespace GeniyIdiot.Common;

public class Game
{
    public List<Question> questions;
    public Question currentQuestion;
    public User user;
    int questionsCount;
    int questionNumber = 0;

    public Game(User user)
    {
        this.user = user;
        questions = QuestionStorage.GetAll();
        questionsCount = questions.Count;
    }
    public Question ShowNextQuestion()
    {
        var random = new Random();
        var randomQuestionDef = random.Next(questions.Count);
        currentQuestion = questions[randomQuestionDef];

        questionNumber++;
        return currentQuestion;
    }
    public void CompareUserAnswer(int userAnswers)
    {
        var rightAnswer = currentQuestion.Answer;
        if (userAnswers == rightAnswer)
        {
            user.GetRightAnswer();
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
        var diagnose = DiagnoseCalculate.Calculate(user.RightAnswersCount, questionsCount);
        user.Diagnoses = diagnose;
        var value = $"{user.Name}, Вы: {user.Diagnoses}, количество правильных ответов: {user.RightAnswersCount}";
        UserResultStorage.SaveUserResult(user);
        return value;
    }    
}
      

    
  
  