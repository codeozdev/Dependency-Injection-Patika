namespace DependencyInjection.Models;

public class Teacher : ITeacher
{
    public string FirstName { get; }
    public string LastName { get; }

    public Teacher()
    {
        FirstName = "Ali";
        LastName = "Yılmaz";
    }

    public string GetInfo()
    {
        return $"Öğretmen: {FirstName} {LastName}";
    }
}