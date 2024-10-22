namespace OnlineLearningPlatform.Models
{
    public class CourseMaterial
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public Course Course { get; set; }
    }

}
