using System;

namespace MikkelsPølsevogn
{
    class Program
    {
        static void Main(string[] args)
        {
            IngredientProducer produceer = new IngredientProducer();

            foreach (var inredient in produceer.ProduceIngredients("Roasted Saugsage"))
            {
                Console.WriteLine(inredient.Name); 
            }
            Console.ReadLine();
        }
    }
}
