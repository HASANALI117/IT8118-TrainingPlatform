namespace TrainingPlatform.API.Entities;

public class Classroom
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Capacity { get; set; }
    public string Equipment { get; set; } = string.Empty;
    public ICollection<CourseSession> Sessions { get; set; } = new List<CourseSession>();
}
