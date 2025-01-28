using Newtonsoft.Json;

namespace GeniyIdiot.Common;

public static class UserResultStorage
{
    private static string Path = "UserResults.json";

    public static void SaveUserResult(User user)
    {
        var usersResults = GetUserResults();
        usersResults.Add(user);
        Save(usersResults);
    }

    public static List<User> GetUserResults()
    {
        if (!FileProvider.Exists(Path))
        {
            return new List<User>();
        }
        var fileData = FileProvider.GetValue(Path);
        var userResult = JsonConvert.DeserializeObject<List<User>>(fileData);
        return userResult;
    }

    static void Save(List<User> UserResult)
    {
        var jsonData = JsonConvert.SerializeObject(UserResult, Formatting.Indented);
        FileProvider.Write(Path, jsonData);
    }
}

