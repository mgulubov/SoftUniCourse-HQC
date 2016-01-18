namespace Orders.Interfaces
{
    /// <summary>
    /// Interface for Category objects
    /// </summary>
    public interface ICategory : IIdentifiable, INameable
    {
        /// <summary>
        /// The Category description
        /// </summary>
        string Description { get; }
    }
}
