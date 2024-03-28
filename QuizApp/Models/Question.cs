namespace QuizApp.Models
{
    public class Question
    {
        public Question()
        {

        }
        public int ID { get; set; }
        public string? QuestionText { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
