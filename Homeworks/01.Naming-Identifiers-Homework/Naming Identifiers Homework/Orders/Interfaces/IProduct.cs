namespace Orders.Interfaces
{
    /// <summary>
    /// Interface for Product objects
    /// </summary>
    public interface IProduct : IIdentifiable, INameable
    {
        /// <summary>
        /// The product's category Id
        /// </summary>
        int CategoryId { get; }

        /// <summary>
        /// The price for a single product unit
        /// </summary>
        decimal UnitPrice { get; }

        /// <summary>
        /// Total product units in stock.
        /// </summary>
        int UnitsInStock { get; }
    }
}
