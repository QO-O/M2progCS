namespace memsave;

class Program
{
    string saveFile = "welkomState.txt";

   static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }


     internal void Run()
    {
       string welkomstTekst = "HelloWorld";

        while (true)
        {
            Console.WriteLine(welkomstTekst);
            Console.WriteLine("Enter a text, and then press enter.");
            string? str =Console.ReadLine(); //this was done by Javascript teacher
            if(str == "a")
            {
                break;
            }
        }
        bool bestaatDeFile = File.Exists(saveFile);

        if(bestaatDeFile == true)
        {
            string lines = File.ReadAllText("welkomState.txt");
        };
        if (!string.IsNullOrEmpty(saveFile)) //the exclaimation operator SHOULD negate isNullOrEmpty, so it should only be true if it is NOT empty
        {
            File.WriteAllText(saveFile, welkomstTekst);
        };
        
        
    }

}
