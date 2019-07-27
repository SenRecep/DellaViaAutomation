using DellaViaAutomation.Dal.Abstract.Infrastructure;
using DellaViaAutomation.Entities.ComplexType;
using DellaViaAutomation.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Dal.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category GetCategoryByName(string categoryName);
    }
    public interface IUserRepository : IRepository<User>{}
    public interface IPostalCodeRepository : IRepository<PostalCode>{ }
    public interface IUserAddressRepository : IRepository<UserAddress> { }
    public interface IStatusRepository : IRepository<Status> { }
    public interface IProductRepository : IRepository<Product> { }
    public interface IBasketRepository : IRepository<Basket> { }
    public interface IOrderRepository : IRepository<Order> { }
    public interface IOrderProductRepository : IRepository<OrderProduct> { }
    public interface IOrderPaymentRepository : IRepository<OrderPayment> { }
    public interface IFoodRepository : IRepository<Food> { }
}
