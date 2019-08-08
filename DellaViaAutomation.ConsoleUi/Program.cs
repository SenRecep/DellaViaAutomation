using DellaViaAutomation.Bll.ComplexType;
using DellaViaAutomation.Entities.ComplexType;
using DellaViaAutomation.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.ConsoleUi
{
    class Program
    {
        static void Main(string[] args)
        {
            print("Program basladi");

           
            nesne_ozellikleri();

            print("Islemler bitmistir");
            Console.ReadLine();
        }
        static void nesne_ozellikleri()
        {
            var T1 = DateTime.Now;
            Type[] types = new Type[] {
                typeof(Basket),
                typeof(Category),
                typeof(Order),
                typeof(PostalCode),
                typeof(Product),
                typeof(Status),
                typeof(Ticket),
                typeof(User),
                typeof(UserAddress),
                typeof(Menu),
                typeof(FoodandBeverage),
            };

            foreach (var type in types)
            {
                print("");
                print(type.Name + " {");
                PropertyInfo[] propertyInfos = type.GetProperties();
                foreach (var property in propertyInfos)
                {
                    print($"  ({property.PropertyType.Name}) {property.Name}");
                }
                print("}");
                print("");
            }

            var res = DateTime.Now - T1;
            print(res.ToString());

        }
        public static void print(string str)
        {
            str = str.Insert(0, "  ");
            Console.WriteLine(str);
            System.Diagnostics.Debug.WriteLine(str);
        }
    }
}
