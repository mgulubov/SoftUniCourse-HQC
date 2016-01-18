namespace Orders.Models
{
    using Interfaces;

    /// <summary>
    /// Concrete class for the IOrder interface
    /// </summary>
    public class Order : IOrder
    {
        /// <summary>
        /// Order construcotr with three parameters.
        /// </summary>
        /// <param name="id">The Id of the order.</param>
        /// <param name="productId">The product id of the order</param>
        /// <param name="quantity">The quantity of products</param>
        /// <param name="discount">The order discount</param>
        public Order(int id, int productId, int quantity, decimal discount)
        {
            this.Id = id;
            this.ProductId = productId;
            this.Quantity = quantity;
            this.Discount = discount;
        }

        public int Id { get; private set; }

        public int ProductId { get; private set; }

        public int Quantity { get; private set; }

        public decimal Discount { get; private set; }
    }
}
