
namespace GeniyIdiotConsoleApp
{
    public class DiagnoseCalculate
    {
        public static string CalculateDiagnose(int rightAnswersCount, int questionsCount)
        {
            var rightAnswersPercent = (double)rightAnswersCount / questionsCount * 100;

            if (rightAnswersPercent > 90)
            {
                return "гений";
            }
            if (rightAnswersPercent > 70)
            {
                return "талант";
            }
            if (rightAnswersPercent > 50)
            {
                return "нормальный";
            }
            if (rightAnswersPercent > 30)
            {
                return "дурак";
            }
            if (rightAnswersPercent > 10)
            {
                return "идиот";
            }
            return "кретин";
        }
    }
}


