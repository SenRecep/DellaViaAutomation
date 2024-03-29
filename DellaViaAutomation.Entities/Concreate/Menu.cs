﻿using DellaViaAutomation.Entities.Abstract;
using DellaViaAutomation.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DellaViaAutomation.Entities.Concreate
{
    public class Menu : EntityBase, IMenu
    {
        public string Name { get; set; }
        public string ImageId { get; set; }
        public string OriginalFilename { get; set; }

        public int MenuCategoryid { get; set; }
        public Menu MenuCategory { get; set; }

        public ICollection<FoodandBeverage> Products { get; set; }
    }
}
