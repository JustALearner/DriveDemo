using System.Collections.Generic;
using System.Web.Mvc;

namespace Drive.WebApp.Models
{
    public class Resources
    {

        public List<DriveSchool> DriveSchools()
        {

            return new List<DriveSchool>
            {
                new DriveSchool
                {
                    ActionUrl = "/Home/sghxView", Comment = "点评66条", Address = "重庆市南岸区学府大道2号附84号深港凯旋驾校",
                    ImageUrl = "/Scripts/drive/n_v2dd947dc71a574ab0b8755bf4fb1bc370_69159f461eca33ef.jpg",
                    Name = "深港凯旋驾校",
                    Type = new string[]
                        {"师生班自动挡", "师生班手动挡", "无忧班自动挡", "无忧班手动挡", "标准班自动挡", "标准班手动挡"},
                    Money = "3290",
                    License="c1 c2"

                },
                new DriveSchool
                {
                    ActionUrl = "/Home/stjxView", Comment = "点评0条", Address = "上海市闵行区世界茶饮(莘庄店)",
                    ImageUrl = "/Scripts/drive/n_v273458d823d23407aaeaeff0fea6f9588_a5acbd00abd608a0.jpg",
                    Name = "申通驾校",
                    Type = new string[]
                        {"江苏班", "上海班", "上海班自动挡", "江苏班自动挡"},
                    Money = "5980",
                    License="c2"
                },
                new DriveSchool
                {
                    ActionUrl = "/Home/hyjxView", Comment = "点评66条", Address = "杭州市下城区和平广场",
                    ImageUrl = "/Scripts/drive/n_v219efda40436f4553b443e85b0875fb7d_347c7f8f3f8abc6f.jpg",
                    Name = "杭邮驾校共赢学车打铁关分校", Type = new string[]
                        {"手动挡", "特惠自动挡"},
                    Money = "4850",
                    License="c1 c2"
                },
                new DriveSchool
                {
                    ActionUrl = "/Home/sdjxView", Comment = "点评0条", Address = "重庆市北碚区滩口街",
                    ImageUrl = "/Scripts/drive/n_v267e7c6e071bf4599825a711db560feb0_1d2f8c96df73b884.jpg",
                    Name = "赛达驾校北碚报名点", Type = new string[]
                        {"B1大众班", "B2无忧班", "A1全包班", "B2全包班"},
                    Money = "9000",
                    License="A1 A2 B1 B2"
                },
                new DriveSchool
                {
                    ActionUrl = "/Home/hyjxfxView", Comment = "点评66条", Address = "杭州市滨江区杭州杭邮机动车驾驶员培训有限公司",
                    ImageUrl = "/Scripts/drive/n_v252c8775f0d7d4fe3a5a78a2dda2851bc_8dbddaca0485401b.jpg",
                    Name = "杭邮驾校共赢分校", Type = new string[]
                        {"特惠自动挡", "手动挡"},
                    Money = "4850",
                    License="c1"
                },
                new DriveSchool
                {
                    ActionUrl = "/Home/nhjxView", Comment = "点评0条", Address = "湖北省武汉市洪山区新千家街12号",
                    ImageUrl = "/Scripts/drive/n_v2c4f51e8bfbfe4bafb921cdf19b8bfb7c_31778da3c133c8b0.jpg",
                    Name = "南湖驾校",
                    Type = new string[]
                        {"无忧保过班", "学生班", "分期付款班", "普通班", "自动挡", "金牌教练班", "预定班"},
                    Money = "500",
                    License="c1 c2"
                },
                new DriveSchool
                {
                    ActionUrl = "/Home/hyView", Comment = "点评66条", Address = "重庆市江北区大兴村·美连口腔-公交车站",
                    ImageUrl = "/Scripts/drive/n_v23977771ac68749af8b6c6c566bd10179_48f1d53cb160aaf2.jpg",
                    Name = "翰阳驾校",
                    Type = new string[]
                        {"B2 特惠班", ">C2 精品班", "C1 精品班", "C2 大众班", "C1 大众班"},
                    Money = "3280",
                    License="c1 c2 b2"
                },
                new DriveSchool
                {
                    ActionUrl = "", Comment = "点评66条", Address = "广东省深圳市龙华区民治大道321",
                    ImageUrl = "/Scripts/drive/n_v2859ce18a3f91460e99b021d5d40fde14_c21ab63f67496299.jpg",
                    Name = "深南驾校",
                    Type = new string[]
                        {"品质班", "惠州班", "无忧班", "无忧班手动挡", "普通班"},
                    Money = "1000",
                    License="c1"
                },
                new DriveSchool
                {
                    ActionUrl = "", Comment = "点评0条", Address = "海南省海口市龙华区茉莉路6",
                    ImageUrl = "/Scripts/drive/n_v2bd5446a76a2a437c982ee6f7883f509b_e48bcadba8795576.jpg",
                    Name = "金盘驾校",
                    Type = new string[]
                        {"精英快速自动挡班", "商务全包自动挡班", "精英快速手动挡班", "商务全包手动班","限时特惠自动挡班","限时特惠手动挡班"},
                    Money = "3990",
                    License="c1 c2"
                },
                new DriveSchool
                {
                    ActionUrl = "", Comment = "点评66条", Address = "广东省深圳市龙华区民治大道660",
                    ImageUrl = "/Scripts/drive/n_v2fe0a9208e27f4a14a216f8291e684792_692b1ea662c04288.jpg",
                    Name = " 广安驾校 ", Type = new string[]
                        {"清远班，陆丰班", "深圳班","先学后付，可分期付款"},
                    Money = "4980",
                    License="c1 c2"
                },
                new DriveSchool
                {
                    ActionUrl = "", Comment = "点评0条", Address = "广东省中山市中山市",
                    ImageUrl = "/Scripts/drive/n_v2b13508fdf4a64af7b80455b302eaf42a_c57ba09fa5f15ae4.jpg",
                    Name = "溜溜驾校", Type = new string[]
                        {"惠州品质班", "自考班", "深圳品质班", "深圳无忧班"},
                    Money = "5180",
                    License="c1 c2 b1 b2"
                },
                new DriveSchool
                {
                    ActionUrl = "", Comment = "点评66条", Address = "广东省深圳市南山区南油路2009号",
                    ImageUrl = "/Scripts/drive/n_v2946bbd3c69764cac8e22cdecfc1669c5_72e551deff26ece3.jpg",
                    Name = " 南山学车", Type = new string[]
                        {"惠州品质班", "自考班","深圳品质班"},
                    Money = "5480",
                    License="c1 c2"
                },
                new DriveSchool
                {
                    ActionUrl = "", Comment = "点评0条", Address = "福州市仓山区庆隆驾校",
                    ImageUrl = "/Scripts/drive/n_v255147fa5c12c44eea8295c8b25045601_75ccbeb8bc613e2b.jpg",
                    Name = "庆隆驾校仓山分校",
                    Type = new string[]
                        {"B2大货车培训", "分期学车0利息", "新年特惠 立减800", "自动挡新年特惠班", "手动挡新年特惠班"},
                    Money = "3880"
                    ,
                    License="b2"
                },
                new DriveSchool
                {
                    ActionUrl = "", Comment = "点评66条", Address = "广东省广州市海珠区新港东路",
                    ImageUrl = "/Scripts/drive/n_v2f466788ddce44027a481d9bc0fd4ec3c_82bea6996f3a1e6e.jpg",
                    Name = "弈启学车",
                    Type = new string[]
                        {"C1普通班", "c2普通班", "c1学生班", "c2学生班"},
                    Money = "6180",
                    License="c1 c2"
                },
                new DriveSchool
                {
                    ActionUrl = "", Comment = "点评66条", Address = "广东省深圳市南山区科兴路10号",
                    ImageUrl = "/Scripts/drive/n_v2fa9201033931441da02f38927d11adf3_756075c9c32c6916.jpg",
                    Name = "快学车驾校",
                    Type = new string[]
                        {"深圳标准班", "深圳无忧班", "新春劲爆优惠", "惠州班"},
                    Money = "7680",
                    License="c1 c2"
                },
                new DriveSchool
                {
                    ActionUrl = "", Comment = "点评0条", Address = "广东省广州市天河区天河路478号",
                    ImageUrl = "/Scripts/drive/n_v2b1b9e25fb3b4402596de7f177de3d87d_6054d25426eabbf8.jpg",
                    Name = "鑫航驾校",
                    Type = new string[]
                        {"广州州C2", "B2增驾", "A1", "考场特快班"},
                    Money = "1000",
                    License="c1 c2 a1 b2"
                },
                new DriveSchool
                {
                    ActionUrl = "", Comment = "点评66条", Address = "福建省福州市鼓楼区光荣路60-29号",
                    ImageUrl = "/Scripts/drive/n_v2d32a68d43ba747f0a8ac4e2ad7a6c682_e78c7869faa56ad9.jpg",
                    Name = "庆隆驾校", Type = new string[]
                        {"分期学车班", "白湖亭学车特惠班","新店学车特惠班","东二环学车特惠班","浦上学车特惠班"},
                    Money = "3879",
                    License="c1 c2"
                },
                new DriveSchool
                {
                    ActionUrl = "", Comment = "点评0条", Address = "重庆市江北区观音桥朗晴广场B塔41楼",
                    ImageUrl = "/Scripts/drive/n_v2f3852f0272764ba992b8c45cfd2ff468_97e2f0a9601139e0.jpg",
                    Name = "峰宇驾校", Type = new string[]
                        {"C2自动挡", "C1手动挡 "},
                    Money = "3180",
                    License="c1 c2"
                },
                new DriveSchool
                {
                    ActionUrl = "", Comment = "点评66条", Address = "广东省深圳市南山区科文路3-南门",
                    ImageUrl = "/Scripts/drive/n_v2436434e727414d63afc2c82a8e0d7ec8_b45d9ed06973c9b0.jpg",
                    Name = "深南驾校", Type = new string[]
                        {"品质班", "惠州班","无忧班","标准班"},
                    Money = "3399",
                    License="c1 c2"
                },
                new DriveSchool
                {
                    ActionUrl = "", Comment = "点评0条", Address = "上海市浦东新区12号",
                    ImageUrl = "/Scripts/drive/n_v259abe782858548c6907e36e3d5d53573_68140d31deea483c.jpg",
                    Name = "华程驾校浦东分校",
                    Type = new string[]
                        {"上海驾照一人一车"},
                    Money = "4800",
                    License="c1 c2"
                },
                new DriveSchool
                {
                    ActionUrl = "", Comment = "点评66条", Address = "上海市浦东新区光明驾校",
                    ImageUrl = "/Scripts/drive/n_v228441d2f895245349fd20cba3e21cb6f_243595835fe14830.jpg",
                    Name = "申沪驾校",
                    Type = new string[]
                        {"上海班自动档", "江苏VIP", "江苏班自动档", "江苏班", "上海VIP班"},
                    Money = "3280",
                    License="c1 c2"
                }

            };
        }
    }
}