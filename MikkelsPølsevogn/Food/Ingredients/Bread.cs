using System;
using System.Collections.Generic;
using System.Text;

namespace MikkelsPølsevogn.Food
{
    class Bread: Ingredient
    {
        

        public Bread()
        {
            Name = "Bread";
            TimeToCook = 1;
            TimeInStock = 20;
            AmountToProduce = 1;
    }
    }
}
