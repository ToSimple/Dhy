using BBLB2C.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BBLB2C.Areas.Admin.BLL
{
    public class BManager
    {
        public static int Count()
        {
            return DAL.DManager.Count();
        }
        public static int Add(Manager m)
        {
            return DAL.DManager.Add(m);
        }
        public static int Update(Manager m)
        {
            return DAL.DManager.Update(m);
        }
        public static Manager FindOne(int id)
        {
            return DAL.DManager.FindOne(id);
        }
        public static List<Manager> FindList(int cur, int pageSize)
        {
            return DAL.DManager.FindList(cur, pageSize);
        }
        public static int Delete(int id)
        {
            return DAL.DManager.Delete(id);
        }
    }
}