using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drive.Model.VM
{
    public class OperateLogViewModel
    {
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string LogType { get; set; }
        public DateTime ? CreateTime { get; set; }
        public string Content { get; set; }
    }
}
