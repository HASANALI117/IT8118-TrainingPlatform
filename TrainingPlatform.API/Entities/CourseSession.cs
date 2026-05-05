namespace TrainingPlatform.API.Entities;

public class CourseSession
{
    public int Id { get; set; }

    public int CourseId { get; set; }
    public Course Course { get; set; } = null!;

    public int InstructorId { get; set; }
    public Instructor Instructor { get; set; } = null!;

    public int ClassroomId { get; set; }
    public Classroom Classroom { get; set; } = null!;

    public DateOnly SessionDate { get; set; }
    public TimeOnly StartTime { get; set; }
    public int AvailableSpots { get; set; }

    public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}
