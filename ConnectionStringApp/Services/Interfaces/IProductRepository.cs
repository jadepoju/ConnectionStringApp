using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectionStringApp.Services.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProductS(Guid categoryId);
        Product GetProduct(Guid categoryId, Guid productId);

        bool SaveProduct();
    }
}
