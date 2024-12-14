
namespace GeniyIdiot.Common;

public class User
{
    public string Name ;
    public int RightAnswersCount;
    public string Diagnoses;  
    public User(string name)
    {
        Name = name;
    }    
    public void GetRightAnswer()
    {
        RightAnswersCount++;
    }
}
