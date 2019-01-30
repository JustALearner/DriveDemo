using Drive.IBLL;
using Drive.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drive.IDAL;

namespace Drive.BLL
{
    public class UserInfoService : BaseService<T_Sys_User>,IUserInfoService
    {

        public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDbSession.UserInfoDal;
        }
        //public void SetUserInfo(UserInfo userInfo)
        //{
        //    this.CurrentDBSession.UserInfoDal.AddEntity(userInfo);
        //    this.CurrentDBSession.UserInfoDal.DeleteEntity(userInfo);
        //    this.CurrentDBSession.UserInfoDal.EditEntity(userInfo);
        //    this.CurrentDBSession.SaveChanges();
        //}
     
    }
   
}
