using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jsonp
{
    public partial class group : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            string callback = Request.QueryString["jsoncallback"];
            string data = "{\"total\":1,\"per_page\":8,\"current_page\":1,\"last_page\":1,\"data\":[[{\"usersAttentionProjectsId\":19,\"userId\":33,\"projectId\":18,\"addtime\":\"2015-04-16 13:20:02\"},{\"projectId\":18,\"groups\":null,\"isGroup\":false,\"type\":7,\"name\":\"宸у厠鍔涚伀閿�\",\"period\":1,\"copyright\":1,\"difficulty\":2,\"reference\":\"\",\"source\":\"鍙跺瓙鐤�\",\"description\":\"宸у厠鍔涚伀閿呭拰濂堕叒鐏攨涓€鏍锋潵婧愪簬鐟炲＋锛屽畠灏嗗阀鍏嬪姏鍦ㄩ攨涓啍铻嶆垚宸у厠鍔涙祮锛岀劧鍚庝氦鏇夸互姘存灉鍜岄潰鍖呭潡铇镐箣椋熺敤銆傛祿绋犻婊戠殑寰俯宸у厠鍔涗笌鍙ｆ劅鐖借剢鐨勬按鏋滅浉缁撳悎锛屼氦铻嶇殑棣欏懗鍦ㄥ啲鏃ヤ腑甯︾粰浜烘殩蹇冪敎铚滐紝璁╀汉娆茬舰涓嶈兘銆傚阀鍏嬪姏鐏攨杩樺彲浠ュ拰鍐版按涓庡啺婵€娣嬫惌閰嶏紝鍐风儹浜ゆ浛甯︽潵鍐扮伀涓ら噸澶╃殑濂囧紓鎰熻銆�\",\"isForked\":false,\"forkedFrom\":0,\"forkedAncestor\":0,\"likesCount\":0,\"forksCount\":0,\"attentionCounts\":0,\"addtime\":\"2014-08-18 13:36:34\",\"updatetime\":\"2014-08-18 13:36:34\",\"status\":1,\"projectImgses\":[{\"projectImgId\":86,\"imgPath":"2014-08/18/467c3c44056b49331bcaeda1ff42b4fef77cc8be.jpg\",\"imgWidth\":640,\"imgHeight\":508,\"addtime\":\"2014-08-18 13:40:51\"}]}]]}";
            string result = string.Format("{0}{1}", callback, data);
            Response.Expires = -1;
            Response.Clear();
            Response.ContentEncoding = Encoding.UTF8;
            Response.ContentType = "application/json";
            Response.Write(result);
            Response.Flush();
            Response.End();
        }
    }
}