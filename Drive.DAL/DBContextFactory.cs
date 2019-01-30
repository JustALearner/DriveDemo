using System.Data.Entity;
using System.Runtime.Remoting.Messaging;
using Drive.Model;

namespace Drive.DAL
{
    /// <summary>
    /// 负责创建EF数据操作上下文实例，必须保证线程内唯一.
    /// </summary>
   public class DbContextFactory
    {
       public static DbContext CreateDbContext()
       {
           DbContext dbContext = (DbContext)CallContext.GetData("dbContext");
           if (dbContext == null)
           {
               dbContext = new drivingEntities();
               CallContext.SetData("dbContext", dbContext);
           }
           return dbContext;
       }
    }
}
