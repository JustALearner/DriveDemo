using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drive.Model.VM;
using FluentValidation;
namespace Drive.Model.Validators
{
    public class LoginModelValidator:AbstractValidator<LoginViewModel>
    {
        public LoginModelValidator()
        {
            RuleFor(login => login.UserCode).NotEmpty().WithMessage("请输入用户").WithName("用户名");
            RuleFor(login => login.UserCode).NotEmpty().WithMessage("请输入密码").WithName("密码");
        }
    }
}
