using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace CRM_team.EntityFramework.Repositories
{
    public abstract class CRM_teamRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<CRM_teamDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected CRM_teamRepositoryBase(IDbContextProvider<CRM_teamDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class CRM_teamRepositoryBase<TEntity> : CRM_teamRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected CRM_teamRepositoryBase(IDbContextProvider<CRM_teamDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
