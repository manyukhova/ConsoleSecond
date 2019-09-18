using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App18
{
    class ShoppingCart
    {
        public List<Food> Items { get; set; }
        public List <int> Amounts { get; set; }
        public double Sum { get; set; }

        public ShoppingCart()
        {
            Items = new List<Food>();
            Amounts = new List<int>();
            Sum = 0;
       
        }
        public void AddToCart(Food food, int amount)
        {
            Items.Add(food);
            Amounts.Add(amount);
        }
        public double CalculateSum()
        {
            for(int i=0; i<Items.Count(); i++)
            {
                Sum = Sum + Items[i].Price * Amounts[i];
            }
            return Sum;
        }
    }
}
