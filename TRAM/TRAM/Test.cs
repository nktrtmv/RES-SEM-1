using System.ComponentModel.DataAnnotations;

namespace TRAM;

/// <summary>
/// Объект тест с заданиями и ответами и информацией о тесте.
/// </summary>
[Serializable]
public class Test
{
    [Key]
    public int Id { get; set; }
    
    public Guid StudentId { get; set; }
    public List<string>? StudentAnswers { get; set; }
    public List<string>? TestTasks { get; set; }
    public List<string>? TestAnswers { get; set; }
    public List<string>? TestThemes { get; set; }
    public Subjects Subject { get; set; }
    public int Level { get; set; }

    public Test(List<string> testTasks, List<string> testAnswers, List<string> testThemes,List<string> studentAnswers, Subjects subject, int level)
    {
        StudentAnswers = studentAnswers;
        TestTasks = testTasks;
        TestAnswers = testAnswers;
        TestThemes = testThemes;
        Subject = subject;
        Level = level;
    }

    public Test(List<string> testTasks, List<string> testAnswers, List<string> testThemes)
    {
        TestTasks = testTasks;
        TestAnswers = testAnswers;
        TestThemes = testThemes;
    }

    public Test(Student student)
    {
        StudentId = student.Id;
        TestTasks = student.StudTest.TestTasks;
        TestThemes = student.StudTest.TestThemes;
        TestAnswers = student.StudTest.TestAnswers;
        StudentAnswers = new List<string>();
        Subject = student.StudTest.Subject;
        Level = student.StudTest.Level;
    }

    public Test() {}
}