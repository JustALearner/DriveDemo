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

    //�Զ����� 2�벥��һ�� ����ѭ��
    var timer = '';
    var num = 0;
    /*timer=setInterval(function(){ //�򿪶�ʱ��
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
//��һ��
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
//        ��һ��
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


