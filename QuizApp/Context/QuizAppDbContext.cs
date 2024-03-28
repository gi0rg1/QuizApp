using Microsoft.EntityFrameworkCore;
using QuizApp.Models;

namespace QuizApp.Context
{
    public class QuizAppDBContext : DbContext
    {
        public QuizAppDBContext(DbContextOptions<QuizAppDBContext> options) : base(options)
        {
            
        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }
}
