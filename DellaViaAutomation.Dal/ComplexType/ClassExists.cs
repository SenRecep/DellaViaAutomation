using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DellaViaAutomation.Dal.ComplexType
{
    public static class ClassExists
    {
        public static bool Exists(this Entities.ComplexType.EntityBase entityBase, object obj1, object obj2)
        {
            var type1 = obj1.GetType();
            var type2 = obj2.GetType();
            bool exist = true;

            foreach (PropertyInfo pi in type1.GetProperties())
            {
                string propName = pi.Name;
                if (propName != "id")
                {
                    PropertyInfo prop1 = type1.GetProperty(propName);
                    PropertyInfo prop2 = type2.GetProperty(propName);
                    var value = prop1.GetValue(obj1, null);
                    var value2 = prop2.GetValue(obj2, null);
                    if (value != value2)
                    {
                        exist = false;
                        break;
                    }
                }

            }
            return exist;
        }
    }
}
