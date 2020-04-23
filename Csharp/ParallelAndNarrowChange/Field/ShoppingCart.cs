using System.Collections.Generic;
using System.Linq;

namespace ParallelAndNarrowChange.Field
{

    public class ShoppingCart
    {
        private readonly List<IProduct> products = new List<IProduct>();

        public decimal CalculateTotalPrice() => products.Sum(p => p.Price);

        public bool HasDiscount() => products.Any(p => p.Price > 100);

        public void Add(IProduct p) => products.Add(p);

        public int NumberOfProducts() => products.Count;
    }
}
