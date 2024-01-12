using System;

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

            foreach (var el in Category) {
                Console.Write($"|{el}");
            }

        }

        public void getInfo() {
            Console.Write(
                $"Name: {ProductName}\n" +
                $"Presentation: {Grams}{Unit} {Presentation}\n"
                );
            Console.Write("\nCategory: ");
            catList();
            Console.Write(
                $"Price: {Convert.ToDouble(Price).ToString("C")}\n" +
                $"Description: {Description}");
        }
    }



    private static void Main(string[] args) {
        Categories[] cats = { Categories.Analgesics, Categories.Antipyrethics };
        Product paracetamol = new Product("Paracetamol", "TABLeTs", 500, "mg", cats, 700, $"Efectivo contra el dolor leve y la fiebre.");
        paracetamol.getInfo();
    }

}