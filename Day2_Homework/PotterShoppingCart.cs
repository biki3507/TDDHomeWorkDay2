using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Homework
{
    public class PotterShoppingCart
    {
        List<Book> books = new List<Book>();
        public double GetPrice(List<Book> Books)
        {
            double totalPrice = 0;
            this.books = Books;
            totalPrice += GetDiscount(totalPrice);


            totalPrice += Books.Count * 100;
            return totalPrice;
        }

        private double GetDiscount(double totalPrice)
        {
            if (this.books.Count(x => x.Version == 1) > 0 && this.books.Count(y => y.Version == 2) > 0 && this.books.Count(y => y.Version == 3) > 0 && this.books.Count(y => y.Version == 4) > 0 && this.books.Count(y => y.Version == 5) > 0)
            {
                this.books.Remove(this.books.FirstOrDefault(x => x.Version == 1));
                this.books.Remove(this.books.FirstOrDefault(x => x.Version == 2));
                this.books.Remove(this.books.FirstOrDefault(x => x.Version == 3));
                this.books.Remove(this.books.FirstOrDefault(x => x.Version == 4));
                this.books.Remove(this.books.FirstOrDefault(x => x.Version == 5));
                totalPrice += 5 * (100 * 0.75);
            }
            if (this.books.Count(x => x.Version == 1) > 0 && this.books.Count(y => y.Version == 2) > 0 && this.books.Count(y => y.Version == 3) > 0 && this.books.Count(y => y.Version == 4) > 0)
            {
                this.books.Remove(this.books.FirstOrDefault(x => x.Version == 1));
                this.books.Remove(this.books.FirstOrDefault(x => x.Version == 2));
                this.books.Remove(this.books.FirstOrDefault(x => x.Version == 3));
                this.books.Remove(this.books.FirstOrDefault(x => x.Version == 4));
                totalPrice += 4 * (100 * 0.8);
            }
            if (this.books.Count(x => x.Version == 1) > 0 && this.books.Count(y => y.Version == 2) > 0 && this.books.Count(y => y.Version == 3) > 0)
            {
                this.books.Remove(this.books.FirstOrDefault(x => x.Version == 1));
                this.books.Remove(this.books.FirstOrDefault(x => x.Version == 2));
                this.books.Remove(this.books.FirstOrDefault(x => x.Version == 3));
                totalPrice += 3 * (100 * 0.90);
            }
            if (this.books.GroupBy(x => x.Version).Select(y => y.FirstOrDefault()).Count() == 2)
            {
                //this.books.Remove(this.books.FirstOrDefault(x => x.Version == 1));
                //this.books.Remove(this.books.FirstOrDefault(x => x.Version == 2));
                foreach (var item in this.books.GroupBy(x => x.Version).Select(y => y.FirstOrDefault()))
                {
                    this.books.Remove(item);
                }
                totalPrice += 2 * (100 * 0.95);
            }
            return totalPrice;
        }

    }
    public class Book
    {
        public int Version { get; set; }
        public int Num { get; set; }
        public int UnitPrice { get; set; }
    }

}
