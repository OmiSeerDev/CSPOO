using CSPOO.ProductsApp;

internal class Program
{
    private static void Main()
    {
        Categories[] cats = { (Categories)1, Categories.Antipyrethics };
        Drug paracetamol = new("Paracetamol", 1300, "Efectivo contra el dolor leve y la fiebre.", "TABLeTs", 500, "mg", cats);
        paracetamol.getInfo();
    }

}