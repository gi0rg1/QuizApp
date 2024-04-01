using QuizApp.Context;
using QuizApp.Models;

namespace QuizApp.Repositories
{
    public class GamerRepository
    {
        private readonly QuizAppDBContext _context;
        public GamerRepository(QuizAppDBContext context)
        {
            _context = context;
        }
        //public List<Question> GetQuestions()
        //{
        //    return _context.Questions.Include("Answers").ToList();
        //}

        public Gamer AddGamer(Gamer gamer)
        {
            _context.Gamers.Add(gamer);
            _context.SaveChanges();
            return gamer;
        }

        public Question Updategame()
        {
            return null;
        }
    }
}
