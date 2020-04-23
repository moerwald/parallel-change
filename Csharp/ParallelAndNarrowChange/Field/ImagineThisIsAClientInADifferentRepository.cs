using System;

namespace ParallelAndNarrowChange.Field
{
    public class ImagineThisIsAClientInADifferentRepository
    {
        public string FormattedTotalPrice(int price)
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.Add(new Product(price));
            return string.Format("Total price is {0} euro", shoppingCart.CalculateTotalPrice());
        }
    }
}