namespace _06_fileio;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();

        Console.WriteLine(Environment.CurrentDirectory);
    }

     internal void Run()
    {
        string[] lines = File.ReadAllLines("quiz.txt");
    }
}
