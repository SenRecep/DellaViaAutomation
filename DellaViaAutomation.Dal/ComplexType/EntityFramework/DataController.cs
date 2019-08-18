using DellaViaAutomation.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Dal.ComplexType.EntityFramework
{
    public static class DataController
    {
        private static DellaViaAutomationDbModel Db { get; set; } = new DellaViaAutomationDbModel();
        public static int DbSaveChangesresult { get; set; }
        static DataController()
        {
        }
        public static DellaViaAutomationDbModel getDb()
        {
            if (DbLife() == false)
                DbBuild();
            return Db;
        }
        public static bool DbLife()
        {
            return Db == null ? false : true;
        }
        public static void DbDispose()
        {
            if (Db != null)
            {
                Db = null;
            }
        }
        public static void DbBuild()
        {
            if (Db == null)
            {
                Db = new DellaViaAutomationDbModel();
            }
        }
        public static void DbSaveChanges()
        {
            if (DbLife() == false)
                DbBuild();
            DbSaveChangesresult = Db.SaveChanges();


        }
        public static void DbSaveChanges(out int result)
        {
            if (DbLife() == false)
                DbBuild();
            result = Db.SaveChanges();
            System.Diagnostics.Debug.WriteLine("Db.SaveChanges() Rt : " + result);
        }
        public static object GetTable<T>() where T:EntityBase
        {
            return getDb().Set<T>();
        }
    }
}

