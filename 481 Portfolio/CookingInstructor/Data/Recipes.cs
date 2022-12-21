namespace CookingInstructor.Data;

public class Recipes
{
    private static CookingInstructor.RecipeNS.Recipe[] list = new CookingInstructor.RecipeNS.Recipe[]{
        new CookingInstructor.RecipeNS.Recipe{
            Name = "Braised Pork With Beancurd Sheet",
            Category = "Chinese",
            IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                {new CookingInstructor.RecipeNS.Ingredient("Pork","g",500),
                                new CookingInstructor.RecipeNS.Ingredient("Beancurd","g",250),
                                new CookingInstructor.RecipeNS.Ingredient("Bell Pepper","g",20),
                                new CookingInstructor.RecipeNS.Ingredient("Black Bean","g",5),
                                new CookingInstructor.RecipeNS.Ingredient("Dark Soy Sauce","g",10),
                                new CookingInstructor.RecipeNS.Ingredient("Soy Sauce","g",15),
                                new CookingInstructor.RecipeNS.Ingredient("Soy Sauce","g",15),
                                new CookingInstructor.RecipeNS.Ingredient("Oyster Flavoured Sauce","g",5),
                                new CookingInstructor.RecipeNS.Ingredient("Garlic","pieces",4),
                                new CookingInstructor.RecipeNS.Ingredient("Ginger","g",5),
                                new CookingInstructor.RecipeNS.Ingredient("Green Onion","g",50),
                                new CookingInstructor.RecipeNS.Ingredient("Oil","g",25)},
            Steps = new String[]
                    {"1. Put the pork inside a container and fill with cold water that covers it, wait for 1.5 ~ 2 hours",
                        "2. Cut the Beancurd Sheet into small slices( 15 ~ 20cm long, 2cm wide), and knot it.",
                        "3. Use cold water to wash all the knoted Beancurd Sheets and put them somewhere convinence.",
                        "4. Cut part of Green Onions into small pieces(Don't cut them all), as well as Bell Pepper.",
                        "5. Once the pork is soaked long enough, remove all the water.You should see the soaked water become red, since blood was came out.Then gently rinse it and put in a container.",
                        "6. Heat your pot, add some Oil, Black bean, little bit chopped Green Onion, Garlic, Ginger. And fry until it smells fragrant.",
                        "7. Add the pork and keep frying till the pork looks somehow brownish yellow.",
                        "8. Add both Dark soy sauce and Soy sauce then keep frying till the pork becomes evenly dark.",
                        "9. Add some water that covers the pork.",
                        "10. Add knoted Beancurd Sheets, Bell Pepper, Green Onion(not chopped). Then cover the pot and wait for sometime(depends on the water left in pot), remember to check the water level, we don't want to charred it. ",
                        "11. Once the water level gets low, you can pick the Green Onion out and throw them. Maybe taste a piece of pork and decide whether you want to stew it longer, since we want the pork become soft to chew. If so, add more water and keep wait.",
                        "12. When you think the pork is soft enough for you, remove the pot cover and keep frying. We want the pork to absorb some soup in order to make it tasty. Then at the time you believe you are done, close the fire and try a piece, you still get this chance to add some salt if you want to do so. Finally, serve out on a plate, sprinkle with some chopped green onion."},
            Spicy = true,
            Specialty = CookingInstructor.RecipeNS.Classification.normal,
            Difficulty = 2,
            Time = 120,
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
            importance = Enumerable.Repeat(false, 12).ToArray(),
            imagePath = "/BraisedPork/final.jpg"
        },
        new CookingInstructor.RecipeNS.Recipe{ 
            Name = "Mapo Tofu", 
            Category = "Chinese",
            IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                {new CookingInstructor.RecipeNS.Ingredient("Tofu","g",700),
                                new CookingInstructor.RecipeNS.Ingredient("Bell Pepper","g",25),
                                new CookingInstructor.RecipeNS.Ingredient("Green Onion","g",15),
                                new CookingInstructor.RecipeNS.Ingredient("Garlic","g",10),
                                new CookingInstructor.RecipeNS.Ingredient("Oil","g",20),
                                new CookingInstructor.RecipeNS.Ingredient("Ginger","g",20), 
                                new CookingInstructor.RecipeNS.Ingredient("Garlic","g",30),
                                new CookingInstructor.RecipeNS.Ingredient("Soybean Paste","g",20), 
                                new CookingInstructor.RecipeNS.Ingredient("Spicy Chili Sauce","g",15),
                                new CookingInstructor.RecipeNS.Ingredient("Red Hot Chili Sauce ","g",15),
                                new CookingInstructor.RecipeNS.Ingredient("Cooking Wine","g",50),
                                new CookingInstructor.RecipeNS.Ingredient("Tapioca","g",15)},
                                
                                
                                
            Steps = new String[]
                    {"1. Cut Tofu into small cubes and slice Ginger, then add 1.5L water into your pot, add Tofu, Cooking wine, sliced Ginger, wait for boiling.",
                        "2. Prepare a container, fill with cold water.Then take out the Tofu, put them in container. We want to cool down it, and make it stay like cube.",
                        "3. Cut Bell Pepper,Garlic, Green Onion into pieces",
                        "4. Put all the Sauces in one container, more convenience for later useage.",
                        "5. Add 5g Green Onion, Bell Pepper, Garlic, Oil and frying them for around 30 seconds.",
                        "6. Add sauces into the pot and fry them evenly.",
                        "7. Add 600ml water into pot.",
                        "8. Add Tofu in the pot.",
                        "9. Prepare some Tapioca water ---- add Tapioca then add cold water then stir it evenly.",
                        "10. Add the Tapioca water into pot, immediately push the Tofu like following.",
                        "11. Keep the pushing loop, you will find soup becomes thick.",
                        "12. When the soup is thick enough, close the fire and add left Green Onion.",
                        "13. You'll love it with some rice."},
            Spicy = true,
            Specialty = CookingInstructor.RecipeNS.Classification.vegi,
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
                        "/Recipe_datas/MapoTofu/13.jpg"
                    },
            importance = System.Linq.Enumerable.Repeat(false, 13).ToArray(),
            imagePath = "/Recipe_datas/MapoTofu/final.jpg"
        },
        new CookingInstructor.RecipeNS.Recipe{ 
            Name = "Spicy Fry Shredded Potato", 
            Category = "Chinese",
            IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                {new CookingInstructor.RecipeNS.Ingredient("Potato","g",600),
                                new CookingInstructor.RecipeNS.Ingredient("Bell Pepper","g",15),
                                new CookingInstructor.RecipeNS.Ingredient("Rice Vinegar","g",10),
                                new CookingInstructor.RecipeNS.Ingredient("Soy Sauce","g",5),
                                new CookingInstructor.RecipeNS.Ingredient("Oil","g",10),
                                new CookingInstructor.RecipeNS.Ingredient("Salt","g",3)},
                                
                                
                                
            Steps = new String[]
                    {"1. Shred the Potato and wash with cold water until the water looks clean, we want to keep the Potato fresh and crisp.",
                        "2. Cut the Bell Pepper into small pieces.",
                        "3. Add about 1.5L water into your pot and boil it. When you see boiling water, add Shredded Potato and Rice Vinegar, blanching for 20 seconds.After blanching, put Potato in a container(no water).",
                        "4. Clean your pot, add Oil and Bell Pepper then frying till you feel sneeze.",
                        "5. Add the Shredded Potato, keep frying for 40 seconds(at least).",
                        "6. Add Salt, Seasoning Soy sauce then keep frying till Potato colored evenly.",
                        "7. Finished!"},
            Spicy = true,
            Specialty = CookingInstructor.RecipeNS.Classification.normal,
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
            importance = Enumerable.Repeat(false, 7).ToArray(),
            imagePath = "/Recipe_datas/SpicyPotato/7.jpg"
        },
            new CookingInstructor.RecipeNS.Recipe{ 
            Name = "Tomato-Egg Noodle", 
            Category = "Chinese",
            IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                {new CookingInstructor.RecipeNS.Ingredient("Tomato","g",200),
                                new CookingInstructor.RecipeNS.Ingredient("Egg","g",50),
                                new CookingInstructor.RecipeNS.Ingredient("Noodle","g",75),
                                new CookingInstructor.RecipeNS.Ingredient("Green Onion","g",15),
                                new CookingInstructor.RecipeNS.Ingredient("Oil","g",20),
                                new CookingInstructor.RecipeNS.Ingredient("Salt","g",3)},
                                
                                
                                
            Steps = new String[]
                    {"1. Cut Green Onion and Tomato into pieces.",
                        "2. Hot your pot then add Tomato and 1.5g Salt in, keep frying till it looks like tomato paste.",
                        "3. Add 500ml water into your pot, add 1.5g salt again then wait for the water boiling.",
                        "4. When the water boiling add the Egg and Noodles. Stir them gentlely, you don't want Noodles stick with pot.",
                        "5. At least boil the Noodle for 3min then you can add some Green Onion and close fire.",
                        "6. Enjoy!"},
            Spicy = false,
            Specialty = CookingInstructor.RecipeNS.Classification.vegi,
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
            importance = Enumerable.Repeat(false, 6).ToArray(),
            imagePath = "/Recipe_datas/TomatoEggNoodle/6.jpg"
        },
        new CookingInstructor.RecipeNS.Recipe{ 
            Name = "Tomato with Egg", 
            Category = "Chinese",
            IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                {new CookingInstructor.RecipeNS.Ingredient("Tomato","g",200),
                                new CookingInstructor.RecipeNS.Ingredient("Egg","g",200),
                                new CookingInstructor.RecipeNS.Ingredient("Green Onion","g",10),
                                new CookingInstructor.RecipeNS.Ingredient("Oil","g",70),
                                new CookingInstructor.RecipeNS.Ingredient("Salt","g",5)},
                                
                                
                                
            Steps = new String[]
                    {"1. Cut Green Onion into small pieces.",
                        "2. Cut Tomato into small chunks.",
                        "3. Stir Eggs with 2g Salt evenly.",
                        "4. Hot your pot and add 50g Oil, when Oil temperature reach around 150 Celsius add Egg then wait it becomes stable. Then use your slice poke it into pieces.",
                        "5. Take out the Egg, we will now cook the Tomato.",
                        "6. Add Tomato, Green Onion, 20g Oil and 3g Salt then keep frying till it looks like tomato paste.",
                        "7. Then add Egg back to pot, frying for 30 seconds. Done!"},
            Spicy = false,
            Specialty = CookingInstructor.RecipeNS.Classification.vegi,
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
            importance = Enumerable.Repeat(false, 7).ToArray(),
            imagePath = "/Recipe_datas/TomatoWithEgg/7.jpg"
        },
        
