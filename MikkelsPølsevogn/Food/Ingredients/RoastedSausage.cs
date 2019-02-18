using System;
using System.Collections.Generic;
using System.Text;

namespace MikkelsPølsevogn.Food
{
    class RoastedSausage : Ingredient
    {
    

        public RoastedSausage()
        {
            Name = "Roasted Sausage";
            TimeToCook = 12;
            TimeInStock = 360;
            AmountToProduce = 28;
        }
    }
}
