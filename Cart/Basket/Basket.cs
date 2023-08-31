using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cart.Item;

namespace Cart.Basket
{
    public class BasketCheckout
    {
        public List<ShoppingItem> BasketItems { get; } = new List<ShoppingItem>();

        public void AddItemToBasket(ShoppingItem item)
        {
            BasketItems.Add(item);
        }

        public decimal CalculateBasketTotal()
        {
            var basketTotalPrice = BasketItems.Sum(basketItem => basketItem.Price * basketItem.Quantity);

            return basketTotalPrice;
        }
    }
}
