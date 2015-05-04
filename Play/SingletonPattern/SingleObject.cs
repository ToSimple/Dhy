using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play.SingletonPattern
{
    public class SingleObject
    {
        //创建 SingleObject 的一个对象
        private static SingleObject instance = new SingleObject();

        //让构造函数为 private，这样该类就不会被实例化
        private SingleObject() { }

        //获取唯一可用的对象
        public static SingleObject getInstance()
        {
            return instance;
        }

        public void showMessage()
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class LazyOne
    {
        private static LazyOne instance;
        private LazyOne() { }
        public static LazyOne getInstance()
        {
            if (instance == null)
            {
                instance = new LazyOne();
            }
            return instance;
        }
    }
    /// <summary>
    /// 经典懒汉
    /// </summary>
    public class lazyMore
    {
        private volatile static lazyMore _instance = null;
        private static readonly object lockHelper = new object();
        private lazyMore() { }
        public static lazyMore getInstance()
        {
            if (_instance == null)
            {
                lock (lockHelper)
                {
                    if (_instance == null)
                        _instance = new lazyMore();
                }
            }
            return _instance;
        }
    }
    /// <summary>
    /// 饿汉模式
    /// </summary>
    public class lazyMost
    {
        private lazyMost() { }
        public static readonly lazyMost getInstance = new lazyMost();
    }
}
