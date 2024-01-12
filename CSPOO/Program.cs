using System;

internal class Program
{

    enum Categories
    {
        Undefined,
        Analgesics,
        Antibiotics,
        Antidiabetics,
        Antihypertensives,
        Materials
    }

    class Product
    {
        string ProductName;
        Categories Category;
        string Presentation;
        int Price;
        string Description;
        int Grams;
        string Unit;
        public static string Legend = " Consulte a su médico";

        public Product(string productName, string presentation, int grams, string unit, Categories category, int price, string description)
        {
            ProductName = productName;
            Grams = grams;
            Unit = unit;
            Presentation = presentation.ToLower();
            Category = category;
            Price = price / 100;
            Description = String.Concat(description, Legend);
        }


        public void getInfo()
        {
            Console.WriteLine(
                $"Name: {ProductName}\nPresentation: {Grams}{Unit} {Presentation}\nCategory: {Category}\nPrice: {Convert.ToDouble(Price).ToString("C")}\nDescription: {Description}\n"
                );
        }
    }



    private static void Main(string[] args)
    {
        Product paracetamol = new Product("Paracetamol", "TABLeTs", 500, "mg", Categories.Analgesics, 700, $"Efectivo contra el dolor leve y la fiebre.");
        paracetamol.getInfo();
    }

}