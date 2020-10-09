using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace CurseDotNet.Class2.EntityFramework.Repositories
{
    public abstract class Class2RepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<Class2DbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected Class2RepositoryBase(IDbContextProvider<Class2DbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class Class2RepositoryBase<TEntity> : Class2RepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected Class2RepositoryBase(IDbContextProvider<Class2DbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
