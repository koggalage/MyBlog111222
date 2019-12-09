using CodeGuide.EF.DomainModels;
using CodeGuide.EF.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeGuide.EF.Repositories
{
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IContextFactory contextFactory)
            :base(contextFactory)
        {

        }
    }
}
