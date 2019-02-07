var step = 1230;
var list = 5;
$(function () {

    //var list=$('.bot-img ul li').length;
    $('.activeimg').css({
        width: list * step,
    });
    $('.right').click(function () {
        next(list)

    })
    $('.left').click(function () {
        prev(list)
    });

    //自动播放 2秒播放一次 无限循环
    var timer = '';
    var num = 0;
    /*timer=setInterval(function(){ //打开定时器
        num++;
        if(num>parseFloat(list)-1){
            num=0;
            $('.activeimg').animate({left:num*-step},"slow");
        }else{
            $('.activeimg').animate({left:num*-step},"slow");
        }
    },2000);*/
})
var index = 0;
//下一张
function next(list) {
    if (index < list - 1) {
        index++;
        $('.activeimg').animate({ left: index * -step }, "slow");
        $('.bot-img ul li').eq(index).addClass('active').siblings('li').removeClass('active')
    } else {
        index = 0;
        $('.activeimg').animate({ left: index * -step }, "slow");
        $('.bot-img ul li').eq(index).addClass('active').siblings('li').removeClass('active')
    }
}
//        上一张
function prev(list) {
    index--;
    if (index < 0) {
        index = list - 1;
        $('.activeimg').animate({ left: index * -step }, "slow");
        $('.bot-img ul li').eq(index).addClass('active').siblings('li').removeClass('active')
    } else {
        $('.activeimg').animate({ left: index * -step }, "slow");
        $('.bot-img ul li').eq(index).addClass('active').siblings('li').removeClass('active')
    }
}


