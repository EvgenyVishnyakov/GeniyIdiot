namespace GeniyIdiot.Common;
public class Password
{
    public string AdminPassword { get; set; } = "345";

    public Password(string password)
    {
        AdminPassword = password;
    }
}