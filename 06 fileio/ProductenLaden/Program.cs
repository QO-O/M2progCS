using System.Text.Json;

namespace ProductenLaden;

class Program
{
   static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();


        string Text = "Product.json";
        Product product = JsonSerializer.Deserialize<Product>(text);

        string[] lines = File.ReadAllText(Product.json);
    }


     internal void Run()
    {
       
    }

}

public class ProductenLaden
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
}
