/******/ (function (modules) { // webpackBootstrap
    /******/ 	// The module cache
    /******/ 	var installedModules = {};

    /******/ 	// The require function
    /******/ 	function __webpack_require__(moduleId) {

        /******/ 		// Check if module is in cache
        /******/ 		if (installedModules[moduleId])
            /******/ 			return installedModules[moduleId].exports;

        /******/ 		// Create a new module (and put it into the cache)
        /******/ 		var module = installedModules[moduleId] = {
            /******/ 			exports: {},
            /******/ 			id: moduleId,
            /******/ 			loaded: false
            /******/
        };

        /******/ 		// Execute the module function
        /******/ 		modules[moduleId].call(module.exports, module, module.exports, __webpack_require__);

        /******/ 		// Flag the module as loaded
        /******/ 		module.loaded = true;

        /******/ 		// Return the exports of the module
        /******/ 		return module.exports;
        /******/
    }


    /******/ 	// expose the modules object (__webpack_modules__)
    /******/ 	__webpack_require__.m = modules;

    /******/ 	// expose the module cache
    /******/ 	__webpack_require__.c = installedModules;

    /******/ 	// __webpack_public_path__
    /******/ 	__webpack_require__.p = "";

    /******/ 	// Load entry module and return exports
    /******/ 	return __webpack_require__(0);
    /******/
})
/************************************************************************/
/******/([
/* 0 */
/***/ (function (module, exports) {

    "use strict";

    /*
	 * @Author: jiaolong 
	 * @Date: 2018-11-22 17:31:43 
	 * @Last Modified by: jiaolong
	 * @Last Modified time: 2018-11-30 15:18:51
	 * 58滑块变更网易盾
	 */

    $(document).ready(function () {
        // 初始化注册类型
        var obj = {
            text: "驾校入驻",
            url: "/register/jx"
        };
        //根据路径判断注册去向
        var guidance_type = "jx";// window.location.href.split("/")[4];
        if (guidance_type == "jl") {
            obj.text = "教练入驻";
            obj.url = "http://user.jxedt.com/register/jl";
            $('#registerfrom')[0].removeChild($("#registerfrom").children("div")[0]);
            $("#usertype").val(1);
        } else if (guidance_type == "pl") {
            obj.text = "陪练入驻";
            obj.url = "http://user.jxedt.com/register/pl";
            $("#usertype").val(0);
            $('#registerfrom')[0].removeChild($("#registerfrom").children("div")[0]);
        } else if (guidance_type == "jx") {
            obj.text = "驾校入驻";
            obj.url = "/register/jx";
            $("#usertype").val("");
        } else if (guidance_type == "xy") {
            obj.text = "学员注册";
            obj.url = "/register";
            $("#usertype").val("");
            $('#registerfrom')[0].removeChild($("#registerfrom").children("div")[0]);
        }

        //动态改版注册文字提示
//        $("#registerfrom h4").text(obj.text);
//        $(".register-jx").keyup(function () {
//            jxNameReg();
//        });

        function jxNameReg() {
            var jxName = $.trim($(".register-jx").val());
            if (jxName == "" || jxName == $(".register-jx").attr("placeholder")) {
                $(".register-jx").next().css("visibility", "visible");
                $(".register-jx").next().text("请输入驾校全称");
                $(".register-jx").next().next().hide();
                return false;
            } else if ($(".register-jx").val().length >= 40) {
                $(".register-jx").next().css("visibility", "visible");
                $(".register-jx").next().text("驾校名称过长");
                $(".register-jx").next().next().hide();
                return false;
            } else {
                $(".register-jx").next().css("visibility", "hidden");
                $(".register-jx").next().text("");
                $(".register-jx").next().next().show();
            }
            return true;
        }

        $(".register-phone").keyup(function () {
            jxPhoneReg();
        });

        function jxPhoneReg() {
            var phone = $.trim($(".register-phone").val());
            var regPhone = /^[1][3,4,5,6,7,8,9][0-9]{9}$/;
            if (phone == "" || phone == $(".register-phone").attr("placeholder")) {
                $(".register-phone").next().css("visibility", "visible");
                $(".register-phone").next().text("请输入手机号码");
                $(".register-phone").next().next().hide();
                return false;
            } else if (!regPhone.test($(".register-phone").val())) {
                $(".register-phone").next().css("visibility", "visible");
                $(".register-phone").next().text("请输入正确的手机号");
                $(".register-phone").next().next().hide();
                return false;
            } else {
                $(".register-phone").next().css("visibility", "hidden");
                $(".register-phone").next().text("");
                $(".register-phone").next().next().show();
            }
            return true;
        }

        $(".register-code").keyup(function () {
            jxCodeReg();
        });

        function jxCodeReg() {
            var code = $.trim($(".register-code").val());
            if (code == "" || code == $(".register-code").attr("placeholder")) {
                $(".register-code").next().next().css("visibility", "visible");
                $(".register-code").next().next().text("请输入验证码");
                $(".register-code").next().next().next().hide();
                return false;
            } else if ($(".register-code").val().length != 4) {
                $(".register-code").next().next().css("visibility", "visible");
                $(".register-code").next().next().text("短信验证码错误");
                $(".register-code").next().next().next().hide();
                return false;
            } else {
                $(".register-code").next().next().css("visibility", "hidden");
                $(".register-code").next().next().text("");
                $(".register-code").next().next().next().show();
            }
            return true;
        }

        $(".register-pwd").keyup(function () {
            jxPwdReg();
        });

        function jxPwdReg() {
            var pwd = $.trim($(".register-pwd").val());
            var regpwd = /^(?![\d]+$)(?![a-zA-Z]+$)(?![^\da-zA-Z]+$).{8,20}$/;
            if (pwd == "" || pwd == $(".register-pwd").attr("placeholder")) {
                if (navigator.appName == "Microsoft Internet Explorer" && navigator.appVersion.match(/9./i) == "9.") {
                    $(".register-pwd").next().next().css("visibility", "visible");
                    $(".register-pwd").next().next().text("请输入密码");
                    $(".register-pwd").next().next().next().hide();
                } else {
                    $(".register-pwd").next().css("visibility", "visible");
                    $(".register-pwd").next().text("请输入密码");
                    $(".register-pwd").next().next().hide();
                }
                return false;
            } else if (!regpwd.test($(".register-pwd").val())) {
                if (navigator.appName == "Microsoft Internet Explorer" && navigator.appVersion.match(/9./i) == "9.") {
                    $(".register-pwd").next().next().css("visibility", "visible");
                    $(".register-pwd").next().next().text("密码格式有误(字母、数字或者符号,最短8位)");
                    $(".register-pwd").next().next().next().hide();
                } else {
                    $(".register-pwd").next().css("visibility", "visible");
                    $(".register-pwd").next().text("密码格式有误(字母、数字或者符号,最短8位)");
                    $(".register-pwd").next().next().hide();
                }
                return false;
            } else {
                if (navigator.appName == "Microsoft Internet Explorer" && navigator.appVersion.match(/9./i) == "9.") {
                    $(".register-pwd").next().next().css("visibility", "hidden");
                    $(".register-pwd").next().next().text("");
                    $(".register-pwd").next().next().next().show();
                } else {
                    $(".register-pwd").next().css("visibility", "hidden");
                    $(".register-pwd").next().text("");
                    $(".register-pwd").next().next().show();
                }
            }
            return true;
        }

        $("#register_checkbox").click(function () {
            jxisCheckedReg();
        });

        function jxisCheckedReg() {
            var isChecked = $('#register_checkbox').is(":checked");
            if (!isChecked) {
                $(".register-submit").addClass("register-submit-on").text("您还未接受注册条款");
                return false;
            } else {
                $(".register-submit").removeClass("register-submit-on").text("注册");
            }
            return true;
        }

        var captchaIns = "";

        initNECaptcha({
            // config对象，参数配置
            captchaId: "e11978dc94fe431eb2ec9c510ddf97b9",
            element: "#captcha",
            mode: "popup",
            width: "380px",
            // 用户验证码验证成功后，进行实际的提交行为
            onVerify: function onVerify(err, data) {
                if (data) {
                    $("#successToken").val(data.validate);
                    // $(".code-block").show();
                    // $(".captcha-block").hide();
                    getVerificationCode($(".register-phone").val(), $(".register-code-btn"));
                }
            }
        }, function onload(instance) {
            // 初始化成功后得到验证实例instance，可以调用实例的方法
            console.log(instance);
            captchaIns = instance;
        }, function onerror(err) {
            console.log("error", err);
            // 初始化失败后触发该函数，err对象描述当前错误信息
        });
        $(".register-code-btn").click(function () {
            return false;
            if (!jxPhoneReg()) {
                return false;
            }
            if (!jxPwdReg()) {
                return false;
            }
            if (!jxisCheckedReg()) {
                return false;
            }
            if (!$("#successToken").val()) {
                captchaIns && captchaIns.refresh();
                captchaIns && captchaIns.popUp();
                return false;
            }
        });

        function getVerificationCode(phone, el) {
            var d = new Date();
            var time = d.getTime();
            $.ajax({
                dataType: 'json',
                type: 'get',
                url: 'http://user.jxedt.com/captcha/pcSendCode',
                data: {
                    t: 1,
                    m: 1,
                    p: 1,
                    mobile: phone,
                    successToken: $("#successToken").val(),
                    _: time
                },
                success: function success(res) {
                    if (res.code == 0) {
                        var n = 60;
                        window.rid = res.result.rid;
                        $(el).css({
                            "background-color": "#F2F2F2",
                            "color": "#00C356",
                            "cursor": "default"
                        });
                        window.timer = setInterval(function () {
                            if (n <= '1') {
                                clearInterval(timer);
                                $(el).css({
                                    "background-color": "#00C356",
                                    "color": "#FFFFFF",
                                    "cursor": "pointer"
                                });
                                $(el).text('发送验证码');
                                $("#successToken").val("");
                            } else {
                                $(el).text(--n + ' 秒后重新获取');
                            }
                        }, 1000);
                    } else {
                        $(".register-code").next().next().css("visibility", "visible");
                        $(".register-code").next().next().text(res.msg);
                        $(el).text('发送验证码');
                        $(el).css({
                            "background-color": "#F2F2F2",
                            "color": "#00C356",
                            "cursor": "default"
                        });
                    }
                }
            });
        }

        $(".register-submit").click(function () {

            if ($(".register-jx").length >= 1) {
                jxNameReg();
            }
            if (!jxPhoneReg()) {
                return false;
            }
            if (!jxPwdReg()) {
                return false;
            }
//            if (!jxisCheckedReg()) {
//              
//                return false;
//            }

            // if ($("#successToken").val() == "") {
            //     $("#captcha").next().css("visibility", "visible");
            //     $("#captcha").next().text("请完成滑块验证后登陆");
            //     return false;
            // }
//            if (!jxCodeReg()) {
//                return false;
//               
//            }

            // if ($("#successToken").val() == "") {
            //     $("#captcha").next().css("visibility", "visible");
            //     $("#captcha").next().text("请完成滑块验证后登陆");
            //     return false;
            // }
            var r_id = window.rid;
            $("#phonerid").val(r_id);
            var targetUrl = $("#registerfrom").attr("action");
            var t = $('#registerfrom').serializeArray();
            // getCapthaSession();
            $.ajax({
                dataType: "json",
                type: "post",
                url: targetUrl,
                data: t,
                success: function success(data) {
                   
                    if (data.code == "0") {
                        alert(data.msg);
                        $("#successToken").val("");
                        window.location.href = data.url;
                        
                        //	                } else if (data.code == "-102") {
                        //	                    $(".register-code").next().next().css("visibility", "visible");
                        //	                    $(".register-code").next().next().text(data.msg);
                        //	                    $(".register-code").next().next().next().hide();
                        //	                } else {
                        //	                    $(".register-phone").next().css("visibility", "visible");
                        //	                    $(".register-phone").next().text(data.msg);
                        //	                    $(".register-phone").next().next().hide();
              
                
                    } else {
                        	                    $(".register-phone").next().css("visibility", "visible");
                        	                    $(".register-phone").next().text(data.msg);
                        	                    $(".register-phone").next().next().hide();
                    }
                },
                error: function error(data) { }
            });
        });
    });

    /***/
})
/******/]);