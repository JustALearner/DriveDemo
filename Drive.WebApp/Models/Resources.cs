using System.Collections.Generic;
using System.Web.Mvc;

namespace Drive.WebApp.Models
{
    public static class Resources
    {
        
        public static List<DriveSchool> DriveSchools => new List<DriveSchool>
        {
            new DriveSchool {ActionUrl ="/Home/sghxView", Comment = "点评66条", Address = "重庆市南岸区学府大道2号附84号深港凯旋驾校", ImageUrl = "/Scripts/drive/n_v2dd947dc71a574ab0b8755bf4fb1bc370_69159f461eca33ef.jpg", Name = "深港凯旋驾校", Type =new string[]
                {"师生班自动挡","师生班手动挡","无忧班自动挡","无忧班手动挡","标准班自动挡","标准班手动挡"}, Money="3290"},
            new DriveSchool {ActionUrl = "/Home/stjxView", Comment = "点评0条", Address = "上海市闵行区世界茶饮(莘庄店)", ImageUrl = "/Scripts/drive/n_v273458d823d23407aaeaeff0fea6f9588_a5acbd00abd608a0.jpg", Name = "申通驾校", Type =new string[]
                {"江苏班","上海班","上海班自动挡","江苏班自动挡"}, Money="5980"},
            new DriveSchool {ActionUrl ="/Home/hyjxView", Comment = "点评66条", Address = "杭州市下城区和平广场", ImageUrl = "/Scripts/drive/n_v219efda40436f4553b443e85b0875fb7d_347c7f8f3f8abc6f.jpg", Name = "杭邮驾校共赢学车打铁关分校", Type =new string[]
                {"手动挡","特惠自动挡"}, Money="4850"},
            new DriveSchool {ActionUrl = "/Home/sdjxView", Comment = "点评0条", Address = "重庆市北碚区滩口街", ImageUrl = "/Scripts/drive/n_v267e7c6e071bf4599825a711db560feb0_1d2f8c96df73b884.jpg", Name = "赛达驾校北碚报名点", Type =new string[]
                {"B1大众班","B2无忧班","A1全包班","B2全包班"}, Money="9000"},
            new DriveSchool {ActionUrl ="/Home/hyjxfxView", Comment = "点评66条", Address = "杭州市滨江区杭州杭邮机动车驾驶员培训有限公司", ImageUrl = "/Scripts/drive/n_v252c8775f0d7d4fe3a5a78a2dda2851bc_8dbddaca0485401b.jpg", Name = "杭邮驾校共赢分校", Type =new string[]
                {"特惠自动挡","手动挡"}, Money="4850"},
            new DriveSchool {ActionUrl = "/Home/nhjxView", Comment = "点评0条", Address = "湖北省武汉市洪山区新千家街12号", ImageUrl = "/Scripts/drive/n_v2c4f51e8bfbfe4bafb921cdf19b8bfb7c_31778da3c133c8b0.jpg", Name = "南湖驾校", Type =new string[]
                {"无忧保过班","学生班","分期付款班","普通班","自动挡","金牌教练班","预定班"}, Money="500"},
            new DriveSchool {ActionUrl ="/Home/hyView", Comment = "点评66条", Address = "重庆市江北区大兴村·美连口腔-公交车站", ImageUrl = "/Scripts/drive/n_v23977771ac68749af8b6c6c566bd10179_48f1d53cb160aaf2.jpg", Name = "翰阳驾校", Type =new string[]
                {"B2 特惠班",">C2 精品班","C1 精品班","C2 大众班","C1 大众班"}, Money="3280"},
             new DriveSchool {ActionUrl ="/Home/sghxView", Comment = "点评66条", Address = "重庆市南岸区学府大道2号附84号深港凯旋驾校", ImageUrl = "/Scripts/drive/n_v2dd947dc71a574ab0b8755bf4fb1bc370_69159f461eca33ef.jpg", Name = "深港凯旋驾校", Type =new string[]
                {"师生班自动挡","师生班手动挡","无忧班自动挡","无忧班手动挡","标准班自动挡","标准班手动挡"}, Money="3290"},
            new DriveSchool {ActionUrl = "/Home/stjxView", Comment = "点评0条", Address = "上海市闵行区世界茶饮(莘庄店)", ImageUrl = "/Scripts/drive/n_v273458d823d23407aaeaeff0fea6f9588_a5acbd00abd608a0.jpg", Name = "申通驾校", Type =new string[]
                {"江苏班","上海班","上海班自动挡","江苏班自动挡"}, Money="5980"},
            new DriveSchool {ActionUrl ="/Home/hyjxView", Comment = "点评66条", Address = "杭州市下城区和平广场", ImageUrl = "/Scripts/drive/n_v219efda40436f4553b443e85b0875fb7d_347c7f8f3f8abc6f.jpg", Name = "杭邮驾校共赢学车打铁关分校", Type =new string[]
                {"手动挡","特惠自动挡"}, Money="4850"},
            new DriveSchool {ActionUrl = "/Home/sdjxView", Comment = "点评0条", Address = "重庆市北碚区滩口街", ImageUrl = "/Scripts/drive/n_v267e7c6e071bf4599825a711db560feb0_1d2f8c96df73b884.jpg", Name = "赛达驾校北碚报名点", Type =new string[]
                {"B1大众班","B2无忧班","A1全包班","B2全包班"}, Money="9000"},
            new DriveSchool {ActionUrl ="/Home/hyjxfxView", Comment = "点评66条", Address = "杭州市滨江区杭州杭邮机动车驾驶员培训有限公司", ImageUrl = "/Scripts/drive/n_v252c8775f0d7d4fe3a5a78a2dda2851bc_8dbddaca0485401b.jpg", Name = "杭邮驾校共赢分校", Type =new string[]
                {"特惠自动挡","手动挡"}, Money="4850"},
            new DriveSchool {ActionUrl = "/Home/nhjxView", Comment = "点评0条", Address = "湖北省武汉市洪山区新千家街12号", ImageUrl = "/Scripts/drive/n_v2c4f51e8bfbfe4bafb921cdf19b8bfb7c_31778da3c133c8b0.jpg", Name = "南湖驾校", Type =new string[]
                {"无忧保过班","学生班","分期付款班","普通班","自动挡","金牌教练班","预定班"}, Money="500"},
            new DriveSchool {ActionUrl ="/Home/hyView", Comment = "点评66条", Address = "重庆市江北区大兴村·美连口腔-公交车站", ImageUrl = "/Scripts/drive/n_v23977771ac68749af8b6c6c566bd10179_48f1d53cb160aaf2.jpg", Name = "翰阳驾校", Type =new string[]
                {"B2 特惠班",">C2 精品班","C1 精品班","C2 大众班","C1 大众班"}, Money="3280"},
             new DriveSchool {ActionUrl ="/Home/sghxView", Comment = "点评66条", Address = "重庆市南岸区学府大道2号附84号深港凯旋驾校", ImageUrl = "/Scripts/drive/n_v2dd947dc71a574ab0b8755bf4fb1bc370_69159f461eca33ef.jpg", Name = "深港凯旋驾校", Type =new string[]
                {"师生班自动挡","师生班手动挡","无忧班自动挡","无忧班手动挡","标准班自动挡","标准班手动挡"}, Money="3290"},
            new DriveSchool {ActionUrl = "/Home/stjxView", Comment = "点评0条", Address = "上海市闵行区世界茶饮(莘庄店)", ImageUrl = "/Scripts/drive/n_v273458d823d23407aaeaeff0fea6f9588_a5acbd00abd608a0.jpg", Name = "申通驾校", Type =new string[]
                {"江苏班","上海班","上海班自动挡","江苏班自动挡"}, Money="5980"},
            new DriveSchool {ActionUrl ="/Home/hyjxView", Comment = "点评66条", Address = "杭州市下城区和平广场", ImageUrl = "/Scripts/drive/n_v219efda40436f4553b443e85b0875fb7d_347c7f8f3f8abc6f.jpg", Name = "杭邮驾校共赢学车打铁关分校", Type =new string[]
                {"手动挡","特惠自动挡"}, Money="4850"},
            new DriveSchool {ActionUrl = "/Home/sdjxView", Comment = "点评0条", Address = "重庆市北碚区滩口街", ImageUrl = "/Scripts/drive/n_v267e7c6e071bf4599825a711db560feb0_1d2f8c96df73b884.jpg", Name = "赛达驾校北碚报名点", Type =new string[]
                {"B1大众班","B2无忧班","A1全包班","B2全包班"}, Money="9000"},
            new DriveSchool {ActionUrl ="/Home/hyjxfxView", Comment = "点评66条", Address = "杭州市滨江区杭州杭邮机动车驾驶员培训有限公司", ImageUrl = "/Scripts/drive/n_v252c8775f0d7d4fe3a5a78a2dda2851bc_8dbddaca0485401b.jpg", Name = "杭邮驾校共赢分校", Type =new string[]
                {"特惠自动挡","手动挡"}, Money="4850"},
            new DriveSchool {ActionUrl = "/Home/nhjxView", Comment = "点评0条", Address = "湖北省武汉市洪山区新千家街12号", ImageUrl = "/Scripts/drive/n_v2c4f51e8bfbfe4bafb921cdf19b8bfb7c_31778da3c133c8b0.jpg", Name = "南湖驾校", Type =new string[]
                {"无忧保过班","学生班","分期付款班","普通班","自动挡","金牌教练班","预定班"}, Money="500"},
            new DriveSchool {ActionUrl ="/Home/hyView", Comment = "点评66条", Address = "重庆市江北区大兴村·美连口腔-公交车站", ImageUrl = "/Scripts/drive/n_v23977771ac68749af8b6c6c566bd10179_48f1d53cb160aaf2.jpg", Name = "翰阳驾校", Type =new string[]
                {"B2 特惠班",">C2 精品班","C1 精品班","C2 大众班","C1 大众班"}, Money="3280"}

        };
    }
}