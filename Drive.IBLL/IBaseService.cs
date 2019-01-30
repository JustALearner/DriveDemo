using Drive.IDAL;
using System;
using System.Linq;

namespace Drive.IBLL
{
  public  interface IBaseService<T>where T:class,new()
    {
      IDBSession CurrentDbSession { get; }
      IBaseDal<T> CurrentDal { get; set; }
      IQueryable<T> LoadEntities(System.Linq.Expressions.Expression<Func<T, bool>> whereLambda);
      IQueryable<T> LoadPageEntities<s>(int pageIndex, int pageSize, out int totalCount, System.Linq.Expressions.Expression<Func<T, bool>> whereLambda, System.Linq.Expressions.Expression<Func<T, s>> orderbyLambda, bool isAsc);
      bool DeleteEntity(T entity);
      bool EditEntity(T entity);
      T AddEntity(T entity);
    }
}
