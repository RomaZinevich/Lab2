
using System.Drawing;

namespace Lab2_SOLID
{
    public class Dolar : Money
    {
        public Dolar(int whole_part_money, int coins) : base(whole_part_money,coins)
        {
            this.Whole_part_maney = whole_part_money;
            this.Coins = coins;
        }
        public void PrintMoney()
        {
            Console.WriteLine($"{Whole_part_maney}.{Coins} долар");
        }
    }
    
    public class Grivna : Money
    {
        public Grivna(int whole_part_money, int coins) : base(whole_part_money, coins)
        {
            this.Whole_part_maney = whole_part_money;
            this.Coins = coins;
        }
        public void PrintMoney()
        {
            Console.WriteLine($"{Whole_part_maney}.{Coins} гривня");
        }
    }

    public class Euro : Money
    {
        public Euro(int whole_part_money, int coins) : base(whole_part_money, coins)
        {
            this.Whole_part_maney = whole_part_money;
            this.Coins = coins;
        }
        public void PrintMoney()
        {
            Console.WriteLine($"{Whole_part_maney}.{Coins} евро");
        }
    }
}

