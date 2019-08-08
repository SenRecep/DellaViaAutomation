using DellaViaAutomation.Entities.Abstract;

namespace DellaViaAutomation.Entities.Concreate
{
    public class Toppings : IToppings
    {
        public int Id { get; set; }
        public string ToppingName{ get; set; }
        public double Price { get; set; }
    }
}