using System.Collections.Generic;
namespace DellaViaAutomation.Entities.Abstract
{
    using Entities.ComplexType;
    public interface IFoodandBeverage
    {
        FoodandBeverageSize FoodandBeverageSize { get; set; }
        ICollection<FoodandBeverage> Products { get; set; }
    }
}
