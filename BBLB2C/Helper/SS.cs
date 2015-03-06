using SubSonic.Repository;
using System.Linq;

namespace BBLB2C.Helpers
{
    public class SS {
        public static SimpleRepository GetRepo() {
            return GetRepo("bblb2c");
        }

        public static SimpleRepository GetRepo(string db) {
            var rm = System.Configuration.ConfigurationManager.AppSettings["RunMigrations"];
            if (rm == "true")
                return new SimpleRepository(db, SimpleRepositoryOptions.RunMigrations);
            else
                return new SimpleRepository(db, SimpleRepositoryOptions.Default);
        }

        public static void UpdateDB() {
            var repo = new SimpleRepository("bblb2c", SimpleRepositoryOptions.RunMigrations);
        }
    }
}