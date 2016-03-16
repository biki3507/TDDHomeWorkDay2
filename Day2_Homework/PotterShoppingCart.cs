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
        private double totalPrice = 0;
        public double GetPrice(List<Book> Books)
        {
            totalPrice = 0;
            this.books = Books;
            GetDiscount();
            if (books.Count>0)
            {
              totalPrice +=(Books.Count * 100);  
            }
            
            return totalPrice;
        }

        private void GetDiscount()
        {


            BookGroup(5,0.75);
            BookGroup(4,0.8);
            BookGroup(3,0.9);
            BookGroup(2,0.95);
          
        }

        private void BookGroup(int GroupNum,double disCountRatio)
        {
            if (this.books.GroupBy(x => x.Version).Select(y => y.FirstOrDefault()).Count() == GroupNum)
            {
                foreach (var item in this.books.GroupBy(x => x.Version).Select(y => y.FirstOrDefault()))
                {
                    this.books.Remove(item);
                }
                this.totalPrice += GroupNum * (100 * disCountRatio);
            }
        }

    }
    public class Book
    {
        public int Version { get; set; }
        public int Num { get; set; }
        public int UnitPrice { get; set; }
    }

}
