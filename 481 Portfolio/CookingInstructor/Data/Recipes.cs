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
                                  new CookingInstructor.RecipeNS.Ingredient("Red Pepper","g",20),
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
                         "4. Cut part of Onion Greens into small pieces(Don't cut them all), as well as red pepper.",
                         "5. Once the pork is soaked long enough, remove all the water.You should see the soaked water become red, since blood was came out.Then gently rinse it and put in a container.",
                         "6. Heat your pot, add some Oil, Black bean, little bit chopped Onion Green, Garlic, Ginger. And fry until it smells fragrant.",
                         "7. Add the pork and keep frying till the pork looks somehow brownish yellow.",
                         "8. Add both Dark soy sauce and Soy sauce then keep frying till the pork becomes evenly dark.",
                         "9. Add some water that covers the pork.",
                         "10. Add knoted Beancurd Sheets, red pepper, Onion Green(not chopped). Then cover the pot and wait for sometime(depends on the water left in pot), remember to check the water level, we don't want to charred it. ",
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
                                  new CookingInstructor.RecipeNS.Ingredient("Red Pepper","g",25),
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
                         "3. Cut Red Pepper,Galic,Onion Green into pieces",
                         "4. Put all the Sauces in one container, more convenience for later useage.",
                         "5. Add 5g Onion Green, Red Pepper, Garlic, Oil and frying them for around 30 seconds.",
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
                                  new CookingInstructor.RecipeNS.Ingredient("Red Pepper","g",15),
                                  new CookingInstructor.RecipeNS.Ingredient("Rice Vinegar","g",10),
                                  new CookingInstructor.RecipeNS.Ingredient("Seasoning Soy sauce","g",5),
                                  new CookingInstructor.RecipeNS.Ingredient("Oil","g",10),
                                  new CookingInstructor.RecipeNS.Ingredient("Salt","g",3)},
                                 
                                  
                                  
                Steps = new String[]
                        {"1. Shred the Potato and wash with cold water until the water looks clean, we want to keep the Potato fresh and crisp.",
                         "2. Cut the Red Pepper into small pieces.",
                         "3. Add about 1.5L water into your pot and boil it. When you see boiling water, add Shredded Potato and Rice Vinegar, blanching for 20 seconds.After blanching, put Potato in a container(no water).",
                         "4. Clean your pot, add Oil and Red Pepper then frying till you feel sneeze.",
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
                isFavorite = false,
                stepImages = new String[] 
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
                isFavorite = false,
                stepImages = new String[] 
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
                isFavorite = false,
                stepImages = new String[] 
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
                isFavorite = false,
                stepImages = new String[] 
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
                isFavorite = false,
                stepImages = new String[] 
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
                Name = "Chili Chicken",
                Category = "Chinese",
                IngredientList = new CookingInstructor.RecipeNS.Ingredient[]{
                    new CookingInstructor.RecipeNS.Ingredient("Chicken(Drumstick)","g",700),
                    new CookingInstructor.RecipeNS.Ingredient("Chili Pepper","g",50),
                    new CookingInstructor.RecipeNS.Ingredient("Zanthoxylum","g",15),
                    new CookingInstructor.RecipeNS.Ingredient("Garlic","g",10),
                    new CookingInstructor.RecipeNS.Ingredient("Genger","g",10),
                    new CookingInstructor.RecipeNS.Ingredient("Onion Green"," ",1),
                    new CookingInstructor.RecipeNS.Ingredient("Leek"," ",1),
                    new CookingInstructor.RecipeNS.Ingredient("White Sesame","spoon",1),
                    new CookingInstructor.RecipeNS.Ingredient("pepper(powered)","spoon",1),
                    new CookingInstructor.RecipeNS.Ingredient("Cooking Wine","spoon",1),
                    new CookingInstructor.RecipeNS.Ingredient("Seasoning soy sauce","spoon",1),
                    new CookingInstructor.RecipeNS.Ingredient("Starch","spoon",1),
                    new CookingInstructor.RecipeNS.Ingredient("Sesame Oil","spoon",1),
                    new CookingInstructor.RecipeNS.Ingredient("Spicy Chili Sauce","spoon",1),
                    new CookingInstructor.RecipeNS.Ingredient("Salt","g",5),
                    new CookingInstructor.RecipeNS.Ingredient("Oil","g",100)
                },
                Steps = new String[]{
                    "1. Wash the Chicken with cold water then cut into small chunks, then put inside a container.",
                    "2. Add Salt, Powered pepper, Cooking Wine, Seasoning soy sauce and Starch into container, mix them well with hand or some tool.",
                    "3. Then add Sesame Oil into container, mix everything well and wait for 20mins.",
                    "4. Slice Garlic and Genger into pieces, diced leeks and cut Onion Green into small pieces.",
                    "5. Hot your pot and add Oils, when Oil is about 150 celsius add Chicken fried till looks golden. Then take the Chicken out, put in somewhere.",
                    "6. You can choose to remove some Oil or leave them in the pot. Add Genger, Galic and Leek fry till smells fragrant.",
                    "7. Add Chili Pepper, Zanthoxylum, Spicy Chili Sauce keep frying about 1mins.",
                    "8. Add the Chicken back to your pot keep frying and mix them well.",
                    "9. Sprinkle with chopped green onion, mix them well and we are done!"
                },
                stepImages = new String[]{
                    "",
                    "/Recipe_datas/chili chicken/1.jpg",
                    "",
                    "/Recipe_datas/chili chicken/3.jpg",
                    "/Recipe_datas/chili chicken/5.jpg",
                    "",
                    "",
                    "/Recipe_datas/chili chicken/8.jpg",
                    "/Recipe_datas/chili chicken/9.jpg"
                },
                Spicy = 3,
                Difficulty = 3,
                Time = 60,
                Servings = 2,
                CaloriesPerServing = 452,
                isFavorite = false,
            },
            new CookingInstructor.RecipeNS.Recipe{
                Name = "Beef Donburi",
                Category = "Japanese",
                IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                 {new CookingInstructor.RecipeNS.Ingredient("Beef Roll","g",200),
                                  new CookingInstructor.RecipeNS.Ingredient("Egg"," ",1),
                                  new CookingInstructor.RecipeNS.Ingredient("Onion","g",100),
                                  new CookingInstructor.RecipeNS.Ingredient("Carrot"," ",1),
                                  new CookingInstructor.RecipeNS.Ingredient("Onion Green","g",15),
                                  new CookingInstructor.RecipeNS.Ingredient("Rice","bowl",1),
                                  new CookingInstructor.RecipeNS.Ingredient("Seasoning soy sauce","spoon",1),
                                  new CookingInstructor.RecipeNS.Ingredient("Dark soy sauce","spoon",1),
                                  new CookingInstructor.RecipeNS.Ingredient("Oyster sauce","spoon",1),
                                  new CookingInstructor.RecipeNS.Ingredient("Sugar","spoon",1),
                                  new CookingInstructor.RecipeNS.Ingredient("Starch","spoon",1),
                                  new CookingInstructor.RecipeNS.Ingredient("Cooking wine","spoon",1),
                                  new CookingInstructor.RecipeNS.Ingredient("Water","g",250),
                                  new CookingInstructor.RecipeNS.Ingredient("Salt","g",3),
                                  new CookingInstructor.RecipeNS.Ingredient("Powered pepper","g",5),
                                  new CookingInstructor.RecipeNS.Ingredient("Butter","g",15),
                                  new CookingInstructor.RecipeNS.Ingredient("Sea laver","g",10)},
                Steps= new String[]{ 
                    "1. Slice Onion and Carrot.",
                    "2. Prepare sauce. Grab a container, add Seasoning soy sauce, Dark soy sauce, Cooking wine, Oyster sauce, Sugar, Starch, Salt, Water, Powered Pepper and mix them well.",
                    "3. Hot your pot and melt Butter. Then add Onion and Carrot keep frying for 2mins.",
                    "4. Add the Beef Roll and fry till it looks white. Then add the sauce we prepared before and keep frying till all ingredients mixed well.",
                    "5. Fried a Egg. Just add some Oil and heat till 200 celsius, then put the Egg in and wait about 1min.",
                    "6. First put the Egg on top of Rice, then put Beef Roll around. Done!"
                },
                stepImages = new String[]{
                    "/Recipe_datas/Beef Donburi/1.jpg",
                    "",
                    "",
                    "/Recipe_datas/Beef Donburi/2.jpg",
                    "/Recipe_datas/Beef Donburi/3.jpg",
                    "/Recipe_datas/Beef Donburi/4.jpg"
                },
                Spicy = 1,
                Difficulty = 3,
                Time = 45,
                Servings = 1,
                CaloriesPerServing = 670,
                isFavorite = false,

            },
            
            new CookingInstructor.RecipeNS.Recipe{
                Name = "French Bisque",
                Category = "French",
                IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                 {new CookingInstructor.RecipeNS.Ingredient("Pumpkin","g",300),
                                  new CookingInstructor.RecipeNS.Ingredient("Milk","g",150),
                                  new CookingInstructor.RecipeNS.Ingredient("Onion","g",50),
                                  new CookingInstructor.RecipeNS.Ingredient("Butter","g",15),
                                  new CookingInstructor.RecipeNS.Ingredient("Cream","g",75),
                                  new CookingInstructor.RecipeNS.Ingredient("Salt","g",3),
                                  new CookingInstructor.RecipeNS.Ingredient("Powered pepper","g",3),
                                 },
                Steps= new String[]{
                    "1. Slice Onion into pieces and cut Pumpkin into chunks.",
                    "2. Hot your pot and melt Butter, then add Onion and Pumpkin fry for 3mins.",
                    "3. Add 250g Water and cover the pot then turn to low heat to simmer for 5 minutes until the pumpkin is cooked, then take it out and set aside.",
                    "4. Put the pumpkin, milk and whipped cream into the wall breaker, heat and stir until it becomes a fine and smooth thick soup",
                    "5. Finally, season with salt and pepper and serve!"
                },
                stepImages = new String[]{
                    "",
                    "",
                    "/Recipe_datas/French Bisque/1.jpg",
                    "",
                    "/Recipe_datas/French Bisque/2.jpg"
                },
                Spicy = 1,
                Difficulty = 2,
                Time = 30,
                Servings = 1,
                CaloriesPerServing = 300,
                isFavorite = false,

            },

            new CookingInstructor.RecipeNS.Recipe{
                Name = "French Apple Tart",
                Category = "French",
                IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                 {new CookingInstructor.RecipeNS.Ingredient("Flour","g",230),
                                  new CookingInstructor.RecipeNS.Ingredient("Butter","g",70),
                                  new CookingInstructor.RecipeNS.Ingredient("Butter(without salt)","g",113),
                                  new CookingInstructor.RecipeNS.Ingredient("Egg"," ",1),
                                  new CookingInstructor.RecipeNS.Ingredient("Sugar","g",60),
                                  new CookingInstructor.RecipeNS.Ingredient("Apple","g",500),
                                  new CookingInstructor.RecipeNS.Ingredient("Vanilla Extract","spoon",1),
                                  new CookingInstructor.RecipeNS.Ingredient("Lemon"," ",1),
                                 },
                Steps= new String[]{
                    "1. Cut the Butter into small chucks then add into a container with Flour and 30g Sugar, mix them well.It will probably looks flocky.",
                    "2. Pour the hand-made dough onto the countertop covered with plastic wrap and level it without kneading.",
                    "3. Now we prepare the Apple sauce.First, put a low heat add 30g Sugar and slowly melt the butter on the bottom of the pot. Take two Apples and cut into small chucks and add Lemon juice in. Turn on low heat, cover and cook for about 15 minutes.Remember pound with a spoon to prevent sticky pan. Then add the Vanilla Extract,mix them well, and take out the Apple sauce.",
                    "4. Take the ready dough, fit it in a Tart container then put in refrigerator wait for 20mins.",
                    "5. Find something heavy and put on the top of our Tart, then bake 10mins(180 celsius).",
                    "6. Take out the Tart and coat a layer of egg wash inside the mold, bake in the oven for another 5 minutes. Then the Tart is done!",
                    "7. Take rest Apples and cut into pieces, first put the Apple sauce under then Apple pieces finally bake for 40mins. Done!"
                },
                stepImages = new String[]{
                    "/Recipe_datas/French Apple Tart/1.jpg",
                    "/Recipe_datas/French Apple Tart/2.jpg",
                    "/Recipe_datas/French Apple Tart/3.jpg",
                    "/Recipe_datas/French Apple Tart/4.jpg",
                    "",
                    "",
                    "/Recipe_datas/French Apple Tart/5.jpg"
                },
                Spicy = 1,
                Difficulty = 3,
                Time = 60,
                Servings = 3,
                CaloriesPerServing = 400,
                isFavorite = false,
            },

             new CookingInstructor.RecipeNS.Recipe{
                Name = "Dongpo Pork",
                Category = "Chinese",
                IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                 {new CookingInstructor.RecipeNS.Ingredient("Pork","g",500),
                                  new CookingInstructor.RecipeNS.Ingredient("Onion Green","g",20),
                                  new CookingInstructor.RecipeNS.Ingredient("Genger","g",12),
                                  new CookingInstructor.RecipeNS.Ingredient("Rock Sugar","g",30),
                                  new CookingInstructor.RecipeNS.Ingredient("Cinnamon","g",15),
                                  new CookingInstructor.RecipeNS.Ingredient("Star Anise","g",10),
                                  new CookingInstructor.RecipeNS.Ingredient("Fragrant leaves","g",1),
                                  new CookingInstructor.RecipeNS.Ingredient("Dark soy sauce","spoon",1),
                                  new CookingInstructor.RecipeNS.Ingredient("Salt","g",5),
                                 },
                Steps= new String[]{
                    "1. Hold the Pork and grill the pigskin with dry pot, don't add Oil. When the pigskin looks burnt, stop and wash it with cold water.",
                    "2. First put the Pork in cold water add Onion Green and some Genger slices then stew till you can easily poke in the Pork. Cut Pork into small squares, and put them on top of a Onion/Genger layer, pigskin towards down.",
                    "3. Add another pot of water and add everything else in. Stew for 60mins. Then take everything out, keep the leftover broth.",
                    "4. Take Pork out and put on a plate, cover with Tin foil and steam for 30mins.",
                    "5. After the Pork is done with steaming, add it back to broth and keep frying till it looks thick. Finish!"
                },
                stepImages = new String[]{
                    "/Recipe_datas/Dongpo Pork/1.jpg",
                    "/Recipe_datas/Dongpo Pork/2.jpg",
                    "/Recipe_datas/Dongpo Pork/3.jpg",
                    "/Recipe_datas/Dongpo Pork/5.jpg",
                    "/Recipe_datas/Dongpo Pork/6.jpg"
                },
                Spicy = 1,
                Difficulty = 3,
                Time = 120,
                Servings = 2,
                CaloriesPerServing = 483,
                isFavorite = false,
            },
            new CookingInstructor.RecipeNS.Recipe{
                Name = "Frying Chicken",
                Category = "America",
                IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                 {new CookingInstructor.RecipeNS.Ingredient("Chicken Wings","g",600),
                                  new CookingInstructor.RecipeNS.Ingredient("Oil","g",500),
                                  new CookingInstructor.RecipeNS.Ingredient("Flour","g",200),
                                  new CookingInstructor.RecipeNS.Ingredient("Egg","g",100),
                                  new CookingInstructor.RecipeNS.Ingredient("Powered Pepper","g",15),
                                  new CookingInstructor.RecipeNS.Ingredient("Powered Garlic","g",10),
                                  new CookingInstructor.RecipeNS.Ingredient("Powered Onion","g",10),
                                  new CookingInstructor.RecipeNS.Ingredient("Paprika","g",15),
                                  new CookingInstructor.RecipeNS.Ingredient("Salt","g",8),
                                  
                                 },
                Steps= new String[]{
                    "1. Crack Eggs and mix well with 20g water.",
                    "2. Prepare a container, add Powered Garlic, Onion, Pepper,Paprika and salt. Mix them well. Then coat Chicken with it wait for 30mins.",
                    "3. Prepare another container with Flour in it.",
                    "4. First coat with flour, then coat with Egg wash.",
                    "5. Repet step4 till you think the Chicken is ready for frying. Remember the finish step will be coat with flour, don't fry it when cover with Egg wash.",
                    "6. Add Oil in your pot and heat it. When about 200 celsius, add the Chicken in frying for 10mins.",
                    "7. Take out the Chicken and wait one minute, then put them back to Oil frying for another 1min. Finished!",
                
                },
                stepImages = new String[]{
                    "/Recipe_datas/Frying Chicken/1.jpg",
                    "",
                    "",
                    "/Recipe_datas/Frying Chicken/2.jpg",
                    "/Recipe_datas/Frying Chicken/3.jpg",
                    "",
                    "/Recipe_datas/Frying Chicken/4.jpg"
                },
                Spicy = 3,
                Difficulty = 1,
                Time = 45,
                Servings = 2,
                CaloriesPerServing = 467,
                isFavorite = false,
            }
        };
        return res;
    }

}