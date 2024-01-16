using System.Text;
using CSPOO.Interfaces;

namespace CSPOO.ProductsApp
{
    public class Drug : PharmacyStock, IProduct
    {
        public string ProductName { get; set; }
        public int Price { get; set; }
        public static string Legend = " Consulte a su médico";
        public string Description { get; set; }
        string Presentation;
        int Grams;
        string Unit;



        public Drug(string productName, int price, string description, string presentation, int grams, string unit, Categories[] category)
        {
            ProductName = productName;
            Price = price / 100;
            Description = string.Concat(description, Legend);

            Grams = grams;
            Unit = unit;
            Presentation = presentation.ToLower();
            foreach (var element in category)
            {
                Category.Add(element);
            }
        }


        public string catList()
        {
            StringBuilder res = new();
            foreach (var el in Category)
            {
                res.Append($"{Convert.ToString(el)}, ");
            }
            return res.ToString().Substring(0, res.Length - 2); //Removes the last comma and space
        }


        public void getInfo()
        {
            string cats = catList();
            Console.WriteLine(
                $"Name: {ProductName}\n" +
                $"Presentation: {Grams}{Unit} {Presentation}\n" +
                $"Category: [{cats}]");
            Console.Write(
                $"Price: {Price.ToString("C")}\n" +
                $"Description: {Description}");
        }


    }

}

