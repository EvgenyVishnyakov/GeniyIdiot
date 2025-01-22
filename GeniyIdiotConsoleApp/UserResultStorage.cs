
using GeniyIdiot.Common;

namespace GeniyIdiotConsoleApp
{
    public class UserResultStorage
    {
        public static void SaveUserResult(User user)
        {
            var value = $"{user.Name}#{user.RightAnswersCount}#{user.Diagnoses}";
            FileProvider.Append("userResult.txt", value);
        }

        public static List<User> GetUserResults()
        {
            var value = FileProvider.GetValue("userResult.txt");
            var lines = value.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var results = new List<User>();

            foreach (var line in lines)
            {
                var values = line.Split('#');
                var name = values[0];
                int rightAnswersCount = Convert.ToInt32(values[1]);
                var diagnoses = values[2];

                var user = new User(name);
                user.RightAnswersCount = rightAnswersCount;
                user.Diagnoses = diagnoses;

                results.Add(user);
            }
            return results;
        }
    }
}


