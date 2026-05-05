using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrainingPlatform.API.Entities;

namespace TrainingPlatform.API.Data;

public class TrainingPlatformDbContext : IdentityDbContext<ApplicationUser>
{
    public TrainingPlatformDbContext(DbContextOptions<TrainingPlatformDbContext> options)
        : base(options) { }

    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Course> Courses => Set<Course>();
    public DbSet<Instructor> Instructors => Set<Instructor>();
    public DbSet<Classroom> Classrooms => Set<Classroom>();
    public DbSet<CourseSession> CourseSessions => Set<CourseSession>();
    public DbSet<Enrollment> Enrollments => Set<Enrollment>();
    public DbSet<Assessment> Assessments => Set<Assessment>();
    public DbSet<CertificationTrack> CertificationTracks => Set<CertificationTrack>();
    public DbSet<CertificationTrackCourse> CertificationTrackCourses => Set<CertificationTrackCourse>();
    public DbSet<TraineeCertification> TraineeCertifications => Set<TraineeCertification>();
    public DbSet<Payment> Payments => Set<Payment>();
    public DbSet<Notification> Notifications => Set<Notification>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<CertificationTrackCourse>()
            .HasKey(ctc => new { ctc.CertificationTrackId, ctc.CourseId });

        // Self-referential prerequisite — restrict delete to avoid cascade cycles
        builder.Entity<Course>()
            .HasOne(c => c.PrerequisiteCourse)
            .WithMany()
            .HasForeignKey(c => c.PrerequisiteCourseId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Enrollment>()
            .HasOne(e => e.Trainee)
            .WithMany()
            .HasForeignKey(e => e.TraineeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Assessment>()
            .HasOne(a => a.RecordedByInstructor)
            .WithMany()
            .HasForeignKey(a => a.RecordedByInstructorId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<TraineeCertification>()
            .HasOne(tc => tc.Trainee)
            .WithMany()
            .HasForeignKey(tc => tc.TraineeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Notification>()
            .HasOne(n => n.User)
            .WithMany()
            .HasForeignKey(n => n.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Course>()
            .Property(c => c.Fee)
            .HasPrecision(10, 2);

        builder.Entity<Payment>()
            .Property(p => p.Amount)
            .HasPrecision(10, 2);
    }
}
