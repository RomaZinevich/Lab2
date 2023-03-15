

namespace Lab2_SOLID
{
    //Implemented a class that describes works that are in the warehouse in a certain amount
    //From the principles of SOLID, the principle S - (each object should perform only one duty)
    public class Warehouse
    {
        private int id;
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        private string units;
        public string Units
        {
            set { units = value; }
            get { return units; }
        }
        private Product product;
        public Product Product
        {
            set { product = value; }
            get { return product; }
        }
        private int count;
        public int Count
        {
            set { count = value; }
            get { return count; }
        }
        private DateTime lastDate;
        public DateTime LastDate
        {
            set { lastDate = value; }
            get { return lastDate; }
        }
        public Warehouse(int id,string units, int count,Product product, DateTime lastDate)
        {
            this.id = id;
            this.units = units;
            this.count = count;
            this.product = product;
            this.lastDate = lastDate;
        }
        public int AddCountProduct(int counts)
        {
            count += counts;
            return counts;
        }
        public int RemoveCountProduct(int counts)
        {
            if (counts > count)
            {
                Console.WriteLine("Стількі товару не має на складі");
                return 0;
            }
            else{
                count -= counts;
                return counts;
            }
        }

    }
}
