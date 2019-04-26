/******/ (function(modules) { // webpackBootstrap
/******/ 	// The module cache
/******/ 	var installedModules = {};

/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {

/******/ 		// Check if module is in cache
/******/ 		if(installedModules[moduleId])
/******/ 			return installedModules[moduleId].exports;

/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = installedModules[moduleId] = {
/******/ 			exports: {},
/******/ 			id: moduleId,
/******/ 			loaded: false
/******/ 		};

/******/ 		// Execute the module function
/******/ 		modules[moduleId].call(module.exports, module, module.exports, __webpack_require__);

/******/ 		// Flag the module as loaded
/******/ 		module.loaded = true;

/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}


/******/ 	// expose the modules object (__webpack_modules__)
/******/ 	__webpack_require__.m = modules;

/******/ 	// expose the module cache
/******/ 	__webpack_require__.c = installedModules;

/******/ 	// __webpack_public_path__
/******/ 	__webpack_require__.p = "";

/******/ 	// Load entry module and return exports
/******/ 	return __webpack_require__(0);
/******/ })
/************************************************************************/
/******/ ([
/* 0 */
/***/ (function(module, exports) {

	'use strict';

	// 需要动态传入信息
	$(document).ready(function () {
	    inithit({
	        'cate': 'NA',
	        'area': 'NA',
	        'pagetype': 'jiaxiao',
	        'page': 'info'
	    });

	    function stopScroll(e) {
	        e.preventDefault();
	        e.stopImmediatePropagation();
	    }
	    $('.address-popup-wrap').on('mousewheel', stopScroll);
	    $('.address-popup').on('mousewheel', stopScroll);
	    $(document.body).on('mousewheel', '.tangram-suggestion-main', stopScroll);

	    $(document.body).append('<script src="http://j1.58cdn.com.cn/dist/jxedt/pc/products/jxdetail/js/crossdomain.js"></script>');

	    // $.ajax({
	    //     type: "GET",
	    //     url: "businessapi.jxedt.com/geo/ip-to-geo",
	    //     dataType: "json",
	    //     success: function (res) {
	    //         console.log(res);
	    //         var point = {
	    //             lat: res.lat,
	    //             lng: res.lng
	    //         };
	    //         // showLocation(point);
	    //     }
	    // })

	    function G(id) {
	        return document.getElementById(id);
	    }

//	    var map = new BMap.Map("jxMap", {
//	        enableMapClick: false
//	    });
//	    var point = new BMap.Point(116.331398, 39.897445);
//	    map.centerAndZoom(point, 12);
//	    // map.enableScrollWheelZoom();
//	    var geolocation = new BMap.Geolocation();
//	    geolocation.getCurrentPosition(function (r) {
//	        console.log(r);
//	        if (this.getStatus() == BMAP_STATUS_SUCCESS) {
//	            var mk = new BMap.Marker(r.point);
//	            map.panTo(r.point);
//	            map.addOverlay(mk);
//	        }
//	    }, { enableHighAccuracy: true });
//
//	    var navigationControl = new BMap.NavigationControl({
//	        // 靠右下角位置
//	        anchor: BMAP_ANCHOR_BOTTOM_RIGHT,
//	        // LARGE类型
//	        type: BMAP_NAVIGATION_CONTROL_ZOOM,
//	        // 启用显示定位
//	        enableGeolocation: false
//	    });
//	    map.addControl(navigationControl);
//	    var ac = new BMap.Autocomplete({ //建立一个自动完成的对象
//	        "input": "suggestId",
//	        "location": map
//	    });
//	    ac.addEventListener("onhighlight", function (e) {
//	        //鼠标放在下拉列表上的事件
//	        var str = "";
//	        var _value = e.fromitem.value;
//	        var value = "";
//	        if (e.fromitem.index > -1) {
//	            value = _value.province + _value.city + _value.district + _value.street + _value.business;
//	        }
//	        str = "FromItem<br />index = " + e.fromitem.index + "<br />value = " + value;
//
//	        value = "";
//	        if (e.toitem.index > -1) {
//	            _value = e.toitem.value;
//	            value = _value.province + _value.city + _value.district + _value.street + _value.business;
//	        }
//	        str += "<br />ToItem<br />index = " + e.toitem.index + "<br />value = " + value;
//	        G("searchResultPanel").innerHTML = str;
//	    });
//
//	    var myValue;
//	    ac.addEventListener("onconfirm", function (e) {
//	        //鼠标点击下拉列表后的事件
//	        var _value = e.item.value;
//	        myValue = _value.province + _value.city + _value.district + _value.street + _value.business;
//	        G("searchResultPanel").innerHTML = "onconfirm<br />index = " + e.item.index + "<br />myValue = " + myValue;
//	        setPlace();
//	    });
//	    map.addEventListener("click", function (e) {
//	        addMarker(e.point);
//	        getGeocoder(e.point);
//	    });
//	    function setPlace() {
//	        map.clearOverlays(); //清除地图上所有覆盖物
//	        function myFun() {
//	            var pp = local.getResults().getPoi(0).point; //获取第一个智能搜索的结果
//	            map.centerAndZoom(pp, 18);
//	            addMarker(pp); //添加标注
//	        }
//
//	        var local = new BMap.LocalSearch(map, { //智能搜索
//	            onSearchComplete: myFun
//	        });
//	        local.search(myValue);
//	    }

	    /**
	     * 开启地图弹窗事件
	     */
//	    $(".jx-list-contact #address_map").click(function () {
//	        $(".address-popup-wrap").show();
//	    });

	    /**
	     * 关闭地图弹窗事件
	     */
//	    $("#jxClose").click(function () {
//	        $(".address-popup-wrap").hide();
//	    });

	    // /**
	    //  * 处理定位后的信息
	    //  * @param r 经纬度
	    //  */
	    // function showLocation(r) {
	    //     var centerPoint = new BMap.Point(r.lng, r.lat);
	    //     map.centerAndZoom(centerPoint, 14);
	    //     map.panTo(centerPoint);
	    //     map.setCenter(centerPoint);
	    //     var gc = new BMap.Geocoder();
	    //     gc.getLocation(centerPoint, function (rs) {
	    //         // ac.hide();
	    //         $("#suggestId").val(rs.address);
	    //     });
	    //     //新建标注
	    //     var mk = new BMap.Marker(centerPoint);
	    //     mk.enableDragging(); // 不可拖拽
	    //     mk.addEventListener("dragend", function (ev) {
	    //         //每次拖拽更新文本框值
	    //         getGeocoder(ev.point);
	    //     });
	    //     map.clearOverlays(); //清除地图上所有覆盖物
	    //     map.addOverlay(mk);
	    // }


	    /**
	     * 创建标注
	     * @param point
	     */
	    function addMarker(point) {
	        $("#subForm #lon").val(point.lng);
	        $("#subForm #lat").val(point.lat);
	        map.clearOverlays(); //清除地图上所有覆盖物
	        var marker = new BMap.Marker(point);
	        marker.enableDragging();
	        map.addOverlay(marker);
	        //开启拖拽
	        marker.addEventListener("dragend", function (ev) {
	            //每次拖拽更新文本框值
	            getGeocoder(ev.point);
	        });
	    }

	    /**
	     * 根据经纬度获取位置
	     * @param point 经纬度
	     */
	    function getGeocoder(point) {
	        var geoc = new BMap.Geocoder();
	        geoc.getLocation(point, function (rs) {
	            $("#suggestId").val(rs.address);
	        });
	    }

	    $(".map-btn .confirm").click(function () {
	        $("#address_map").val($("#suggestId").val());
	        $(".address-popup-wrap").hide();
	    });

	    $(".map-btn .cancel").click(function () {
	        $(".address-popup-wrap").hide();
	    });
	});
	// 是否在倒计时
	var isCountDown = false;
	// 是否在提示
	var isToast = false;
	//是否提交成功
	var isSuccess = false;

	// 定时器
	var timer;

	function showToast(text) {
	    if (isToast) {
	        return;
	    }
	    isToast = true;
	    $('.toast').text(text).show();
	    setTimeout(function () {
	        $('.toast').hide();
	        isToast = false;
	    }, 2400);
	}
	var flag = true;
	$('#price').click(function () {
	    if (flag) {
	        $('#price_up').css('border-bottom', '5px solid #D8D8D8');
	        $('#price_down').css('border-top', '5px solid #00c356');
	        flag = false;
	    } else {
	        $('#price_down').css('border-top', '5px solid #D8D8D8');
	        $('#price_up').css('border-bottom', '5px solid #00c356');
	        flag = true;
	    }
	});

	function getCookieValue(name) {
	    var strCookie = document.cookie;
	    var arrCookie = strCookie.split("; ");
	    for (var i = 0; i < arrCookie.length; i++) {
	        var arr = arrCookie[i].split("=");
	        if (arr[0] == name) {
	            return unescape(arr[1]);
	            break;
	        }
	    }
	    return "";
	}
	$('#send_code').click(function () {
	    var telreg = /^1[3|4|5|6|7|8][0-9]{9}$/;
	    var namereg = /^[\u4E00-\u9FA5]{1,5}$/;
	    var telval = $('.jx-list-contact #phone').val();
	    var nameLength = $('.jx-list-contact #name').val().length;
	    var name = $('.jx-list-contact #name').val();
	    var telLength = $('.jx-list-contact #phone').val().length;
	    if (nameLength < 2 || nameLength > 6) {
	        showToast('姓名请填写2-6位字符');
	        return false;
	    } else if (!namereg.test(name)) {
	        showToast('请填写中文名字！');
	        return false;
	    } else if (telLength === 0) {
	        showToast('请填写您的手机号');
	        return false;
	    } else if (!telreg.test(telval)) {
	        showToast('请填写正确的手机号');
	        return false;
	    }
	    // var id58 = ''
	    // id58 = getCookieValue('id58');
	    var d = new Date();
	    var time = d.getTime();
	    $.ajax({
	        dataType: 'json',
	        type: 'get',
	        url: 'http://user.jxedt.com/captcha/get',
	        // headers: {
	        //     'id58': id58
	        // },
	        data: {
	            t: 1,
	            m: 2,
	            p: 1,
	            mobile: telval,
	            _: time
	        },
	        // jsonpCallback: 'callback',
	        success: function success(res) {
	            if (res.code == 0) {
	                var n = 60;
	                window.rid = res.result.rid;
	                $('.jx-list-contact #send_code').css({
	                    "background-color": "#F2F2F2",
	                    "color": "#00C356",
	                    "cursor": "default"
	                });
	                $('.jx-list-contact #send_code').prop("disabled", "true");
	                timer = setInterval(function () {
	                    if (n <= 1) {
	                        $('.jx-list-contact #send_code').prop("disabled", "false");
	                        clearInterval(timer);
	                        $('.jx-list-contact #send_code').css({
	                            "background-color": "#00C356",
	                            "color": "#FFFFFF",
	                            "cursor": "pointer"
	                        });
	                        $('.jx-list-contact #send_code').html('发送验证码');
	                    } else {
	                        $('.jx-list-contact #send_code').html(--n + 's');
	                    }
	                }, 1000);
	            } else {
	                showToast(res.msg);
	            }
	        }
	    });
	});

	function clear_input() {
	    $('.jx-list-contact #name').val("");
	    $('.jx-list-contact #phone').val("");
	    $('.jx-list-contact #code').val("");
	    $('.jx-list-contact #address_map').val("");
	}
	$("#submit_contact").click(function () {
	    var nameLength = $('.jx-list-contact #name').val().length;
	    var name = $('.jx-list-contact #name').val();
	    var address = $('.jx-list-contact #address_map').val();
	    var telLength = $('.jx-list-contact #phone').val().length;
	    var verLength = $('.jx-list-contact #code').val().length;
	    var select_type = $('.jx-list-contact .select-type').val();
	    var namereg = /^[\u4E00-\u9FA5]{1,5}$/;
	    if (nameLength < 2 || nameLength > 6) {
	        showToast('姓名请填写2-6位字符');
	        return;
	    } else if (!namereg.test(name) || name === $('#name').attr('placeholder')) {
	        showToast('请填写中文姓名！');
	        return;
	    } else if (telLength === 0 || $('#phone').val().trim() === $('#phone').attr('placeholder')) {
	        showToast('请填写您的手机号');
	        return;
	    } else if (telLength != 11) {
	        showToast('请填写正确的手机号');
	        return;
	    } else if (verLength != 4 || $('#code').val().trim() === $('#code').attr('placeholder')) {
	        showToast('请输入4位验证');
	        return;
	    } else if (address == "" || address === $('#address_map').attr('placeholder')) {
	        showToast('请选择上车地点');
	        return;
	    }
	    var r_id = window.rid;
	    $("#subForm #name1").val($("#name").val());
	    $("#subForm #mobile").val($("#phone").val());
	    $("#subForm #licensetype").val(select_type);
	    $("#subForm #messageid").val(r_id);
	    $("#subForm #validcode").val($("#code").val());
	    $("#subForm #address").val($("#address_map").val());
	    var t = $('#subForm').serializeArray();
	    $.ajax({
	        dataType: "json",
	        type: "post",
	        url: $("#subForm").attr("action"),
	        data: t,
	        success: function success(res) {
	            if (res.code == 0) {
	                showToast("提交成功");
	                clear_input();
	                clearInterval(timer);
	                $('.jx-list-contact #send_code').css({
	                    "background-color": "#00C356",
	                    "color": "#FFFFFF",
	                    "cursor": "pointer"
	                });
	                $('.jx-list-contact #send_code').html('发送验证码');
	                hit("JXEDT_JXLB_XIANSUO_TJ");
	            } else {
	                showToast(res.msg);
	            }
	        }
	    });
	    // $.ajax({
	    //     dataType: "json",
	    //     type: "post",
	    //     url: "http://businessapitest.58v5.cn/signup/platformsignup/",
	    //     data: {
	    //         "name": $("#name").val(),
	    //         "mobile": $("#phone").val(),
	    //         "validcode": $("#code").val(),
	    //         "licensetype": select_type,
	    //         "source": 2,
	    //         "messageid": r_id
	    //     },
	    //     success: function (e) {
	    //         if (0 == e.code) {
	    //             showToast("提交成功");
	    //             clear_input();
	    //             hit("JXEDT_JXLB_XIANSUO_TJ");
	    //             $('.pop-btn').addClass('pop-btn-gray');
	    //         } else {
	    //             showToast(e.msg);
	    //         }
	    //     }
	    // })
	});
	$(".city-detail").on('click', 'a', function (ev) {
	    $(".city-detail").children().removeClass("active");
	    $(this).addClass('active');
	});

	$(".license-type").on('click', 'a', function (ev) {
	    $(".license-type").children().removeClass("active");
	    $(this).addClass('active');
	});

	$(".price-between").on('click', 'a', function (ev) {
	    $(".price-between").children().removeClass("active");
	    $(this).addClass('active');
	});

	// 排序方式埋点
	$(".sort-mode").on('click', 'a', function (ev) {
	    hit($(this).attr("data-track"));
	    $(".sort-mode").children().removeClass("active");
	    $(this).addClass('active');
	});

	// 驾校入住
	$(".right-nav-img-admission").click(function () {
	    hit("JXEDT_JXLB_SIGNIN_R_JX");
	});

	// 驾校推荐占位埋点
	$(".jx-recommend-imgs a").click(function () {
	    hit("JXEDT_JXLB_GG_1");
	});

	//驾校推荐列表埋点
	$(".jx-recommend-detailed a").click(function () {
	    hit($(this).attr("data-track"));
	});

	//添加本地存储信息
	function changelocationtoup(obj) {
	    var baseurl = obj.getAttribute("urlpath");
	    var basename = obj.getAttribute("rulname");
	    cookie.set("local_city", basename);
	    cookie.set("local_city_pingying", baseurl);
	    window.location.href = baseurl;
	}

	function isnumberzzs(v) {
	    var re = /^[1-9]+[0-9]*]*$/;
	    return re.test(v);
	}
	$(".jx-list-position a").click(function () {
	    changelocationtoup(this);
	});
	$(".city-detail .rul").click(function () {
	    changelocationtoup(this);
	});

	function dmo() {
	    var a = "展示";
	}
	var Goto = function Goto() {};

	//因外层没有调用，gulp打包会忽略此函数，所以需要自调一下
	function selfTuning() {
	    Goto = function Goto(types, values, urlstr, pycity, pro) {
	        var arrayreturn = new Array();
	        arrayreturn[0] = "";
	        arrayreturn[1] = "";
	        arrayreturn[2] = "";
	        arrayreturn[3] = "";
	        arrayreturn[4] = "";
	        arrayreturn[5] = "";
	        arrayreturn[6] = "";
	        arrayreturn[7] = "";
	        var tmpstr = "";
	        var urlstrlist = urlstr.split("/");
	        var changeright = 0;
	        if (types == "area" && values == "") {
	            if (isnumberzzs(urlstrlist[0])) {
	                urlstrlist[0] = "";
	                changeright = 1;
	            }
	        }
	        for (var urli = 0; urli < urlstrlist.length; urli++) {
	            if (urlstrlist[urli].indexOf(types) != -1) {
	                if (values == "") {
	                    urlstrlist[urli] = "";
	                } else {
	                    urlstrlist[urli] = urlstrlist[urli].replace(urlstrlist[urli], types + "_" + values);
	                }
	                changeright = 1;
	            }
	            if (urlstrlist[urli] != "") {
	                tmpstr = urlstrlist[urli] + "/" + tmpstr;
	            }
	        }
	        if (changeright == 0 && values != "") {
	            tmpstr = types + "_" + values + "/" + urlstr;
	        }
	        if (tmpstr.substring(tmpstr.length - 1, tmpstr.length) == "/") {
	            tmpstr = tmpstr.substring(0, tmpstr.length - 1);
	        }
	        var urlstroutlist = tmpstr.split("/");
	        for (var urlj = 0; urlj < urlstroutlist.length; urlj++) {
	            if (isnumberzzs(urlstroutlist[urlj])) {
	                arrayreturn[0] = urlstroutlist[urlj];
	            }
	            if (urlstroutlist[urlj].indexOf("license") != -1) arrayreturn[1] = urlstroutlist[urlj];
	            if (urlstroutlist[urlj].indexOf("class") != -1) arrayreturn[2] = urlstroutlist[urlj];
	            if (urlstroutlist[urlj].indexOf("shuttle") != -1) arrayreturn[3] = urlstroutlist[urlj];
	            if (urlstroutlist[urlj].indexOf("scale") != -1) arrayreturn[4] = urlstroutlist[urlj];
	            if (urlstroutlist[urlj].indexOf("model") != -1) arrayreturn[5] = urlstroutlist[urlj];
	            if (urlstroutlist[urlj].indexOf("price") != -1) arrayreturn[6] = urlstroutlist[urlj];
	            if (urlstroutlist[urlj].indexOf("orderby") != -1) arrayreturn[7] = urlstroutlist[urlj];
	        }
	        var outtmpstr = "";
	        for (var urlk = 0; urlk <= 7; urlk++) {
	            if (arrayreturn[urlk] != "") outtmpstr = outtmpstr + "/" + arrayreturn[urlk];
	        }
	        var changeurlstr = "";
	        if (pro == "" || pro == null) {
	            changeurlstr = "http://" + document.location.hostname;
	        } else {
	            changeurlstr = "http://" + document.location.hostname + "/" + pro;
	        }
	        if (pycity != "") {
	            changeurlstr = changeurlstr + "/" + pycity;
	        }
	        changeurlstr = changeurlstr + outtmpstr + "/";

	        window.location = changeurlstr;
	    };

	    function isnumberzzs(v) {
	        var re = /^[1-9]+[0-9]*]*$/;
	        return re.test(v);
	    }
	    $(".go_to").click(function () {
//	        var enumType = this.getAttribute("enumType");
//	        var enumValue = this.getAttribute("enumValue");
//	        var selectpath = this.getAttribute("selectpath");
//	        var areastr = this.getAttribute("areastr");
//	        var citystr = this.getAttribute("citystr");
//	        Goto(enumType, enumValue, selectpath, areastr, citystr);
	    });
	}

	selfTuning();

/***/ })
/******/ ]);