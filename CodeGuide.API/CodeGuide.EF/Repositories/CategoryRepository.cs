using CodeGuide.EF.DomainModels;
using CodeGuide.EF.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeGuide.EF.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(IContextFactory contextFactory)
            : base(contextFactory)
        {

        }
    }
}
