namespace TrainingPlatform.API.Entities;

public class CertificationTrack
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public ICollection<CertificationTrackCourse> TrackCourses { get; set; } = new List<CertificationTrackCourse>();
    public ICollection<TraineeCertification> TraineeCertifications { get; set; } = new List<TraineeCertification>();
}
