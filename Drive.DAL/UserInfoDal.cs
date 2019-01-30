using Drive.IDAL;
using Drive.Model;

namespace Drive.DAL
{
    public class UserInfoDal : BaseDal<T_Sys_User>, IUserInfoDal
    {
        public T_Sys_User GetUser(string userName, string passWord)
        {
            return null;
        }
    }
}
