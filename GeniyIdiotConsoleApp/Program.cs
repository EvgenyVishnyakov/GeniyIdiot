
using GeniyIdiot.Common;

namespace GeniyIdiotConsoleApp;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Добрый день! Как Ваше имя?");

        var name = Console.ReadLine();
        var user = new User(name);
        var game = new Game(user);

        ShowGameRules();
        Countdown(5);

        while (true)
        {

            while (!game.EndGame())
            {
                var initialLeft = Console.CursorLeft;
                var initialTop = Console.CursorTop;
                var currentQuestion = game.ShowNextQuestion();
                Console.WriteLine(game.GetQuestionNextNumber());

                Console.WriteLine(currentQuestion.Text);
                Console.SetCursorPosition(initialLeft, initialTop + 2);
                Console.Write("Введите ответ: ");

                var userAnswers = GetNumber();
                game.CompareUserAnswer(userAnswers);
            }
            var message = game.GetResultDiagnose();
            Console.WriteLine(message);
            Console.WriteLine($"{name}, желаете посмотреть результаты игр");
            ShowUserResults(name);

            Console.WriteLine("Если вы админ, можно корректировать список вопросов. А вы админ?");
            GetConfirmAdmin(name);

            Console.WriteLine($"{name}, желаете повторить игру?");
            if (!GetConfirm())
            {
                break;

            }
        }
        Console.Write($"{name}, ждем Вас снова. Успехов!");
        Console.ReadKey();
    }

    public static void ShowGameRules()
    {
        Console.WriteLine("Начинаем наш тест!");
        Console.WriteLine("Обратите внимание, что для ответа на вопросы требуется вводить числовое выражение!");
        Console.WriteLine("Приготовьтесь к старту программы! Начинаем через несколько секунд!");
        Console.WriteLine("Пожалуйста, ничего не нажимайте до старта программы!");
        Console.WriteLine();
    }

    public static int GetNumber()
    {
        var number = 0;
        while (!InputInspector.TryGetNumber(Console.ReadLine(), out number, out string errorMessage))
        {
            Console.WriteLine(errorMessage);
            var initialLeft = Console.CursorLeft;
            var initialTop = Console.CursorTop;
            Console.SetCursorPosition(initialLeft, initialTop);
            Console.Write("Итак, Ваш ответ: ");
        }
        return number;
    }

    public static bool GetConfirm()
    {
        Console.WriteLine("При положительном ответе - введите да, при отрицательном - любую клавишу");
        var confirm = Console.ReadLine().ToLower();
        return confirm == "да";
    }

    private static void ShowUserResults(string name)
    {
        var isShowResults = GetConfirm();
        if (isShowResults)
        {
            var results = UserResultStorage.GetUserResults();
            Console.WriteLine($"        Таблица текущих результатов");
            Console.WriteLine("{0,5}{1,25}{2,16}", "Имя", "Правильных ответов", "Диагноз");
            foreach (var user in results)
            {
                Console.WriteLine("{0,8}{1,15}{2,22}", user.Name, user.RightAnswersCount, user.Diagnoses);
            }
        }
    }

    private static void GetConfirmAdmin(string name)
    {
        var confirmOwner = GetConfirm();
        if (confirmOwner)
        {
            bool isGetAdmin = GetAdmin(name);
            if (isGetAdmin)
            {
                Console.WriteLine($"{name}, желаете добавить новый вопрос?");
                var isShowResults = GetConfirm();
                if (isShowResults)
                {
                    AddNewQuestion();
                }
                else
                {
                    Console.WriteLine($"{name}, желаете удалить существующий вопрос?");
                    var isShowResultsRemove = GetConfirm();
                    if (isShowResultsRemove)
                    {
                        RemoveQuestion();
                    }
                }
            }
        }
    }

    private static void RemoveQuestion()
    {
        Console.WriteLine("Введите номер вопроса, который хотите удалить");
        var questions = QuestionStorage.GetAll();
        for (int i = 0; i < questions.Count; i++)
        {
            Console.WriteLine($"{i + 1} . {questions[i].Text}");
        }
        var removeQuestionIndex = GetNumber();
        while (removeQuestionIndex < 1 || removeQuestionIndex > questions.Count)
        {
            Console.WriteLine($"Введите корректное число от 1 до {questions.Count}.");
            removeQuestionIndex = GetNumber();
        }
        var removeQuestion = questions[removeQuestionIndex - 1];
        QuestionStorage.Remove(removeQuestion);
    }

    private static void AddNewQuestion()
    {
        Console.WriteLine("Введите текст вопроса");
        var text = Console.ReadLine();
        Console.WriteLine("Введите ответ на вопрос");
        var answer = GetNumber();

        var newQuestion = new Question(text, answer);

        QuestionStorage.Add(newQuestion);
    }

    public static bool GetAdmin(string name)
    {
        var amountChoice = 3;
        var password = "345";

        Console.WriteLine("Введите пароль - подтвердите права администратора. У вас три попытки");
        while (amountChoice > 0)
        {
            amountChoice--;
            var userAdmin = Console.ReadLine();
            if (amountChoice == 0)
            {
                Console.WriteLine("Вы не администратор");
                break;
            }
            if (userAdmin == password)
            {
                Console.WriteLine("Введен верный пароль.Доступ открыт.");
                break;
            }
            if (userAdmin != password || amountChoice > 0)
            {
                Console.WriteLine($"Введен неверный пароль. У вас осталось {amountChoice} попытки");
                continue;
            }
        }
        if (amountChoice > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static void Countdown(int seconds)
    {
        int initialLeft = Console.CursorLeft;
        int initialTop = Console.CursorTop;

        while (seconds > 0)
        {
            Console.SetCursorPosition(initialLeft, initialTop);
            Console.Write($"Осталось {seconds} секунд... ");
            Thread.Sleep(1000); // Пауза на 1 секунду
            seconds--;
        }
        Console.SetCursorPosition(initialLeft, initialTop);
        Console.WriteLine("Начинаем!          ");
    }
}



