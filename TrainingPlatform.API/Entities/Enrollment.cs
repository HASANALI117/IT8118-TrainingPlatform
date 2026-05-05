namespace TrainingPlatform.API.Entities;

public enum EnrollmentStatus
{
    Enrolled,
    Confirmed,
    Attending,
    Completed,
    Dropped
}

public class Enrollment
{
    public int Id { get; set; }

    public string TraineeId { get; set; } = string.Empty;
    public ApplicationUser Trainee { get; set; } = null!;

    public int SessionId { get; set; }
    public CourseSession Session { get; set; } = null!;

    public EnrollmentStatus Status { get; set; } = EnrollmentStatus.Enrolled;
    public DateTime EnrolledAt { get; set; } = DateTime.UtcNow;

    public Assessment? Assessment { get; set; }
    public ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