        new CookingInstructor.RecipeNS.Recipe{ 
            Name = "German Potato Salad", 
            Category = "European",
            IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                {new CookingInstructor.RecipeNS.Ingredient("Potato","cups",3),
                                new CookingInstructor.RecipeNS.Ingredient("Bacon"," slices",4),
                                new CookingInstructor.RecipeNS.Ingredient("Onion", "x",1),
                                new CookingInstructor.RecipeNS.Ingredient("Vinegar","cup",1/4), 
                                new CookingInstructor.RecipeNS.Ingredient("Water","tbs",2),
                                new CookingInstructor.RecipeNS.Ingredient("Sugar","tbs",2),
                                new CookingInstructor.RecipeNS.Ingredient("Salt","tsp",1),
                                new CookingInstructor.RecipeNS.Ingredient("Pepper","tsp",1/8),
                                new CookingInstructor.RecipeNS.Ingredient("Parsley","tbsp",1)},
            Steps = new String[]
                    {"1. Place potatoes in a large pot and add water to cover by at least 1 to 2 inches; bring to a boil.",
                        "2. Cook until potatoes are easily pierced with a fork, about 10 minutes. Drain, and set aside to cool.",
                        "3. While the potatoes are cooking, place bacon in a large, deep skillet over medium-high heat. Fry until browned and crisp, 10 to 12 minutes, turning as needed.", 
                        "4. Transfer bacon to a paper towel-lined plate and crumble when cool enough to handle. Leave bacon grease in the skillet.",
                        "5. Cook onion in the bacon grease over medium heat until browned, 6 to 8 minutes. Add vinegar, sugar, water, salt, and pepper to the pan and bring to a boil.",
                        "6. Once boiling, add potatoes, and 1/2 of the crumbled bacon. Cook until heated through, 3 to 4 minutes.",
                        "7. Transfer warm potato salad to a serving dish and sprinkle remaining bacon over top. Garnish with parsley.",
                        "8. Finished! Best Served Immediately"},
            Spicy = false,
            Specialty = CookingInstructor.RecipeNS.Classification.vegan,
            Difficulty = 1,
            Time = 30,
            Servings = 4,
            CaloriesPerServing = 183,
            isFavorite = false,
            stepImages = new String[] 
                    {"/Recipe_datas/PotatoSalad/1.jpg",
                        "",
                        "",
                        "",
                        "/Recipe_datas/PotatoSalad/3.jpg",
                        "",
                        "",
                        ""},
            importance = Enumerable.Repeat(false, 8).ToArray(),
            imagePath = "/Recipe_datas/PotatoSalad/final.jpg"
        },
        
