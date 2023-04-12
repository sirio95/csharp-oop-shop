using System.Linq;


namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product prod1 = new Product("profumo", "profumatissimo", 12);
            Product prod2 = new Product("musica", "leggerissima", 13);
            Product prod3 = new Product("scarpe", "indistruttibili", 14);
            Product prod4 = new Product("maglione", "comodissimo", 15);

            List<Product> products = new List<Product>();
            products.Add(prod1);
            products.Add(prod2);
            products.Add(prod3);
            products.Add(prod4);
            foreach(Product product in products)
            {
                product.GetFullProduct();
            }
        }
        public class Product
        {
            public int Code { get; }
            public string Name { get; set; }
            public string Description { get; set; }
            public int Price { get; set; }
            public static double IVA = 0.22;

            Random ranNUm = new Random();

            public Product(string name, string description, int price) 
            {
                this.Code = ranNUm.Next();
                this.Name = name;
                this.Description = description;
                this.Price = price;
            }
            public void GetPrice()
            {
                Console.WriteLine($"Il prezzo del prodotto è di: {this.Price}$");
            }
            public void GetPriceIVA()
            {
                double priceIVA = this.Price * IVA;
                Console.WriteLine($"Il prezzo del prodotto con IVA è di: {this.Price + priceIVA}");
            }
            public void GetFullProduct()
            {
                double priceIVA = this.Price * IVA;
                Console.WriteLine($"Prodotto:");
                Console.WriteLine($"- {this.Code} - {this.Name}");
                Console.WriteLine(this.Description);
                Console.WriteLine($"prezzo: {this.Price} - con IVA: {this.Price + priceIVA}");
            }
        }

    }
}