﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drive.Model.VM
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "请输入用户")]
        [Display(Name = "用户名")]
        public string UserCode { get; set; }
        
        [Required(ErrorMessage = "请输入密码")]
        [Display(Name = "密码")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
