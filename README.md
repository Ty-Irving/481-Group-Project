# 481-Group-Project
## List of Contributors
- Elgiz Abbasov @elgizabbasov - 30062467
- Ty Irving @Ty-Irving - 30105319
- Quinn Ceplis @andrejkazi - 30027148
- Takahiro Fujita @TakahiroFujitaSJB - 30069999
- Zhongmin Ma @lexahoa - 30105936



https://user-images.githubusercontent.com/74677790/208823993-6df85a99-4940-4f75-899b-fbe113670605.mp4


# Voracious Chefs
The Voracious Chefs Cooking Instructor App provides the ability for beginner and experienced cooks to look up and follow their desired recipes. People have many ways of finding recipes and learning to cook. Physical cookbooks are tedious, time-consuming, and spacious to put on a cooking counter. Regular cooking sites and blogs are riddled with confusing walls of text and multiple recipes for the same dish with varying difficulty and ingredients. Not just that, but it is also full of pop-up ads. With our Digital Cookbook Instructor, users can access all their favorite recipes on their mobile devices because this will help negate having to attain physical texts that include difficult-to-navigate processes, as well as reduce the overall difficulty of having the dish they want.

## How we built it
We built the application using C# and Blazor with Bootstrap. The favorites page works with sessions to keep track of the user's favorites list. Shared Blazor components, as well as .razor pages, were used with .cs C# files in creating the application.

# How to Use the System
To be able to use the app, you first need to clone the project to a local folder. Make sure you pull the 'staging' branch. Once done, enter the root folder and run the commands:
`cd 481 Portfolio`
`cd CookingInstructor`

Then:
`dotnet run`

The application should now be running.

If you would like to enable Hot Reload, use:
`dotnet watch`

## Recommended Settings
To experience the full capacities of the system, we recommend inputting data that exists in our database, provided at the end of this document. We also recommend using the system with 414x896/iPhone XR dimensions with a zoom in the range of 75% or 100% or just the "Fit to window" option chosen on Chrome for the best experience. 

## The walkthrough/expected usage of the system is as follows:
* Depending on the user's goal with using the app, a user can either select Search by Ingredient or Search Recipes from the Home page to get started. 
    * The recipe search looks through the list of recipes and suggests them to the user based on the user prompt, same as ingredients as described below. 
        * Users can navigate to the top and click on the "Filter" button to apply filtering to the search results or search another recipe.
    * Search by Ingredient takes the user's inputs and searches through the recipes' ingredients in the database. 
        * If there exists such an ingredient or ingredients, they are shown as autocomplete suggestions to the user. 
    * Selecting the autocomplete suggestions fills up the search bar, and a user can do actions based on the tab they are on (Ingredient or Recipe). 
    * If the user is searching for ingredients, they are able to click "Add" and add the searched ingredient to their list of ingredients to be searched. 
        * This list of ingredients is then searched when a user clicks on the magnifying glass. 

    * After seeing the results of the user search, a user is able to select any of the recipes they are prompted with. 
    * The recipe page contains information for the user or the cook on things like calories per serving, the difficulty of the meal, the spiciness level, the time it will take to cook the meal, and its ingredients with step-by-step instructions on how to approach the recipe.
        * The recipe page provides the ability to share the recipe by copying it to the clipboard and adding it to the user's favorites list. 
        * The user is shown a checklist under the Ingredients tab where they are able to double-check the available ingredients to them and if they are able to follow through with the recipe. 
        * The instructions tab provides the steps for the user and the ability to mark the key steps by highlighting the stars next to the steps. These customizations are persistent to the user and are saved throughout the session. (When the application is restarted, the favorites list and the customizations are not saved).

* The Discover page provides the user with the ability to browse through a selection of cuisines and their recipes. Due to system constraints, some of the cuisines do not have recipes under them: Middle East, Latin America, U.S., Korean, Thai, and Mediterranean.

