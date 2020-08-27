using ConnectionStringApp.Services.Interfaces;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectionStringApp.Services.Repositories
{
    public class ProductRepository : IProductRepository, IDisposable
    {
        public ProductRepository()
        {

        }
       
        public Product GetProduct(Guid categoryId, Guid productId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductS(Guid categoryId)
        {
            throw new NotImplementedException();
        }

        public bool SaveProduct()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
