namespace TrainingPlatform.API.Entities;

public enum AssessmentResult { Pass, Fail }

public class Assessment
{
    public int Id { get; set; }

    public int EnrollmentId { get; set; }
    public Enrollment Enrollment { get; set; } = null!;

    public AssessmentResult Result { get; set; }
    public DateTime RecordedAt { get; set; } = DateTime.UtcNow;

    public string RecordedByInstructorId { get; set; } = string.Empty;
    public ApplicationUser RecordedByInstructor { get; set; } = null!;
}
