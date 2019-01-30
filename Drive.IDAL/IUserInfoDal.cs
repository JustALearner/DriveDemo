using Drive.Model;

namespace Drive.IDAL
{
    public interface IUserInfoDal : IBaseDal<T_Sys_User>
    {
        T_Sys_User GetUser(string userName, string passWord);

    }
  
}
