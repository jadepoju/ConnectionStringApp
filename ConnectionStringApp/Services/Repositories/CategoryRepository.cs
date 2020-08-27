using ConnectionStringApp.Data;
using ConnectionStringApp.Services.Interfaces;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectionStringApp.Services.Repositories
{
    public class CategoryRepository : ICategoryRepository, IDisposable
    {
        private readonly ProductContext _context;
        public CategoryRepository(ProductContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.ToList();
            //return _context.Categories.ToList<Category>();
        }

        public Category GetCategory(Guid categoryId)
        {
            if(categoryId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(categoryId));
            }
            return _context.Categories.FirstOrDefault(c => c.Id == categoryId);
        }

        public bool SaveCategory()
        {
            return (_context.SaveChanges() > 0);
        }
    }
}
