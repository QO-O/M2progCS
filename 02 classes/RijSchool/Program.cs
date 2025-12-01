namespace RijSchool;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
    Auto auto1 = new Auto()
        {
        automaat = true,
        kenteken = "AA824H",
        kilometerStand = 20567,
        merk = "Volkswagen"
        };

        Auto auto2 = new Auto()
        {
        automaat = false,
        kenteken = "KU786G",
        kilometerStand = 65739,
        merk = "Volvo"
        };

    RijLeraar rijLeraar = new RijLeraar()
        {
        leeftijd = 30,
        naam = "John",
        zzp = false
        };

    LesUur lesUur = new LesUur()
        {
        auto = auto1,
        rijLeraar = rijLeraar,
        tijd = 1130
        };

    Student student = new Student()
    {
       
    };
}

