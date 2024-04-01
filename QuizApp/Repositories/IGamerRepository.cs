using QuizApp.Models;

namespace QuizApp.Repositories
{
    public interface IGamerRepository
    {
        public Gamer AddGamer(Gamer gamer);
        public Gamer UpdateGame();
    }
}
