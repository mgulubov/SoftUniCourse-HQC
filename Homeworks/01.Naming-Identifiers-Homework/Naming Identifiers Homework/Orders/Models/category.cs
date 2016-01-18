namespace Orders.Models
{
    using Interfaces;

    /// <summary>
    /// Concrete class of the ICategory interface
    /// </summary>
    public class Category : ICategory
    {
        /// <summary>
        /// Constructor for Category objects.
        /// </summary>
        /// <param name="id">The Category Id</param>
        /// <param name="name">The Category Name</param>
        /// <param name="description">The Category Description</param>
        public Category(int id, string name, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }

        public int Id { get; private set; }
        
        public string Name { get; private set; }

        public string Description { get; private set; }
    }
}
