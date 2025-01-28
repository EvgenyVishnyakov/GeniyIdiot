using Newtonsoft.Json;
namespace GeniyIdiot.Common;

public static class AdminStorage
{
    public static string Path = "password.json";

    public static Password GetPassword()
    {
        if (FileProvider.Exists(Path))
        {
            string jsonData = FileProvider.GetValue(Path);
            var adminPassword = JsonConvert.DeserializeObject<Password>(jsonData);
            return adminPassword;
        }
        else
        {
            var adminPassword = new Password("345");
            Save(adminPassword);
            return adminPassword;
        }
    }

    public static void Save(Password password)
    {
        FileProvider.Save(Path, password);
    }
}

