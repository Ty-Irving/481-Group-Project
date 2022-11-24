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
                Time = 25,
                Servings = 3,
                CaloriesPerServing = 621,
                isFavorite = false,
                stepImages = new String[] 
                        {"",
                         "/Recipe_datas/BraisedPork/2.jpg",
                         "",
                         "",
                         "",
                         "",
                         "",
                         "/Recipe_datas/BraisedPork/8.jpg",
                         "",
                         "",
                         "",
                         "",
                        },
                imagePath = "/BraisedPork/final.jpg"
            },
            new CookingInstructor.RecipeNS.Recipe{ 
                Name = "Mapo Tofu", 
                Category = "Chinese",
                IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                 {new CookingInstructor.RecipeNS.Ingredient("Tofu","g",700),
                                  new CookingInstructor.RecipeNS.Ingredient("Red Paper","g",25),
                                  new CookingInstructor.RecipeNS.Ingredient("Onion Green","g",15),
                                  new CookingInstructor.RecipeNS.Ingredient("Garlic","g",10),
                                  new CookingInstructor.RecipeNS.Ingredient("Oil","g",20),
                                  new CookingInstructor.RecipeNS.Ingredient("Ginger","g",20), 
                                  new CookingInstructor.RecipeNS.Ingredient("Chili Garlic Sauce ","g",30),
                                  new CookingInstructor.RecipeNS.Ingredient("Soybean Paste","g",20), 
                                  new CookingInstructor.RecipeNS.Ingredient("Spicy Chili Sauce","g",15),
                                  new CookingInstructor.RecipeNS.Ingredient("Red Hot Chili Sauce ","g",15),
                                  new CookingInstructor.RecipeNS.Ingredient("Cooking wine","g",50),
                                  new CookingInstructor.RecipeNS.Ingredient("Tapioca","g",15)},
                                 
                                  
                                  
                Steps = new String[]
                        {"1. Cut Tofu into small cubes and slice Ginger, then add 1.5L water into your pot, add Tofu, Cooking wine, sliced Ginger, wait for boiling.",
                         "2. Prepare a container, fill with cold water.Then take out the Tofu, put them in container. We want to cool down it, and make it stay like cube.",
                         "3. Cut Red Paper,Galic,Onion Green into pieces",
                         "4. Put all the Sauces in one container, more convenience for later useage.",
                         "5. Add 5g Onion Green, Red Paper, Garlic, Oil and frying them for around 30 seconds.",
                         "6. Add sauces into the pot and fry them evenly.",
                         "7. Add 600ml water into pot.",
                         "8. Add Tofu in the pot.",
                         "9. Prepare some Tapioca water ---- add Tapioca then add cold water then stir it evenly.",
                         "10. Add the Tapioca water into pot, immediately push the Tofu like following.",
                         "11. Keep the pushing loop, you will find soup becomes thick.",
                         "12. When the soup is thick enough, close the fire and add left Onion Green.",
                         "13. You'll love it with some rice."},
                Spicy = 3,
                Difficulty = 2,
                Time = 30,
                Servings = 3,
                CaloriesPerServing = 210,
                isFavorite = false,
                stepImages = new String[] 
                        {"/Recipe_datas/MapoTofu/1.jpg",
                         "",
                         "",
                         "",
                         "",
                         "",
                         "",
                         "",
                         "",
                         "",
                         "/Recipe_datas/MapoTofu/11.jpg",
                         "/Recipe_datas/MapoTofu/12.jpg",
                         ""
                        },
                        imagePath = "/Recipe_datas/MapoTofu/13.jpg"
            },
            new CookingInstructor.RecipeNS.Recipe{ 
                Name = "Spicy Fry Shredded Potato", 
                Category = "Chinese",
                IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                 {new CookingInstructor.RecipeNS.Ingredient("Potato","g",600),
                                  new CookingInstructor.RecipeNS.Ingredient("Red Paper","g",15),
                                  new CookingInstructor.RecipeNS.Ingredient("Rice Vinegar","g",10),
                                  new CookingInstructor.RecipeNS.Ingredient("Seasoning Soy sauce","g",5),
                                  new CookingInstructor.RecipeNS.Ingredient("Oil","g",10),
                                  new CookingInstructor.RecipeNS.Ingredient("Salt","g",3)},
                                 
                                  
                                  
                Steps = new String[]
                        {"1. Shred the Potato and wash with cold water until the water looks clean, we want to keep the Potato fresh and crisp.",
                         "2. Cut the Red Paper into small pieces.",
                         "3. Add about 1.5L water into your pot and boil it. When you see boiling water, add Shredded Potato and Rice Vinegar, blanching for 20 seconds.After blanching, put Potato in a container(no water).",
                         "4. Clean your pot, add Oil and Red Paper then frying till you feel sneeze.",
                         "5. Add the Shredded Potato, keep frying for 40 seconds(at least).",
                         "6. Add Salt, Seasoning Soy sauce then keep frying till Potato colored evenly.",
                         "7. Finished!"},
                Spicy = 2,
                Difficulty = 1,
                Time = 17,
                Servings = 2,
                CaloriesPerServing = 230,
                isFavorite = false,
                stepImages = new String[] 
                        {"/Recipe_datas/SpicyPotato/1.jpg",
                         "",
                         "",
                         "",
                         "",
                         "/Recipe_datas/SpicyPotato/6.jpg",
                         ""
                        },
                imagePath = "/Recipe_datas/SpicyPotato/7.jpg"
            },
              new CookingInstructor.RecipeNS.Recipe{ 
                Name = "Tomato-Egg Noodle", 
                Category = "Chinese",
                IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                 {new CookingInstructor.RecipeNS.Ingredient("Tomato","g",200),
                                  new CookingInstructor.RecipeNS.Ingredient("Egg","g",50),
                                  new CookingInstructor.RecipeNS.Ingredient("Noodle","g",75),
                                  new CookingInstructor.RecipeNS.Ingredient("Onion Green","g",15),
                                  new CookingInstructor.RecipeNS.Ingredient("Oil","g",20),
                                  new CookingInstructor.RecipeNS.Ingredient("Salt","g",3)},
                                 
                                  
                                  
                Steps = new String[]
                        {"1. Cut Onion Green and Tomato into pieces.",
                         "2. Hot your pot then add Tomato and 1.5g Salt in, keep frying till it looks like tomato paste.",
                         "3. Add 500ml water into your pot, add 1.5g salt again then wait for the water boiling.",
                         "4. When the water boiling add the Egg and Noodles. Stir them gentlely, you don't want Noodles stick with pot.",
                         "5. At least boil the Noodle for 3min then you can add some Onion Green and close fire.",
                         "6. Enjoy!"},
                Spicy = 1,
                Difficulty = 1,
                Time = 15,
                Servings = 1,
                CaloriesPerServing = 300,
                isFavorite = false,
                stepImages = new String[] 
                        {"",
                         "",
                         "",
                         "",
                         "",
                         ""
                        },
                imagePath = "/Recipe_datas/TomatoEggNoodle/6.jpg"
            },
            new CookingInstructor.RecipeNS.Recipe{ 
                Name = "Tomato with Egg", 
                Category = "Chinese",
                IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                 {new CookingInstructor.RecipeNS.Ingredient("Tomato","g",200),
                                  new CookingInstructor.RecipeNS.Ingredient("Egg","g",200),
                                  new CookingInstructor.RecipeNS.Ingredient("Onion Green","g",10),
                                  new CookingInstructor.RecipeNS.Ingredient("Oil","g",70),
                                  new CookingInstructor.RecipeNS.Ingredient("Salt","g",5)},
                                 
                                  
                                  
                Steps = new String[]
                        {"1. Cut Onion Green into small pieces.",
                         "2. Cut Tomato into small chunks.",
                         "3. Stir Eggs with 2g Salt evenly.",
                         "4. Hot your pot and add 50g Oil, when Oil temperature reach around 150 Celsius add Egg then wait it becomes stable. Then use your slice poke it into pieces.",
                         "5. Take out the Egg, we will now cook the Tomato.",
                         "6. Add Tomato, Onion Green, 20g Oil and 3g Salt then keep frying till it looks like tomato paste.",
                         "7. Then add Egg back to pot, frying for 30 seconds. Done!"},
                Spicy = 1,
                Difficulty = 1,
                Time = 15,
                Servings = 2,
                CaloriesPerServing = 480,
                isFavorite = false
                ,stepImages = new String[] 
                        {"",
                         "",
                         "",
                         "",
                         "",
                         "",
                         ""
                        },
                imagePath = "/Recipe_datas/TomatoWithEgg/7.jpg"
            },

            new CookingInstructor.RecipeNS.Recipe{ 
                Name = "Margaiana - Dummy", 
                Category = "Italian",
                IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                 {new CookingInstructor.RecipeNS.Ingredient("Dummy","g",200),
                                  new CookingInstructor.RecipeNS.Ingredient("Dummy","g",200),
                                  new CookingInstructor.RecipeNS.Ingredient("Dummy","g",10),
                                  new CookingInstructor.RecipeNS.Ingredient("Dummy","g",70),
                                  new CookingInstructor.RecipeNS.Ingredient("Dummy","g",5)},
                                 
                                  
                                  
                Steps = new String[]
                        {"1. Dummy",
                         "2. Cut Tomato into small chunks.",
                         "3. Stir Eggs with 2g Salt evenly.",
                         "4. Hot your pot and add 50g Oil, when Oil temperature reach around 150 Celsius add Egg then wait it becomes stable. Then use your slice poke it into pieces.",
                         "5. Take out the Egg, we will now cook the Tomato.",
                         "6. Add Tomato, Onion Green, 20g Oil and 3g Salt then keep frying till it looks like tomato paste.",
                         "7. Then add Egg back to pot, frying for 30 seconds. Done!"},
                Spicy = 1,
                Difficulty = 1,
                Time = 15,
                Servings = 2,
                CaloriesPerServing = 480,
                isFavorite = false
                ,stepImages = new String[] 
                        {"",
                         "",
                         "",
                         "",
                         "",
                         "",
                         ""
                        }
            },

            new CookingInstructor.RecipeNS.Recipe{ 
                Name = "Margaiana - Dummy", 
                Category = "Asian",
                IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                 {new CookingInstructor.RecipeNS.Ingredient("Dummy","g",200),
                                  new CookingInstructor.RecipeNS.Ingredient("Dummy","g",200),
                                  new CookingInstructor.RecipeNS.Ingredient("Dummy","g",10),
                                  new CookingInstructor.RecipeNS.Ingredient("Dummy","g",70),
                                  new CookingInstructor.RecipeNS.Ingredient("Dummy","g",5)},
                                 
                                  
                                  
                Steps = new String[]
                        {"1. Dummy",
                         "2. Cut Tomato into small chunks.",
                         "3. Stir Eggs with 2g Salt evenly.",
                         "4. Hot your pot and add 50g Oil, when Oil temperature reach around 150 Celsius add Egg then wait it becomes stable. Then use your slice poke it into pieces.",
                         "5. Take out the Egg, we will now cook the Tomato.",
                         "6. Add Tomato, Onion Green, 20g Oil and 3g Salt then keep frying till it looks like tomato paste.",
                         "7. Then add Egg back to pot, frying for 30 seconds. Done!"},
                Spicy = 1,
                Difficulty = 1,
                Time = 15,
                Servings = 2,
                CaloriesPerServing = 480,
                isFavorite = false
                ,stepImages = new String[] 
                        {"",
                         "",
                         "",
                         "",
                         "",
                         "",
                         ""
                        }
            },

            new CookingInstructor.RecipeNS.Recipe{ 
                Name = "Margaiana - Dummy", 
                Category = "European",
                IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                 {new CookingInstructor.RecipeNS.Ingredient("Dummy","g",200),
                                  new CookingInstructor.RecipeNS.Ingredient("Dummy","g",200),
                                  new CookingInstructor.RecipeNS.Ingredient("Dummy","g",10),
                                  new CookingInstructor.RecipeNS.Ingredient("Dummy","g",70),
                                  new CookingInstructor.RecipeNS.Ingredient("Dummy","g",5)},
                                 
                                  
                                  
                Steps = new String[]
                        {"1. Dummy",
                         "2. Cut Tomato into small chunks.",
                         "3. Stir Eggs with 2g Salt evenly.",
                         "4. Hot your pot and add 50g Oil, when Oil temperature reach around 150 Celsius add Egg then wait it becomes stable. Then use your slice poke it into pieces.",
                         "5. Take out the Egg, we will now cook the Tomato.",
                         "6. Add Tomato, Onion Green, 20g Oil and 3g Salt then keep frying till it looks like tomato paste.",
                         "7. Then add Egg back to pot, frying for 30 seconds. Done!"},
                Spicy = 1,
                Difficulty = 1,
                Time = 15,
                Servings = 2,
                CaloriesPerServing = 480,
                isFavorite = false
                ,stepImages = new String[] 
                        {"",
                         "",
                         "",
                         "",
                         "",
                         "",
                         ""
                        }
            },

            new CookingInstructor.RecipeNS.Recipe{ 
                Name = "Tofu Bowl - Dummy", 
                Category = "Western",
                IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                 {new CookingInstructor.RecipeNS.Ingredient("Dummy","g",200),
                                  new CookingInstructor.RecipeNS.Ingredient("Dummy","g",200),
                                  new CookingInstructor.RecipeNS.Ingredient("Dummy","g",10),
                                  new CookingInstructor.RecipeNS.Ingredient("Dummy","g",70),
                                  new CookingInstructor.RecipeNS.Ingredient("Dummy","g",5)},
                                 
                                  
                                  
                Steps = new String[]
                        {"1. Dummy",
                         "2. Cut Tomato into small chunks.",
                         "3. Stir Eggs with 2g Salt evenly.",
                         "4. Hot your pot and add 50g Oil, when Oil temperature reach around 150 Celsius add Egg then wait it becomes stable. Then use your slice poke it into pieces.",
                         "5. Take out the Egg, we will now cook the Tomato.",
                         "6. Add Tomato, Onion Green, 20g Oil and 3g Salt then keep frying till it looks like tomato paste.",
                         "7. Then add Egg back to pot, frying for 30 seconds. Done!"},
                Spicy = 1,
                Difficulty = 3,
                Time = 40,
                Servings = 2,
                CaloriesPerServing = 480,
                isFavorite = false
                ,stepImages = new String[] 
                        {"",
                         "",
                         "",
                         "",
                         "",
                         "",
                         ""
                        }
            },
        };
        return res;
    }

}