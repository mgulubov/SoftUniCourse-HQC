namespace Orders.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface for dataMapper objects
    /// </summary>
    public interface IDataMapper
    {
        /// <summary>
        /// Method for getting all ICategory objects
        /// </summary>
        /// <returns>An IEnumerable collection of ICategory objects</returns>
        IEnumerable<ICategory> GetAllCategories();

        /// <summary>
        /// Method for getting all IProduct objects
        /// </summary>
        /// <returns>An IEnumerable collection of IProduct objects</returns>
        IEnumerable<IProduct> GetAllProducts();

        /// <summary>
        /// Method for getting all IOrder objects
        /// </summary>
        /// <returns>An IEnumerable collection of IOrder objects</returns>
        IEnumerable<IOrder> GetAllOrders();
    }
}
