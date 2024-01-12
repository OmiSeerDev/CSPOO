using System.Text;

internal class Program {

    enum Categories {
        Undefined,
        Analgesics,
        Antibiotics,
        Antidiabetics,
        Antihypertensives,
        Antipyrethics,
        Materials
    }

    class Product {
        string ProductName;
        List<Categories> Category = new List<Categories>();
        string Presentation;
        int Price;
        string Description;
        int Grams;
        string Unit;
        public static string Legend = " Consulte a su médico";

        public Product(string productName, string presentation, int grams, string unit, Categories[] category, int price, string description) {
            ProductName = productName;
            Grams = grams;
            Unit = unit;
            Presentation = presentation.ToLower();
            Price = price / 100;
            Description = string.Concat(description, Legend);
            foreach (var element in category) {
                Category.Add(element);
            }
        }

        public void catList() {
            StringBuilder res = new();
            foreach (var el in Category) {
                res.Append($"{Convert.ToString(el)}, ");
            }
            Console.Write(res.ToString().Substring(0, res.Length - 2)); //Removes the last comma and space
        }

        public void getInfo() {
            Console.Write(
                $"Name: {ProductName}\n" +
                $"Presentation: {Grams}{Unit} {Presentation}\n"
                );
            Console.Write("Category: [");
            catList();
            Console.Write(
                $"]\nPrice: {Price.ToString("C")}\n" +
                $"Description: {Description}");
        }
    }



    private static void Main() {
        Categories[] cats = { Categories.Analgesics, Categories.Antipyrethics };
        Product paracetamol = new("Paracetamol", "TABLeTs", 500, "mg", cats, 700, $"Efectivo contra el dolor leve y la fiebre.");
        paracetamol.getInfo();
    }

}