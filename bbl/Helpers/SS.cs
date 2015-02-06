using SubSonic.Repository;
using System.Linq;

namespace bbl.Helpers
{
    public class SS {
        public static SimpleRepository GetRepo() {
            return GetRepo("bbl");
        }

        public static SimpleRepository GetRepo(string db) {
            var rm = System.Configuration.ConfigurationManager.AppSettings["RunMigrations"];
            if (rm == "true")
                return new SimpleRepository(db, SimpleRepositoryOptions.RunMigrations);
            else
                return new SimpleRepository(db, SimpleRepositoryOptions.Default);
        }

        public static void UpdateDB() { 
            var repo = new SimpleRepository("bbl", SimpleRepositoryOptions.RunMigrations);
        }
    }
}