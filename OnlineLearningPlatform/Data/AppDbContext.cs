namespace OnlineLearningPlatform.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<CourseMaterial> CourseMaterials { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(u => u.Enrollments).WithOne(e => e.Student);
            modelBuilder.Entity<Course>().HasMany(c => c.Enrollments).WithOne(e => e.Course);
            modelBuilder.Entity<Course>().HasMany(c => c.Quizzes).WithOne(q => q.Course);
            modelBuilder.Entity<Course>().HasMany(c => c.Materials).WithOne(m => m.Course);
        }
    }

}
