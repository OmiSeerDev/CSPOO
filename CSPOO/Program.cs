using System.Text;

internal class Program
{

    enum Categories
    {
        Undefined,
        Analgesics,
        Antibiotics,
        Antidiabetics,
        Antihypertensives,
        Antipyrethics,
        Materials
    }

    class Product
    {
        string ProductName;
        List<Categories> Category = new List<Categories>();
        string Presentation;
        int Price;
        string Description;
        int Grams;
        string Unit;
        public static string Legend = " Consulte a su médico";

        public Product(string productName, string presentation, int grams, string unit, Categories[] category, int price, string description)
        {
            ProductName = productName;
            Grams = grams;
            Unit = unit;
            Presentation = presentation.ToLower();
            Price = price / 100;
            Description = string.Concat(description, Legend);
            foreach (var element in category)
            {
                Category.Add(element);
            }
        }

        public string CatList
        {
            get
            {
                StringBuilder res = new();
                foreach (var el in Category)
                {
                    res.Append($"{Convert.ToString(el)}, ");
                }
                return res.ToString().Substring(0, res.Length - 2); //Removes the last comma and space
            }
        }

        public void getInfo()
        {
            Console.WriteLine(
                $"Name: {ProductName}\n" +
                $"Presentation: {Grams}{Unit} {Presentation}\n" +
                $"Category: [{CatList}]");
            Console.Write(
                $"Price: {Price.ToString("C")}\n" +
                $"Description: {Description}");
        }
    }



    private static void Main()
    {
        Categories[] cats = { (Categories)1, (Categories)5 };
        Product paracetamol = new("Paracetamol", "TABLeTs", 500, "mg", cats, 1400, $"Efectivo contra el dolor leve y la fiebre.");
        paracetamol.getInfo();
    }

}