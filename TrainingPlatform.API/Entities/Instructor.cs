namespace TrainingPlatform.API.Entities;

public class Instructor
{
    public int Id { get; set; }
    public string UserId { get; set; } = string.Empty;
    public ApplicationUser User { get; set; } = null!;
    public string ExpertiseAreas { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
    public ICollection<CourseSession> Sessions { get; set; } = new List<CourseSession>();
}
