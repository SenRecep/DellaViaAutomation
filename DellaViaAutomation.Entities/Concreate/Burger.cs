using DellaViaAutomation.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Entities.Concreate
{
    public class Burger : IBurger
    {
        public int Id { get ; set ; }
        public string Name { get ; set ; }
        
        public ExtraBurgerItems extraBurgerItem { get; set; }
        public double Price 
        {
            get {
                return Price;
            }
            set {
                Price += extraBurgerItem.Price;
            }

        }
    }
}
