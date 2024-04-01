namespace QuizApp.Models
{
    public class Gamer
    {
        public int ID { get; set; }
        public int? RightAnswers { get; set; }
        public string name { get; set; }
        public List<Result> Results { get; set; }
    }
}
