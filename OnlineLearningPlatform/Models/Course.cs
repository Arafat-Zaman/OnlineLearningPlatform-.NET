namespace OnlineLearningPlatform.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public User Instructor { get; set; }  // Navigation property to the instructor
        public List<Enrollment> Enrollments { get; set; }
        public List<Quiz> Quizzes { get; set; }
        public List<CourseMaterial> Materials { get; set; }
    }

}
