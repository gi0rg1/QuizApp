namespace QuizApp.Models
{
    public class Answer
    {
        public Answer() 
        { 

        } 
        public int ID { get; set; }
        public string? AnswerText { get; set; }
        public bool? IsCorrect { get; set; }
        public int QuestionID { get; set; }
    }
}
