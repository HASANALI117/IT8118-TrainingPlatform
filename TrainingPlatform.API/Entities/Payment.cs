namespace TrainingPlatform.API.Entities;

public class Payment
{
    public int Id { get; set; }

    public int EnrollmentId { get; set; }
    public Enrollment Enrollment { get; set; } = null!;

    public decimal Amount { get; set; }
    public DateTime PaidAt { get; set; } = DateTime.UtcNow;
    public bool IsPartial { get; set; }
}
