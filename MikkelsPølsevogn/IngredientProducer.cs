using MikkelsPølsevogn.Food;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MikkelsPølsevogn
{
    class IngredientProducer
    {
        public Ingredient IngredientToProduce;

        public Queue<Ingredient> ProduceIngredients(string ingredient)
        {
            
            switch (ingredient)
            {
                case "Roasted Saugsage":
                    IngredientToProduce = new RoastedSausage();
                    break;
                case "Bread":
                    IngredientToProduce = new Bread();
                   
                    break;
                default:
                    break;
            }

            Queue<Ingredient> result = new Queue<Ingredient>();
            for (int i = 0; i < IngredientToProduce.AmountToProduce; i++)
            {
                
                result.Enqueue(IngredientToProduce);
            }

            return result;
        }
    }
}
