using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Bll.ComplexType
{
    public static class DataController
    {
        public static void DbDispose()
        {
            DellaViaAutomation.Dal.ComplexType.EntityFramework.DataController.DbDispose();
        }
        public static void DbBuild()
        {
            DellaViaAutomation.Dal.ComplexType.EntityFramework.DataController.DbBuild();
        }
        public static bool DbisLife()
        {
            return DellaViaAutomation.Dal.ComplexType.EntityFramework.DataController.DbLife();
        }
        public static void DbSave()
        {
            DellaViaAutomation.Dal.ComplexType.EntityFramework.DataController.DbSaveChanges();
        }
        public static int DbSaveChangesresult()
        {
            return DellaViaAutomation.Dal.ComplexType.EntityFramework.DataController.DbSaveChangesresult;
        }

        public static int DbSaveResult()
        {
            DbSave();
            return DbSaveChangesresult();
        }
    }
}
