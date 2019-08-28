using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Dal.ComplexType
{
    public static class ClassDataTransfer
    {
        public static void EntityTransmitter(object val1, object val2)
        {
            var type = val2.GetType();
            var prop = type.GetProperty("id");
            if (prop != null)
            {
                var value = prop.GetValue(val2, null);
                ObjTransmitter(val1, val2);
                prop.SetValue(val2, value);
            }
            else
                ObjTransmitter(val1, val2);
        }
        public static object ObjTransmitter(object val1, object val2)
        {
            dynamic ret;

            try
            {
                foreach (System.Reflection.PropertyInfo pi in val1.GetType().GetProperties())
                {
                    if (pi.CanWrite)
                    {
                        string propName = pi.Name;
                        var type = val1.GetType();
                        var prop = type.GetProperty(propName);
                        var value = prop.GetValue(val1, null);
                        var myType = pi.PropertyType;
                        System.Reflection.PropertyInfo propertyInfo = val2.GetType().GetProperty(propName);
                        propertyInfo.SetValue(val2, ChangeType(value, propertyInfo.PropertyType), null);
                    }
                }
            }
            catch
            {

            }

            ret = val2;
            return ret;
        }
        public static object ChangeType(object value, Type conversion)
        {
            object obj = null;

            try
            {
                var t = conversion;
                if (t.IsGenericType && t.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
                {
                    if (value == null)
                        return null;
                    t = Nullable.GetUnderlyingType(t);
                }

                obj = Convert.ChangeType(value, t);
            }
            catch
            {

            }

            return obj;
        }
    }
}
