namespace _03_constructors;

class Quiz
{
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] ingevuldeAntwoorden;

    internal void stelVraag(int index)
    {
        QuizVraag vraag = vragen[index];
        QuizVraagAntwoord quizVraagAntwoord = new QuizVraagAntwoord(vraag);
        ingevuldeAntwoorden[index] = quizVraagAntwoord;
    }
    
    internal Quiz(int aantalVragen)
    {
        vragen = new QuizVraag[aantalVragen];
        ingevuldeAntwoorden = new QuizVraagAntwoord[aantalVragen];
    }

    internal void VoegVraagToeOpIndex(int index, QuizVraag vraag)
    {
        vragen[index] = vraag;
    }

     internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
    {
        QuizVraag qVraag = new QuizVraag(vraag, antwoord);
        vragen[index] = qVraag;
    }
}