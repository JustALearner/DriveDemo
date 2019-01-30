using Drive.IDAL;
using System.Configuration;
using System.Reflection;

namespace Drive.DALFactory
{
    /// <summary>
    /// 通过反射的形式创建类的实例
    /// </summary>
   public class AbstractFactory
    {
       private static readonly string AssemblyPath = ConfigurationManager.AppSettings["AssemblyPath"];
       private static readonly string NameSpace = ConfigurationManager.AppSettings["NameSpace"];
       public static IUserInfoDal CreateUserInfoDal()
       {
           string fullClassName = NameSpace + ".UserInfoDal";
          return CreateInstance(fullClassName) as IUserInfoDal;
       }
       public static IOperateLogDal CreateOperLogDal()
        {
            string fullClassName = NameSpace + ".OperLogDal";
            return CreateInstance(fullClassName) as IOperateLogDal;
        }
       private static object CreateInstance(string className)
       {
          var assembly= Assembly.Load(AssemblyPath);
          return assembly.CreateInstance(className);
       }
    }
}
