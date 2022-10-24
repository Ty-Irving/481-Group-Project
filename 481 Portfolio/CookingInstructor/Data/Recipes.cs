namespace CookingInstructor.Data;

public class Recipes
{
    public Recipe[] getRecipes(){
        Recipe[] res = {new Recipe{ Name = "Burger", Category = "Western"}};
        

        return res;
    }

}