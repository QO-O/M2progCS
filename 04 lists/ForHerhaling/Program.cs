using System.Data;
using System.Linq.Expressions;
using System.Text;
using System.Xml;

namespace _04_lists;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();

        double[] prijzen = new double[] { 0.99, 5.60, 10.11, 18.21 };
        string[] artiekelen = { "snoepje", "luxe broodje", "lunch menu", "sushi box" };
        Formulier[] formulieren = new Formulier[2];

        formulieren[0] = new Formulier()
        {
            Feedback = "prijzig maar lekker",
            Sterren = 5
        };

        for (int i = 0; i < prijzen.Length; i++)
        {
            Console.WriteLine(prijzen[i]);
            Console.WriteLine(artiekelen[i]);
        }
        
        foreach (Formulier formulier in formulieren)
        {
            
        }
    }

    internal void Run()
    {

    }
}
internal class Formulier
{
    internal int Sterren { get; set; }
    internal string Feedback { get; set; }
}