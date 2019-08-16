using DellaViaAutomation.Bll.Concreate;
using DellaViaAutomation.Dal.Abstract.Infrastructure;
using DellaViaAutomation.Dal.Concreate.EntityFramework.Repositories;
using DellaViaAutomation.Entities.ComplexType;
using DellaViaAutomation.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Bll.ComplexType
{
    public static class ManagerBuilder
    {
        public static EntityManager<User> UserManager => new EntityManager<User>(new UserRepository());
        public static EntityManager<PostalCode> PostalCodeManager => new EntityManager<PostalCode>(new PostalCodeRepository());
        public static EntityManager<UserAddress> UserAddressManager => new EntityManager<UserAddress>(new UserAddressRepository());
        public static EntityManager<Status> StatusManager => new EntityManager<Status>(new StatusRepository());
        public static EntityManager<Category> CategoryManager => new EntityManager<Category>(new CategoryRepository());
        public static EntityManager<Product> ProductManager => new EntityManager<Product>(new ProductRepository());
        public static EntityManager<Basket> BasketManager => new EntityManager<Basket>(new BasketRepository());
        public static EntityManager<Order> OrderManager => new EntityManager<Order>(new OrderRepository());
        public static EntityManager<OrderProduct> OrderProductManager => new EntityManager<OrderProduct>(new OrderProductRepository());
        public static EntityManager<OrderPayment> OrderPaymentManager => new EntityManager<OrderPayment>(new OrderPaymentRepository());
        public static EntityManager<Ticket> TicketManager => new EntityManager<Ticket>(new TicketRepository());
        public static EntityManager<FoodandBeverage> FoodandBeverageManager => new EntityManager<FoodandBeverage>(new FoodandBeverageRepository());
        public static EntityManager<Menu> MenuManager => new EntityManager<Menu>(new MenuRepository());
        public static EntityManager<MenuCategory> MenuCategoryManager => new EntityManager<MenuCategory>(new MenuCategoryRepository());
    }
}
