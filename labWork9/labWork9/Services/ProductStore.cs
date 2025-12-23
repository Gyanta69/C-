using labWork9.Models;

namespace labWork9.Services
{
    public class ProductStore
    {
        private readonly List<Product> _products = new();
        private int _nextId = 1;

        public IReadOnlyList<Product> GetAllProducts()
        {
            return _products.AsReadOnly();
        }

        public Product? GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public void AddProduct(Product product)
        {
            product.Id = _nextId++;
            _products.Add(product);
        }

        public bool UpdateProduct(Product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct == null)
                return false;

            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;
            existingProduct.Category = product.Category;
            existingProduct.Stock = product.Stock;
            existingProduct.ImageBase64 = product.ImageBase64;
            existingProduct.ImageContentType = product.ImageContentType;

            return true;
        }

        public bool DeleteProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return false;

            _products.Remove(product);
            return true;
        }
    }
}

