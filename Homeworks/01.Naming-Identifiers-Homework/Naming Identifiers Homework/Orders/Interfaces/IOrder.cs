namespace Orders.Interfaces
{
    /// <summary>
    /// Interface for Order objects
    /// </summary>
    public interface IOrder : IIdentifiable
    {
        /// <summary>
        /// The ProductId of the Product object for this Order
        /// </summary>
        int ProductId { get; }

        /// <summary>
        /// The Quantity of Products
        /// </summary>
        int Quantity { get; }

        /// <summary>
        /// The Price discount
        /// </summary>
        decimal Discount { get; }
    }
}
