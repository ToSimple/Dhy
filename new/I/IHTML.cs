using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newweb.I
{
    public interface IHTML
    {
        Tube DocName();
        Tube head();
        #region head子
        /// <summary>
        /// 定义标题
        /// </summary>
        /// <returns></returns>
        Tube Title();
        /// <summary>
        /// 定义所有的链接标签的默认链接
        /// </summary>
        /// <returns></returns>
        Tube Base();

        /// <summary>
        /// 定义了文档与外部资源之间的关系
        /// </summary>
        /// <returns></returns>
        Tube Link();
        /// <summary>
        /// 定义了HTML文档的样式文件引用地址
        /// </summary>
        /// <returns></returns>
        Tube Style();
        /// <summary>
        /// 为搜索引擎定义
        /// </summary>
        /// <returns></returns>
        Tube Meta();

        /// <summary>
        /// 定义加载脚本文件
        /// </summary>
        /// <returns></returns>
        Tube Script();
        #endregion
        Tube body();
        #region
        //标题
        Tube H1();
        Tube H2();
        Tube H3();
        Tube H4();
        Tube H5();
        Tube H6();
        /// <summary>
        /// 定义段落
        /// </summary>
        /// <returns></returns>
        Tube P();
        /// <summary>
        /// 定义换行
        /// </summary>
        /// <returns></returns>
        Tube Br();
        /// <summary>
        ///  定义水平线
        /// </summary>
        /// <returns></returns>
        Tube Hr();
        /// <summary>
        /// 定义注释
        /// </summary>
        /// <returns></returns>
        Tube Note();


        /// <summary>
        /// 定义粗体文本
        /// </summary>
        /// <returns></returns>
        Tube B();
        /// <summary>
        /// 定义着重文字
        /// </summary>
        /// <returns></returns>
        Tube Em();
        /// <summary>
        /// 定义斜体字
        /// </summary>
        /// <returns></returns>
        Tube I();
        /// <summary>
        /// 定义小号字
        /// </summary>
        /// <returns></returns>
        Tube Small();
        /// <summary>
        /// 定义加重语气
        /// </summary>
        /// <returns></returns>
        Tube Strong();
        /// <summary>
        /// 定义下标字
        /// </summary>
        /// <returns></returns>
        Tube Sub();
        /// <summary>
        /// 定义上标字
        /// </summary>
        /// <returns></returns>
        Tube Sup();
        /// <summary>
        /// 定义插入字
        /// </summary>
        /// <returns></returns>
        Tube Ins();
        /// <summary>
        /// 定义删除字
        /// </summary>
        /// <returns></returns>
        Tube Del();
        /// <summary>
        /// 定义超链接
        /// </summary>
        /// <returns></returns>
        Tube A();

        #endregion

    }
}
