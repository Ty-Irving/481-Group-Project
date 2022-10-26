namespace CookingInstructor.Data;

public class Recipes
{
    public CookingInstructor.RecipeNS.Recipe[] getRecipes(){
        CookingInstructor.RecipeNS.Recipe[] res = {
            new CookingInstructor.RecipeNS.Recipe{ 
                Name = "Braised Pork With Beancurd Sheet", 
                Category = "Chinese",
                IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                 {new CookingInstructor.RecipeNS.Ingredient("Pork","g",500),
                                  new CookingInstructor.RecipeNS.Ingredient("Beancurd Sheet","g",250),
                                  new CookingInstructor.RecipeNS.Ingredient("Red Paper","g",20),
                                  new CookingInstructor.RecipeNS.Ingredient("Black Bean","g",5), 
                                  new CookingInstructor.RecipeNS.Ingredient("Dark Soy Sauce","g",10),
                                  new CookingInstructor.RecipeNS.Ingredient("Seasoning Soy Sauce","g",15),
                                  new CookingInstructor.RecipeNS.Ingredient("Soy Sauce","g",15),
                                  new CookingInstructor.RecipeNS.Ingredient("Oyster Flavoured Sauce","g",5),
                                  new CookingInstructor.RecipeNS.Ingredient("Garlic","pieces",4),
                                  new CookingInstructor.RecipeNS.Ingredient("Ginger","g",5), 
                                  new CookingInstructor.RecipeNS.Ingredient("Onion Green","g",50),
                                  new CookingInstructor.RecipeNS.Ingredient("Oil","g",25)},
                Steps = new String[]
                        {"1. Put the pork inside a container and fill with cold water that covers it, wait for 1.5 ~ 2 hours",
                         "2. Cut the Beancurd Sheet into small slices( 15 ~ 20cm long, 2cm wide), and knot it.",
                         "3. Use cold water to wash all the knoted Beancurd Sheets and put them somewhere convinence.",
                         "4. Cut part of Onion Greens into small pieces(Don't cut them all), as well as red paper.",
                         "5. Once the pork is soaked long enough, remove all the water.You should see the soaked water become red, since blood was came out.Then gently rinse it and put in a container.",
                         "6. Heat your pot, add some Oil, Black bean, little bit chopped Onion Green, Garlic, Ginger. And fry until it smells fragrant.",
                         "7. Add the pork and keep frying till the pork looks somehow brownish yellow.",
                         "8. Add both Dark soy sauce and Soy sauce then keep frying till the pork becomes evenly dark.",
                         "9. Add some water that covers the pork.",
                         "10. Add knoted Beancurd Sheets, red paper, Onion Green(not chopped). Then cover the pot and wait for sometime(depends on the water left in pot), remember to check the water level, we don't want to charred it. ",
                         "11. Once the water level gets low, you can pick the Onion Green out and throw them. Maybe taste a piece of pork and decide whether you want to stew it longer, since we want the pork become soft to chew. If so, add more water and keep wait.",
                         "12. When you think the pork is soft enough for you, remove the pot cover and keep frying. We want the pork to absorb some soup in order to make it tasty. Then at the time you believe you are done, close the fire and try a piece, you still get this chance to add some salt if you want to do so. Finally, serve out on a plate, sprinkle with some chopped green onion."},
                Spicy = 2,
                Difficulty = 2,
                Time = 3,
                Servings = 3,
                CaloriesPerServing = 621,
                isFavorite = false
            }
        };
        return res;
    }

}