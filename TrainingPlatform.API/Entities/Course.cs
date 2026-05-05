namespace TrainingPlatform.API.Entities;

public class Course
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int DurationHours { get; set; }
    public int Capacity { get; set; }
    public decimal Fee { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    public int? PrerequisiteCourseId { get; set; }
    public Course? PrerequisiteCourse { get; set; }

    public ICollection<CourseSession> Sessions { get; set; } = new List<CourseSession>();
    public ICollection<CertificationTrackCourse> CertificationTrackCourses { get; set; } = new List<CertificationTrackCourse>();
}
