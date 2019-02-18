using System;
using System.Collections.Generic;
using System.Text;

namespace MikkelsPølsevogn.Food
{
    abstract class Ingredient
    {
        public string Name;
        public float TimeToCook;
        public float TimeInStock;
        public int AmountToProduce;
    }
}
