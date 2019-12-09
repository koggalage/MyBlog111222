using CodeGuide.EF.DomainModels;
using CodeGuide.EF.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeGuide.EF
{
    public class ContextFactory : IDisposable, IContextFactory
    {
        private BlogContext _dbContext;

        public BlogContext DbContext
        {
            get
            {
                if (_dbContext == null)
                {
                    _dbContext = new BlogContext();
                }

                return _dbContext;
            }
        }

        public void Dispose()
        {
            if (_dbContext != null)
            {
                _dbContext.Dispose();
                _dbContext = null;
            }
        }
    }
}
