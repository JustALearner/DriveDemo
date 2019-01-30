using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drive.IBLL;
using Drive.Model;

namespace Drive.BLL
{
    public class OperLogService:BaseService<T_Sys_Oper_Log>,IOperLogService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDbSession.OperLogDal;
        }
    }
}
