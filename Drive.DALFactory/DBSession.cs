using Drive.DAL;
using Drive.IDAL;
using Drive.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drive.DALFactory
{
    /// <summary>
    /// 数据会话层：就是一个工厂类，负责完成所有数据操作类实例的创建，然后业务层通过数据会话层来获取要操作数据类的实例。所以数据会话层将业务层与数据层解耦。
    /// 在数据会话层中提供一个方法：完成所有数据的保存。
    /// </summary>
    public class DBSession : IDBSession
    {
      // OAEntities Db = new OAEntities();
        public DbContext Db
        {
            get
            {
                return DbContextFactory.CreateDbContext(); 
            }
        }

        private IUserInfoDal _userInfoDal;
       public IUserInfoDal UserInfoDal
       {
           get
           {
             return  _userInfoDal ?? (_userInfoDal = AbstractFactory.CreateUserInfoDal());
           }
           set {  _userInfoDal = value; }
       }
       private IOperateLogDal _operLogDal;
       public IOperateLogDal OperLogDal
       {
           get
           {
               return _operLogDal ?? (_operLogDal = AbstractFactory.CreateOperLogDal());
           }
           set { _operLogDal = value; }
       }

        /// <summary>
       /// 一个业务中经常涉及到对多张操作，我们希望链接一次数据库，完成对张表数据的操作。提高性能。 工作单元模式。
       /// </summary>
       /// <returns></returns>
       public bool SaveChanges()
       {
           return Db.SaveChanges() > 0;
       }

    }
}
