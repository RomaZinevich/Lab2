using System.Diagnostics;

namespace Lab2_SOLID
{
    //The product class is created to work with products, and the price reduction method is implemented.
    //From the principles of SOLID, principle S - (each object should perform only one function)
    public class Product
    {
        private int id;
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        private string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        private Money price;
        public Money Price
        {
            set { price = value; }
            get { return price; }
        }
        public Product(int id, string name, Money price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        public void ReducePrice(double money)
        {
            string[] remainder;
            double price_money = Convert.ToDouble($"{Price.Whole_part_maney},{Price.Coins}");
            if (money > price_money && money < 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                price_money -= money;
                remainder = Convert.ToString(price_money).Split(",");
                Price.Whole_part_maney = Convert.ToInt32(remainder[0]);
                Price.Coins = Convert.ToInt32(remainder[1]);
            }
        }
    }
}
