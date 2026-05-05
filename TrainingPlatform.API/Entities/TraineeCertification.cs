namespace TrainingPlatform.API.Entities;

public enum CertificationStatus { InProgress, Eligible, Certified }

public class TraineeCertification
{
    public int Id { get; set; }

    public string TraineeId { get; set; } = string.Empty;
    public ApplicationUser Trainee { get; set; } = null!;

    public int CertificationTrackId { get; set; }
    public CertificationTrack CertificationTrack { get; set; } = null!;

    public CertificationStatus Status { get; set; } = CertificationStatus.InProgress;
    public string? CertRefNumber { get; set; }
    public DateTime? IssuedAt { get; set; }
}
