namespace CookingInstructor.RecipeNS;

public class Recipe{
    public String ? Name { get; set;} // ? here represents nullable variables
    //String Thumbnail ="url" { get; set;}
    public String ? Category { get; set;}
    public Ingredient[] ? IngredientList { get; set;}
    public String[] ? Steps { get; set;}
    public bool Spicy { get; set;}
    public Classification Specialty { get; set;}
    public int Difficulty { get; set;}
    public int Time { get; set;}
    public int Servings { get; set;}
    public int CaloriesPerServing { get; set;}
    public bool isFavorite { get; set;}
    public String[] ? stepImages {get; set;}
    public String ? imagePath {get; set;}
    

    public bool[]? importance { get; set; }
}

public enum Classification
{
    normal,
    vegi,
    vegan,
    GF
}

public class Ingredient{
    public String Name { get; set;}
    public String Unit { get; set;}
    public float Amount { get; set;}
    public Ingredient(String n, String u, float a){
        Name = n;
        Unit = u;
        Amount = a;
    }

    public string toString() {
        return Amount + Unit + "\t" + Name;
    }

}
