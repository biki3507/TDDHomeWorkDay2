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

            if (this.books.GroupBy(x => x.Version).Select(y => y.FirstOrDefault()).Count() ==5)
            {
                foreach (var item in this.books.GroupBy(x => x.Version).Select(y => y.FirstOrDefault()))
                {
                    this.books.Remove(item);
                }
                totalPrice += 5 * (100 * 0.75);
            }
            if (this.books.GroupBy(x => x.Version).Select(y => y.FirstOrDefault()).Count() ==4)
            {
                foreach (var item in this.books.GroupBy(x => x.Version).Select(y => y.FirstOrDefault()))
                {
                    this.books.Remove(item);
                }
                totalPrice += 4 * (100 * 0.8);
            }
            if (this.books.GroupBy(x => x.Version).Select(y => y.FirstOrDefault()).Count() == 3)
            {
                foreach (var item in this.books.GroupBy(x => x.Version).Select(y => y.FirstOrDefault()))
                {
                    this.books.Remove(item);
                }
                totalPrice += 3 * (100 * 0.90);
            }
            if (this.books.GroupBy(x => x.Version).Select(y => y.FirstOrDefault()).Count() == 2)
            {
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
