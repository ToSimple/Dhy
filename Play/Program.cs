using Play.BuilderPattern;
//using Play.FactoryPattern;
//using Play.FactoryPatternOfAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Play
{
    class Program
    {
        static void Main(string[] args)
        {
            MealBuilder mealBuilder = new MealBuilder();
            Meal vegMeal = mealBuilder.prepareVegMeal();
            Console.WriteLine("Veg Meal");
            vegMeal.showItems();
            Console.WriteLine("Total Cost: " + vegMeal.getCost());

            Meal nonVegMeal = mealBuilder.prepareNonVegMeal();
            Console.WriteLine("\n\nNon-Veg Meal");
            nonVegMeal.showItems();
            Console.WriteLine("Total Cost: " + nonVegMeal.getCost());
        }
        //static void Main(string[] args)
        //{
        //    //获取形状工厂
        //    AbstractFactory monsterFactory = FactoryProducer.getFactory("MONSTER");

        //    //获取形状为 Circle 的对象
        //    IMonster ORC = monsterFactory.getMonster("ORC");

        //    //调用 Circle 的 draw 方法
        //    ORC.Say();

        //    //获取形状为 Rectangle 的对象
        //    IMonster WOLFMAN = monsterFactory.getMonster("WOLFMAN");

        //    //调用 Rectangle 的 draw 方法
        //    WOLFMAN.Say();

        //    //获取形状为 Square 的对象
        //    IMonster GHOST = monsterFactory.getMonster("GHOST");

        //    //调用 Square 的 draw 方法
        //    GHOST.Say();

        //    //获取颜色工厂
        //    AbstractFactory WeaponFactory = FactoryProducer.getFactory("Weapon");

        //    //获取颜色为 Red 的对象
        //    IWeapon BOW = WeaponFactory.getWeapon("BOW");

        //    //调用 Red 的 fill 方法
        //    BOW.Equip();

        //    //获取颜色为 Green 的对象
        //    IWeapon SWORD = WeaponFactory.getWeapon("SWORD");

        //    //调用 Green 的 fill 方法
        //    SWORD.Equip();

        //    //获取颜色为 Blue 的对象
        //    IWeapon SPEAR = WeaponFactory.getWeapon("SPEAR");

        //    //调用 Blue 的 fill 方法
        //    SPEAR.Equip();
        //}

        //static void Main(string[] args)
        //{
        //    MonsterFactory mf = new MonsterFactory();
        //    mf.GetMonster("Orc").Say();
        //    mf.GetMonster("Wolfman").Say();
        //}


        #region old
        //static void Main(string[] args)
        //{
        //    工厂 bobo的工厂 = new 工厂() { 工厂ID = 1, 工厂老大 = "dhy", 工厂利润 = 1000, 工厂资金 = 100000, 工厂坐标 = "国家机密" };
        //    工厂 小逗比的工厂 = new 工厂() { 工厂ID = 1, 工厂老大 = "小逗比", 工厂利润 = 1000, 工厂资金 = 1, 工厂坐标 = "525,511" };

        //    集合<工厂> 地球内所有工厂 = new 集合<工厂>();
        //    地球内所有工厂.添加(bobo的工厂);
        //    地球内所有工厂.添加(小逗比的工厂);

        //    工厂 目标工厂 = 地球内所有工厂.查找<工厂>(q => q.工厂老大 == "小逗比");
        //    播报("发现小逗比工厂坐标:" + 目标工厂.工厂坐标);
        //    播报("导弹发射！！！！");
        //    if (地球内所有工厂.向目标发射导弹<工厂>(a => a.工厂坐标 == 目标工厂.工厂坐标))
        //    {
        //        播报("小孩工厂已被摧毁!!!!!");
        //    }

        //}
        //public static void 播报(string s)
        //{
        //    Console.WriteLine(s);
        //}  
        #endregion
    }

    public class 集合<T>
    {
        static List<T> item = new List<T>();
        public void 添加(T model)
        {
            item.Add(model);
        }
        public T 查找<T>(Expression<Func<T, bool>> expression) where T : class, new()
        {
            Func<T, bool> func = expression.Compile();
            foreach (var a in item)
            {
                if (func(a as T))
                {
                    return a as T;
                }
            }
            return null;
        }
        public bool 向目标发射导弹<T>(Expression<Func<T, bool>> expression) where T : class, new()
        {

            Expression<Func<int, bool>> ex = x => x < 100;

            Func<int, bool> func1 = ex.Compile();
            func1(5);

            Func<T, bool> func = expression.Compile();
            foreach (var a in item)
            {
                if (func(a as T))
                {
                    item.Remove(a);
                    return true;
                }
            }
            return false;
        }

    }

    public class 工厂
    {
        public int 工厂ID { get; set; }
        public int 工厂资金 { get; set; }
        public int 工厂利润 { get; set; }
        public string 工厂老大 { get; set; }
        public string 工厂坐标 { get; set; }

    }

}
