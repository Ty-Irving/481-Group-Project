namespace CookingInstructor.Data;

public class Recipes
{
    public CookingInstructor.RecipeNS.Recipe[] getRecipes(){
        CookingInstructor.RecipeNS.Recipe[] res = {new CookingInstructor.RecipeNS.Recipe{ Name = "Burger", Category = "Western"}};
        

        return res;
    }

}