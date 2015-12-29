using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace PomStore.EntityFramework.Repositories
{
    public abstract class PomStoreRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<PomStoreDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected PomStoreRepositoryBase(IDbContextProvider<PomStoreDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class PomStoreRepositoryBase<TEntity> : PomStoreRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected PomStoreRepositoryBase(IDbContextProvider<PomStoreDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
