using DellaViaAutomation.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Entities.ComplexType
{
    public static class Helpers
    {
        static Type[] types = new Type[] {
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
                typeof(MenuCategory),
                typeof(OrderPayment),
                typeof(OrderProduct),
            };
        public static Type[] GetTypes()
        {
            return types;
        }
    }
}
