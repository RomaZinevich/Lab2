namespace Lab2_SOLID
{
    //This class is designed to work with money, where you can store money as
    //whole and fractional parts, and change the amount of money and print the
    //amount on the screen using the PrintMoney() method.
    //From the principles of SOLID, the principle S - (each object should perform only one duty)
    //and the principle O - (Program entities should be open for expansion, but closed for changes) are used here
    interface IPrintMoney
    {
        void PrintMoney();
    }
    
    public class Money : IPrintMoney
    {
        private int whole_part_money;
        public int Whole_part_maney
        {
            set { whole_part_money = value; }
            get { return whole_part_money; }
        }
        private int coins;
        public int Coins
        {
            set { coins = value; }
            get { return coins; }
        }
        public Money(int whole_part_money, int coins)
        {
            this.whole_part_money = whole_part_money;
            this.coins = coins;
        }
        public void PrintMoney()
        {
            Console.WriteLine($"{whole_part_money}.{coins}");
        }
    }
}
