class Recipe{
    String Name { get; set;}
    String Thumbnail ="url" { get; set;}
    String Category { get; set;}
    Ingredient[] IngredientList { get; set;}
    String [] Steps { get; set;}
    int Spicy { get; set;}
    int Difficulty { get; set;}
    int Time { get; set;}
    int Servings { get; set;}
    int CaloriesPerServing { get; set;}
    bool isFavorite { get; set;}
    
}


class Ingredient{
    public String Name { get; set;}
    public String Unit { get; set;}
    public float Amount { get; set;}
    public Ingredient(String n, String u, float a){
        Name = n;
        Unit = u;
        Amount = a;
    }

}