* The Favourites page is where the user is able to browse through their saved recipes. The major use case for this functionality is the regularity of meals cooked by chefs as a commonly cooked recipe can be added under Favourites so that the user doesn't search for the recipe again.

# The System and a walkthrough
* The app provides three main pages for the user, which are Home, Discover, and Favorites. The Home page is the default page that the user is shown when the app is executed.
    * While the user is on Search Recipe tab, they are able to search and apply various Filters like the recipe difficulty or cooking time to any of the available recipes. 
    * The queried recipes are then displayed to the user in a card component form with quick insights to the recipe information like its calories per serving at a glance. 


List of all the available recipes are: 

Braised Pork With Beancurd Sheet  
MapoTofu  
Spicy Fry Shredded Potato  
Tomato-Egg Noodle  
Tomato with Egg  
German Potato Salad  
Fideua Paella  
Balsamic Chicken Breast  
Margaiana - Dummy  
Margaiana - Dummy  
MargaianaVegan - Dummy  
Poutine - Dummy  
Chili Chicken  
Beef Donburi  
French Bisque  
French Apple Tart  
Dongpo Pork  
Frying Chicken  
Chili Chicken  



* While the user is on the Search by Ingredient tab, they are able to add to any of the available ingredients to a "Your Ingredients" component where all of the searched ingredients are stored at a glance. 
    * The user is able to click on an "Add" button to add any of the selected ingredients suggested to the user. 
* There exists a Common Ingredients box where most searched ingredients are kept so that the users can quickly choose basic/popular ingredients.
    * These ingredients can be added to "Your Ingredients" with a click and can be removed from Your Ingredients the same way with plus and minus signs that make the interaction more instinctive. 
    * If an ingredient doesn't exist in the available list, user is accordingly notified. 
    
List of all the available ingredients are:


Pork
Beancurd Sheet
Red Pepper
Black Bean
Dark Soy Sauce
Seasoning Soy Sauce
Soy Sauce
Oyster Flavoured Sauce
Garlic
Ginger
Onion Green
Oil
Tofu
Red Pepper
Onion Green
Garlic
Oil
Ginger
Chili Garlic Sauce
Soybean Paste
Spicy Chili Sauce
Red Hot Chili Sauce
Cooking wine
Tapioca
Potato
Red Pepper
Rice Vinegar
Seasoning Soy sauce
Oil
Salt
Tomato
Egg
Noodle
Onion Green
Oil
Salt
Tomato
Egg
Onion Green
Oil
Salt
Diced Peeled Potatoes
Bacon
Onion - diced
Vinegar
Water
White Sugar
Salt
Pepper
Chopped Parsley
Bronzini
Shrimp/prawns
Stick celery
Carrot
Stems Parsley
Olive Oil
Garlic
Crushed Tomatoes
Onion
Red Pepper
Pasta (fideos/borken spaghetti)
Clams
Chicken Breasts
Salt & Pepper
Olvie Oil
Bell Peppers
Meidium Onion
Olive Oil
Garlic
Fresh Basil
Balsamic Vinegar
Chicken(Drumstick)
Chili Pepper
Zanthoxylum
Garlic
Genger
Onion Green
Leek
White Sesame
pepper(powered)
Cooking Wine
Seasoning soy sauce
Starch
Sesame Oil
Spicy Chili Sauce
Salt
Oil
Beef Roll
Egg
Onion
Carrot
Onion Green
Rice
Seasoning soy sauce
Dark soy sauce
Oyster sauce
Sugar
Starch
Cooking wine
Water
Salt
Powered pepper
Butter
Sea laver
Pumpkin
Milk
Onion
Butter
Cream
Salt
Powered pepper
Flour
Butter
Butter(without salt)
Egg
Sugar
Apple
Vanilla Extract
Lemon
Pork
Onion Green
Genger
Rock Sugar
Cinnamon
Star Anise
Fragrant leaves
Dark soy sauce
Salt
Chicken Wings
Oil
Flour
Egg
Powered Pepper
Powered Garlic
Powered Onion
Paprika
Salt
