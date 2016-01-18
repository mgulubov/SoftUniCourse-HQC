namespace Orders.Models
{
    using Interfaces;

    /// <summary>
    /// Concrete class for the IProduct interface
    /// </summary>
    public class Product : IProduct
    {
        /// <summary>
        /// Product constructor with five parameters.
        /// </summary>
        /// <param name="id">The product ID.</param>
        /// <param name="name">The product Name.</param>
        /// <param name="categoryId">The product's category Id.</param>
        /// <param name="unitPrice">The price for a single product unit.</param>
        /// <param name="unitsInStock">Total product units in stock.</param>
        public Product(int id, string name, int categoryId, decimal unitPrice, int unitsInStock)
        {
            this.Id = id;
            this.Name = name;
            this.CategoryId = categoryId;
            this.UnitPrice = unitPrice;
            this.UnitsInStock = unitsInStock;
        }

        public int Id { get; private set; }

        public string Name { get; private set; }

        public int CategoryId { get; private set; }

        public decimal UnitPrice { get; private set; }

        public int UnitsInStock { get; private set; }
    }
}
