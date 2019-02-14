using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;
namespace Drive.WebApp.Models.Validators
{
    public class LoginValidator:AbstractValidator<LoginViewModel>
    {
        public LoginValidator()
        {
            RuleFor(login => login.UserCode).NotEmpty().WithName("用户名").WithMessage("请输入用户").Matches("^[a-z]{5}$").WithMessage("用户名格式不合法");
            RuleFor(login => login.UserCode).NotEmpty().WithName("密码").WithMessage("请输入密码");
        }
    }
}