namespace Lists_shit;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();

        string[] characters = new string[]
        {
            "Pac-Man","Samus","Crash Bandicoot","Spyro the Dragon","Donkey Kong","Mario","Luigi",
            "Astro","Solid Snake","Master Chief","Kratos","Sonic the Hedgehog","Link"
        };

        List<string> characterList = new List<string>();

        characterList.Add("ELEPHANT PEACH");

        for (int i = 0; i < characters.Length; i++)
        {
            characterList.Add(characters[i]);
        }

    
        for (int i = 0; i < characterList.Count; i++)
        {
            Console.WriteLine(characterList[i]);
        }

        foreach(string character in characterList)
        {
            Console.WriteLine(character);
        }
    }

    internal void Run()
    {
        
    }
}