namespace DependencyInjection.Models;

public class ClassRoom(ITeacher teacher)
{
    public string GetTeacherInfo()
    {
        return teacher.GetInfo();
    }
}