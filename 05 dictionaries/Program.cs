namespace _05_dictionaries;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();

        Dictionary<int, string> personeelOpNummer = new Dictionary<int, string>();

        personeelOpNummer.Add(382942, "Jim");
        personeelOpNummer.Add(789432, "Tim");

        string Jim = personeelOpNummer[382942];

        foreach (KeyValuePair<int, string> item in personeelOpNummer)
        {
            int nummer = item.Key;
            string naam = item.Value;
            Console.WriteLine(nummer + ": " + naam);
        }
    }
     internal void Run()
    {

    }
}
