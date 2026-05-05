namespace TrainingPlatform.API.Entities;

public class CertificationTrackCourse
{
    public int CertificationTrackId { get; set; }
    public CertificationTrack CertificationTrack { get; set; } = null!;

    public int CourseId { get; set; }
    public Course Course { get; set; } = null!;
}
