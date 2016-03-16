using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Homework
{
    public class PotterShoppingCart
    {
        
        public double GetPrice(List<Book> Books)
        {
            double totalPrice = 0;
            
             if (Books.Count(x => x.Version == 1) > 0 && Books.Count(y => y.Version == 2) > 0&&Books.Count(y => y.Version == 3) > 0)
            {
                Books.Remove(Books.FirstOrDefault(x => x.Version == 1));
                Books.Remove(Books.FirstOrDefault(x => x.Version == 2));
                Books.Remove(Books.FirstOrDefault(x => x.Version == 3));

                totalPrice += 3 * (100 * 0.90);
            }
             else if (Books.Count(x => x.Version == 1) > 0 && Books.Count(y => y.Version == 2) > 0)
            {
                Books.Remove(Books.FirstOrDefault(x => x.Version == 1));
                Books.Remove(Books.FirstOrDefault(x => x.Version == 2));
                totalPrice += 2 * (100*0.95);
            }
            totalPrice += Books.Count * 100;
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