        new CookingInstructor.RecipeNS.Recipe{ 
            Name = "Fideua Paella", 
            Category = "European",
            IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                {new CookingInstructor.RecipeNS.Ingredient("Bronzini","x",1),
                                new CookingInstructor.RecipeNS.Ingredient("Shrimp","lb",1),
                                new CookingInstructor.RecipeNS.Ingredient("Celery","x",1),
                                new CookingInstructor.RecipeNS.Ingredient("Carrot","x",1),
                                new CookingInstructor.RecipeNS.Ingredient("Parsley","x",2),
                                new CookingInstructor.RecipeNS.Ingredient("Olive Oil","tbs",5),
                                new CookingInstructor.RecipeNS.Ingredient("Garlic"," cloves of",3),
                                new CookingInstructor.RecipeNS.Ingredient("Tomato","g",400),
                                new CookingInstructor.RecipeNS.Ingredient("Onion","x",1),
                                new CookingInstructor.RecipeNS.Ingredient("Bell Pepper","x",1),
                                new CookingInstructor.RecipeNS.Ingredient("Spaghetti","g",340),
                                new CookingInstructor.RecipeNS.Ingredient("Clams","g",225)},
                                
                                
                                
            Steps = new String[]
                    {"1. Remove the shells from the shrimp/prawns and keep the shells.",
                        "2. Place the fish bones, shells of the shrimp, celery, carrot, parsley stems, sprig of thyme and a small wedge of the onion in a pot.",
                        "3. You'll need to add around 4 cups/960ml water to the pot. Bring the pot to a boil and reduce to a simmer (covered).",
                        "4. Meanwhile, finely chop the remaining onion, pepper and garlic",
                        "5. Heat 2 tablespoon olive oil in a large skillet/frying pan over a medium-low heat and fry the fish and shrimp gently until almost cooked through. Remove from the pan and set aside.",
                        "6. Clean out any stuck-on skin etc from pan, add the remaining oil and then the onion and pepper.",
                        "7. Cook for around 10min, stirring now and then (turn lower after a few mins), then add paprika, garlic and fennel seeds.",
                        "8. By now the stock should be ready; strain it to remove all the bones and vegetables and add the saffron to infuse.",
                        "9. Cook the onions and spice mixture for 5 more minutes then add tomatoes.",
                        "10. Cook a further few mins then add fideos (pasta). Stir well so that they are covered by the oily mixture and cook another couple minutes.",
                        "11. Add the stock (3cups/750ml) to the pan, stir then leave to cook at a simmer for 10min.",
                        "12. Stir then add the clams, pushing them under the liquid and pasta. Allow them to cook a minute and add the shrimp/prawns and fish as well.",
                        "13. After about 5 mins the clams should open and all should be ready.",
                        "14. Finished!"}
        ,
            Spicy = false,
            Specialty = CookingInstructor.RecipeNS.Classification.normal,
            Difficulty = 3,
            Time = 50,
            Servings = 5,
            CaloriesPerServing = 817/5,
            isFavorite = false,
            stepImages = new String[] 
                    {"/Recipe_datas/paella/1.gif",
                        "",
                        "/Recipe_datas/paella/2.JPG",
                        "/Recipe_datas/paella/3.JPG",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""
                    },
            importance = Enumerable.Repeat(false, 14).ToArray(),
            imagePath = "/Recipe_datas/paella/final.JPG"
        },
    
    
        new CookingInstructor.RecipeNS.Recipe{ 
            Name = "Balsamic Chicken Breast", 
            Category = "Canadian",
            IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                {new CookingInstructor.RecipeNS.Ingredient("Chicken","x",4),
                                new CookingInstructor.RecipeNS.Ingredient("Olvie Oil","tbs",4),
                                new CookingInstructor.RecipeNS.Ingredient("Bell Pepper","cups",4),
                                new CookingInstructor.RecipeNS.Ingredient("Onion","x",1),
                                new CookingInstructor.RecipeNS.Ingredient("Olive Oil","cup",1),
                                new CookingInstructor.RecipeNS.Ingredient("Garlic"," cloves of",4),
                                new CookingInstructor.RecipeNS.Ingredient("Basil","cup",1),
                                new CookingInstructor.RecipeNS.Ingredient("Balsamic Vinegar","tbs",4)},
                                
                                
                                
            Steps = new String[]
                    {"1. Season chicken with salt and pepper.",
                        "2. In a large skillet, saute chicken in 2 tablespoons of oil over medium high heat, turning once for a total of about 8 minutes or until golden brown.",
                        "3. Transfer chicken to a plate",
                        "4. Add 2 remaining tablespoons of oil to the skillet and cook peppers and onions, stirring often until just softened..",
                        "5. Add garlic and stir for about 1 minute.",
                        "6. Stir in basil and vinegar and return chicken and juices to the skillet.",
                        "7. Reduce heat to low and simmer until chicken is cooked through, about 3 more minutes.",
                        "8. Taste and adjust salt and pepper seasonings",
                        "9 Finished!"}
        ,
            Spicy = false,
            Specialty = CookingInstructor.RecipeNS.Classification.normal,
            Difficulty = 1,
            Time = 30,
            Servings = 4,
            CaloriesPerServing = 313,
            isFavorite = false,
            stepImages = new String[] 
                    {"",
                        "/Recipe_datas/BalsamicChicken/2.JPG",
                        "",
                        "",
                        "",
                        "/Recipe_datas/BalsamicChicken/6.JPG",
                        "",
                        "",
                        ""
                        },
            importance = Enumerable.Repeat(false, 9).ToArray(),
            imagePath = "/Recipe_datas/BalsamicChicken/final.jpg"
        },
        

