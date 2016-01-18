namespace Orders
{
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using Models;
    using Interfaces;

    public class DataMapper : IDataMapper
    {
        private const string DefaultCategoriesFilePath = "../../Data/categories.txt";
        private const string DefaultProductsFilePath = "../../Data/products.txt";
        private const string DefaultOrdersFilePath = "../../Data/orders.txt";
        private readonly string categoriesFileName;
        private readonly string productsFileName;
        private readonly string ordersFileName;

        public DataMapper(string categoriesFileName, string productsFileName, string ordersFileName)
        {
            this.categoriesFileName = categoriesFileName;
            this.productsFileName = productsFileName;
            this.ordersFileName = ordersFileName;
        }

        public DataMapper()
            : this(DefaultCategoriesFilePath, DefaultProductsFilePath, DefaultOrdersFilePath)
        {
        }

        public IEnumerable<ICategory> GetAllCategories()
        {
            IEnumerable<ICategory> categories = ReadFileLines(this.categoriesFileName, true)
                .Select(c => c.Split(','))
                .Select(c => new Category(int.Parse(c[0]), c[1], c[2]));

            return categories;
        }

        public IEnumerable<IProduct> GetAllProducts()
        {
            IEnumerable<IProduct> products = ReadFileLines(this.productsFileName, true)
                .Select(p => p.Split(','))
                .Select(p => new Product(int.Parse(p[0]), p[1], int.Parse(p[2]), decimal.Parse(p[3]), int.Parse(p[4])));

            return products;
        }

        public IEnumerable<IOrder> GetAllOrders()
        {
            IEnumerable<IOrder> orders = ReadFileLines(this.ordersFileName, true)
                .Select(p => p.Split(','))
                .Select(p => new Order(int.Parse(p[0]), int.Parse(p[1]), int.Parse(p[2]), decimal.Parse(p[3])));

            return orders;
        }

        private IEnumerable<string> ReadFileLines(string filename, bool hasHeader)
        {
            var allLines = new List<string>();
            using (var reader = new StreamReader(filename))
            {
                string currentLine;
                if (hasHeader)
                {
                    reader.ReadLine();
                }

                while ((currentLine = reader.ReadLine()) != null)
                {
                    allLines.Add(currentLine);
                }
            }

            return allLines;
        }
    }
}
