using Newtonsoft.Json;
namespace GeniyIdiot.Common;

public static class AdminStorage
{
    public static string Path = "password.json";

    public static void SavePassword(Password password)
    {
        var value = GetPassword();
        value.Add(password);
        Save(value);
    }

    public static List<Password> GetPassword()
    {
        var passwords = new List<Password>();
        if (FileProvider.Exists(Path))
        {
            string jsonData = FileProvider.GetValue(Path);
            passwords = JsonConvert.DeserializeObject<List<Password>>(jsonData);
        }
        else
        {
            passwords.Add(new Password("345"));
            Save(passwords);
        }
        return passwords;
    }

    public static void Save(List<Password> passwords)
    {
        var jsonData = JsonConvert.SerializeObject(passwords, Formatting.Indented);
        FileProvider.Replace(Path, jsonData);
    }
}

