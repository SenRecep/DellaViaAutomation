using DellaViaAutomation.Dal.Abstract;
using DellaViaAutomation.Dal.ComplexType.EntityFramework;
using DellaViaAutomation.Entities.ComplexType;
using DellaViaAutomation.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Dal.Concreate.EntityFramework.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public Category GetCategoryByName(string categoryName)
        {
            var category = DataController.getDb().Categories.FirstOrDefault(c => c.Name == categoryName);

            return category;
        }
    }
    public class UserRepository : RepositoryBase<User>, IUserRepository{}
    public class PostalCodeRepository : RepositoryBase<PostalCode>, IPostalCodeRepository { }
    public class UserAddressRepository : RepositoryBase<UserAddress>, IUserAddressRepository { }
    public class StatusRepository : RepositoryBase<Status>, IStatusRepository { }
    public class ProductRepository : RepositoryBase<Product>, IProductRepository { }
    public class BasketRepository : RepositoryBase<Basket>, IBasketRepository { }
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository { }
    public class OrderProductRepository : RepositoryBase<OrderProduct>, IOrderProductRepository { }
    public class OrderPaymentRepository : RepositoryBase<OrderPayment>, IOrderPaymentRepository { }

}