        new CookingInstructor.RecipeNS.Recipe{ 
            Name = "Italian Gluten-Free Recipe", 
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
                        "6. Add Tomato, Green Onion, 20g Oil and 3g Salt then keep frying till it looks like tomato paste.",
                        "7. Then add Egg back to pot, frying for 30 seconds. Done!"},
            Spicy = false,
            Specialty = CookingInstructor.RecipeNS.Classification.GF,
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
            importance = Enumerable.Repeat(false, 7).ToArray(),
            imagePath = "/Recipe_datas/Dump/final.jpg"
        },

        new CookingInstructor.RecipeNS.Recipe{ 
            Name = "Asian Gluten-Free Recipe", 
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
                        "6. Add Tomato, Green Onion, 20g Oil and 3g Salt then keep frying till it looks like tomato paste.",
                        "7. Then add Egg back to pot, frying for 30 seconds. Done!"},
            Spicy = false,
            Specialty = CookingInstructor.RecipeNS.Classification.GF,
            Difficulty = 1,
            Time = 45,
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
            importance = Enumerable.Repeat(false, 7).ToArray(),
            imagePath = "/Recipe_datas/Dump/final.jpg"
        },

        new CookingInstructor.RecipeNS.Recipe{ 
            Name = "European Vegan Recipe", 
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
                        "6. Add Tomato, Green Onion, 20g Oil and 3g Salt then keep frying till it looks like tomato paste.",
                        "7. Then add Egg back to pot, frying for 30 seconds. Done!"},
            Spicy = false,
            Specialty = CookingInstructor.RecipeNS.Classification.vegan,
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
            importance = Enumerable.Repeat(false, 7).ToArray(),
            imagePath = "/Recipe_datas/Dump/final.jpg"
        },

        new CookingInstructor.RecipeNS.Recipe{ 
            Name = "Canadian Recipe", 
            Category = "Canadian",
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
                        "6. Add Tomato, Green Onion, 20g Oil and 3g Salt then keep frying till it looks like tomato paste.",
                        "7. Then add Egg back to pot, frying for 30 seconds. Done!"},
            Spicy = false,
            Specialty = CookingInstructor.RecipeNS.Classification.normal,
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
                    },
            importance = Enumerable.Repeat(false, 7).ToArray(),
            imagePath = "/Recipe_datas/Dump/final.jpg"
        },
        new CookingInstructor.RecipeNS.Recipe{
            Name = "Chili Chicken",
            Category = "Chinese",
            IngredientList = new CookingInstructor.RecipeNS.Ingredient[]{
                new CookingInstructor.RecipeNS.Ingredient("Chicken","g",700),
                new CookingInstructor.RecipeNS.Ingredient("Chili Pepper","g",50),
                new CookingInstructor.RecipeNS.Ingredient("Zanthoxylum","g",15),
                new CookingInstructor.RecipeNS.Ingredient("Garlic","g",10),
                new CookingInstructor.RecipeNS.Ingredient("Ginger","g",10),
                new CookingInstructor.RecipeNS.Ingredient("Green Onion"," ",1),
                new CookingInstructor.RecipeNS.Ingredient("Leek"," ",1),
                new CookingInstructor.RecipeNS.Ingredient("White Sesame","spoon",1),
                new CookingInstructor.RecipeNS.Ingredient("Pepper","spoon",1),
                new CookingInstructor.RecipeNS.Ingredient("Cooking Wine","spoon",1),
                new CookingInstructor.RecipeNS.Ingredient("Soy Sauce","spoon",1),
                new CookingInstructor.RecipeNS.Ingredient("Corn Starch","spoon",1),
                new CookingInstructor.RecipeNS.Ingredient("Sesame Oil","spoon",1),
                new CookingInstructor.RecipeNS.Ingredient("Spicy Chili Sauce","spoon",1),
                new CookingInstructor.RecipeNS.Ingredient("Salt","g",5),
                new CookingInstructor.RecipeNS.Ingredient("Oil","g",100)
            },
            Steps = new String[]{
                "1. Wash the Chicken with cold water then cut into small chunks, then put inside a container.",
                "2. Add Salt, PowdeBell Pepper, Cooking Wine, Seasoning soy sauce and Starch into container, mix them well with hand or some tool.",
                "3. Then add Sesame Oil into container, mix everything well and wait for 20mins.",
                "4. Slice Garlic and Ginger into pieces, diced leeks and cut Green Onion into small pieces.",
                "5. Hot your pot and add Oils, when Oil is about 150 celsius add Chicken fried till looks golden. Then take the Chicken out, put in somewhere.",
                "6. You can choose to remove some Oil or leave them in the pot. Add Ginger, Garlic and Leek fry till smells fragrant.",
                "7. Add Chili Pepper, Zanthoxylum, Spicy Chili Sauce keep frying about 1mins.",
                "8. Add the Chicken back to your pot keep frying and mix them well.",
                "9. Sprinkle with chopped green onion, mix them well and we are done!"
            },
            stepImages = new String[]{
                "",
                "/Recipe_datas/chilli chicken/1.jpg",
                "",
                "/Recipe_datas/chilli chicken/3.jpg",
                "/Recipe_datas/chilli chicken/5.jpg",
                "",
                "",
                "/Recipe_datas/chilli chicken/8.jpg",
                "/Recipe_datas/chilli chicken/9.jpg"
            },
            Spicy = true,
            Specialty = CookingInstructor.RecipeNS.Classification.normal,
            Difficulty = 3,
            Time = 60,
            Servings = 2,
            CaloriesPerServing = 452,
            isFavorite = false,
            importance = Enumerable.Repeat(false, 9).ToArray(),
            imagePath = "/Recipe_datas/chilli chicken/9.jpg"
        },
        new CookingInstructor.RecipeNS.Recipe{
            Name = "Beef Donburi",
            Category = "Japanese",
            IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                {new CookingInstructor.RecipeNS.Ingredient("Beef","g",200),
                                new CookingInstructor.RecipeNS.Ingredient("Egg"," ",1),
                                new CookingInstructor.RecipeNS.Ingredient("Onion","g",100),
                                new CookingInstructor.RecipeNS.Ingredient("Carrot"," ",1),
                                new CookingInstructor.RecipeNS.Ingredient("Green Onion","g",15),
                                new CookingInstructor.RecipeNS.Ingredient("Rice","bowl",1),
                                new CookingInstructor.RecipeNS.Ingredient("Soy Sauce","spoon",1),
                                new CookingInstructor.RecipeNS.Ingredient("Dark Soy Sauce","spoon",1),
                                new CookingInstructor.RecipeNS.Ingredient("Oyster Sauce","spoon",1),
                                new CookingInstructor.RecipeNS.Ingredient("Sugar","spoon",1),
                                new CookingInstructor.RecipeNS.Ingredient("Starch","spoon",1),
                                new CookingInstructor.RecipeNS.Ingredient("Cooking Wine","spoon",1),
                                new CookingInstructor.RecipeNS.Ingredient("Water","g",250),
                                new CookingInstructor.RecipeNS.Ingredient("Salt","g",3),
                                new CookingInstructor.RecipeNS.Ingredient("Pepper","g",5),
                                new CookingInstructor.RecipeNS.Ingredient("Butter","g",15),
                                new CookingInstructor.RecipeNS.Ingredient("Sea Laver","g",10)},
            Steps= new String[]{ 
                "1. Slice Onion and Carrot.",
                "2. Prepare sauce. Grab a container, add Seasoning soy sauce, Dark soy sauce, Cooking wine, Oyster sauce, Sugar, Starch, Salt, Water, PowdeBell Pepper and mix them well.",
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
            Spicy = false,
            Specialty = CookingInstructor.RecipeNS.Classification.normal,
            Difficulty = 3,
            Time = 45,
            Servings = 1,
            CaloriesPerServing = 670,
            isFavorite = false,
            importance = Enumerable.Repeat(false, 6).ToArray(),
            imagePath = "/Recipe_datas/Beef Donburi/4.jpg"
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
                                new CookingInstructor.RecipeNS.Ingredient("Pepper","g",3),
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
            Spicy = false,
            Specialty = CookingInstructor.RecipeNS.Classification.normal,
            Difficulty = 2,
            Time = 30,
            Servings = 1,
            CaloriesPerServing = 300,
            isFavorite = false,
            importance = Enumerable.Repeat(false, 5).ToArray(),
            imagePath = "/Recipe_datas/French Bisque/2.jpg"
        },

        new CookingInstructor.RecipeNS.Recipe{
            Name = "French Apple Tart",
            Category = "French",
            IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                {new CookingInstructor.RecipeNS.Ingredient("Flour","g",230),
                                new CookingInstructor.RecipeNS.Ingredient("Butter","g",70),
                                new CookingInstructor.RecipeNS.Ingredient("Butter","g",113),
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
            Spicy = false,
            Specialty = CookingInstructor.RecipeNS.Classification.vegi,
            Difficulty = 3,
            Time = 60,
            Servings = 3,
            CaloriesPerServing = 400,
            isFavorite = false,
            importance = Enumerable.Repeat(false, 7).ToArray(),
            imagePath = "/Recipe_datas/French Apple Tart/5.jpg"
        },

            new CookingInstructor.RecipeNS.Recipe{
            Name = "Dongpo Pork",
            Category = "Chinese",
            IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                {new CookingInstructor.RecipeNS.Ingredient("Pork","g",500),
                                new CookingInstructor.RecipeNS.Ingredient("Green Onion","g",20),
                                new CookingInstructor.RecipeNS.Ingredient("Ginger","g",12),
                                new CookingInstructor.RecipeNS.Ingredient("Sugar","g",30),
                                new CookingInstructor.RecipeNS.Ingredient("Cinnamon","g",15),
                                new CookingInstructor.RecipeNS.Ingredient("Star Anise","g",10),
                                new CookingInstructor.RecipeNS.Ingredient("Fragrant leaves","g",1),
                                new CookingInstructor.RecipeNS.Ingredient("Dark soy sauce","spoon",1),
                                new CookingInstructor.RecipeNS.Ingredient("Salt","g",5),
                                },
            Steps= new String[]{
                "1. Hold the Pork and grill the pigskin with dry pot, don't add Oil. When the pigskin looks burnt, stop and wash it with cold water.",
                "2. First put the Pork in cold water add Green Onion and some Ginger slices then stew till you can easily poke in the Pork. Cut Pork into small squares, and put them on top of a Onion/Ginger layer, pigskin towards down.",
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
            Spicy = false,
            Difficulty = 3,
            Time = 120,
            Servings = 2,
            CaloriesPerServing = 483,
            isFavorite = false,
            importance = Enumerable.Repeat(false, 5).ToArray(),
            imagePath = "/Recipe_datas/Dongpo Pork/6.jpg"
        },
        new CookingInstructor.RecipeNS.Recipe{
            Name = "Fried Chicken",
            Category = "Canadian",
            IngredientList = new CookingInstructor.RecipeNS.Ingredient[]
                                {new CookingInstructor.RecipeNS.Ingredient("Chicken","g",600),
                                new CookingInstructor.RecipeNS.Ingredient("Oil","g",500),
                                new CookingInstructor.RecipeNS.Ingredient("Flour","g",200),
                                new CookingInstructor.RecipeNS.Ingredient("Egg","g",100),
                                new CookingInstructor.RecipeNS.Ingredient("Pepper","g",15),
                                new CookingInstructor.RecipeNS.Ingredient("Garlic","g",10),
                                new CookingInstructor.RecipeNS.Ingredient("Onion","g",10),
                                new CookingInstructor.RecipeNS.Ingredient("Paprika","g",15),
                                new CookingInstructor.RecipeNS.Ingredient("Salt","g",8),
                                
                                },
            Steps= new String[]{
                "1. Crack Eggs and mix well with 20g water.",
                "2. Prepare a container, add Powdered Garlic, Onion, Pepper, Paprika and Salt. Mix them well. Then coat Chicken with and it wait for 30min.",
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
            Spicy = true,
            Specialty = CookingInstructor.RecipeNS.Classification.normal,
            Difficulty = 1,
            Time = 45,
            Servings = 2,
            CaloriesPerServing = 467,
            isFavorite = false,
            importance = Enumerable.Repeat(false, 7).ToArray(),
            imagePath = "/Recipe_datas/Frying Chicken/4.jpg"
        }
    };
    public CookingInstructor.RecipeNS.Recipe[] GetRecipes() {

        // for(int i = 0; i < list.Length; i++)
        // {
        //     Console.WriteLine(list[i].Name);
        // }

        return list;
    }
    public List <string> GetIngredients() {
        List <string> recipeIngrList = new List<string>();
        
        foreach(var recipe in list)
        {   
            foreach (var ingredient in recipe.IngredientList)
            {
                if (!recipeIngrList.Contains(ingredient.Name))
                {
                    recipeIngrList.Add(ingredient.Name);
                }
            }
        }
        return recipeIngrList;
    }
    public static List<string> allIngredients = new CookingInstructor.Data.Recipes().GetIngredients();
}