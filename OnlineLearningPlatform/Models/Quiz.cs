namespace OnlineLearningPlatform.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string QuestionsJson { get; set; }  // JSON-encoded questions
        public Course Course { get; set; }  // The course to which this quiz belongs
    }

}
