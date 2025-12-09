namespace _03_constructors;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();}

        internal void Run()
    {
        QuizVraag quizVraag = new QuizVraag("Hier komt de vraag", "Hier komt het antwoord");

        Quiz quiz = new Quiz(10);
        quiz.VoegVraagToeOpIndex(0, quizVraag);
        quiz.VoegVraagToeOpIndex(1, "vraag","antwoord");
        quiz.VoegVraagToeOpIndex(2, quizVraag);
        quiz.VoegVraagToeOpIndex(3, "vraag","antwoord");
        quiz.VoegVraagToeOpIndex(4, quizVraag);
        quiz.VoegVraagToeOpIndex(5, "vraag","antwoord");
        quiz.VoegVraagToeOpIndex(6, quizVraag);
        quiz.VoegVraagToeOpIndex(7, "vraag","antwoord");
        quiz.VoegVraagToeOpIndex(8, quizVraag);
        quiz.VoegVraagToeOpIndex(9, "vraag","antwoord");

        string correctAnswer = "The egg.";

        Console.WriteLine("Which came first, chicken or the egg?");
        string userAnswer = Console.ReadLine();

        if (userAnswer == correctAnswer)
        {
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Incorrect. Eggs predate birds.");
        }
}
    }