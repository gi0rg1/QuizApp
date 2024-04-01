namespace QuizApp.Models
{
    public class Results
    {
        public int ID { get; set; }
        public bool? IsCorrect { get; set; }
        public int AnswerID { get; set; }
        public int GamerID { get; set; }
    }
}
