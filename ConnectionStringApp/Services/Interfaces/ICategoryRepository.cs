using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectionStringApp.Services.Interfaces
{
    public interface ICategoryRepository
    {

        Category GetCategory(Guid categoryId);
        IEnumerable<Category> GetCategories();

        bool SaveCategory();
    }
}
