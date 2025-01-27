
namespace GeniyIdiot.Common;

public class User
{
    public string Name { get; set; }
    public int RightAnswersCount { get; set; }
    public string Diagnoses { get; set; }

    public User(string name)
    {
        Name = name;
    }
    public void GetRightAnswer()
    {
        RightAnswersCount++;
    }
}
