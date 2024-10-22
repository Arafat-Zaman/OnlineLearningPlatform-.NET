namespace OnlineLearningPlatform.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public User Student { get; set; }
        public Course Course { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public bool Completed { get; set; }
    }

}
