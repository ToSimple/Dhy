using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BBLB2C.Areas.Admin.Models;
namespace BBLB2C.Areas.Admin.DAL
{
    public class DManager
    {
        public static int Count()
        {
            var _repo = BBLB2C.Helpers.SS.GetRepo();
            int r = _repo.All<Manager>().Count();
            return r;
        }
        public static int Add(Manager m)
        {
            var _repo = BBLB2C.Helpers.SS.GetRepo();
            _repo.Add<Manager>(m);
            if (m.id != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public static int Update(Manager m)
        {
            var _repo = BBLB2C.Helpers.SS.GetRepo();
            int i = _repo.Update<Manager>(m);
            if (i > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public static Manager FindOne(int id)
        {
            var _repo = BBLB2C.Helpers.SS.GetRepo();
            Manager model = _repo.Find<Manager>(q => q.id == id).FirstOrDefault();
            return model;
        }

        public static List<Manager> FindList(int cur, int pageSize)
        {
            var _repo = BBLB2C.Helpers.SS.GetRepo();
            List<Manager> items = _repo.All<Manager>().Skip((cur - 1) * pageSize).Take(pageSize).ToList();
            return items;
        }

        internal static int Delete(int id)
        {
            var _repo = BBLB2C.Helpers.SS.GetRepo();
            int i = _repo.Delete<Manager>(id);
            return i;
        }
    }
}