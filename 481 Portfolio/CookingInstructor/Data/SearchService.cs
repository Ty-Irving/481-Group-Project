public class SearchService
{
    public static CookingInstructor.RecipeNS.Recipe[]? list = new CookingInstructor.Data.Recipes().GetRecipes();

    public List<CookingInstructor.RecipeNS.Recipe> originalRecipeResults = new List<CookingInstructor.RecipeNS.Recipe>();
    public List<CookingInstructor.RecipeNS.Recipe> recipeResults = new List<CookingInstructor.RecipeNS.Recipe>();
    public Dictionary<CookingInstructor.RecipeNS.Recipe?, int> recipeResultsIndexes = new Dictionary<CookingInstructor.RecipeNS.Recipe?, int>();

    private FilterData filterData;

    public SearchService(FilterData fd)
    {
        filterData = fd;
    }

    public List<int> GetRecipeResults(String? recipeName)
    {
        RecipeModeSearchResults(recipeName);
        Filter();
        return new List<int>(recipeResultsIndexes.Values);
    }

    public List<int> GetRecipeResults(List<String> yourIngredients)
    {
        IngredientModeSearchResults(yourIngredients);
        Filter();
        return new List<int>(recipeResultsIndexes.Values);
    }

    private void Filter()
    {
        // foreach(var i in recipeResultsIndexes.Keys)
        // {
        //     Console.Write(i.Name + " ");
        // }
        // Console.WriteLine();
        // foreach(var i in recipeResultsIndexes.Values)
        // {
        //     Console.Write(i + " ");
        // }
        // Console.WriteLine();
        
        return;
    }

    private void RecipeModeSearchResults(String? recipeName)
    {
        for (int i = 0; i < list.Length; i++)
        {
            if (list[i].Name.ToUpper().Contains(recipeName.ToUpper()))
            {
                recipeResults.Add(list[i]);
                recipeResultsIndexes[list[i]] = i;
            }
        }

        foreach (var entry in recipeResults)
        {
            Console.WriteLine(entry.Name);
        }
    }

    private void IngredientModeSearchResults(List<String> yourIngredients)
    {
        Dictionary<CookingInstructor.RecipeNS.Recipe, int> matchedRecipesCounts = new Dictionary<CookingInstructor.RecipeNS.Recipe, int>();
        Dictionary<CookingInstructor.RecipeNS.Recipe, int> indexReference = new Dictionary<CookingInstructor.RecipeNS.Recipe, int>();
        
        string[] ingredients = yourIngredients.ToArray();

        for (int i = 0; i < list.Length; i++)
        {
            int count = 0;
            string[] recipeIngrList = new string[list[i].IngredientList.Length];
            
            for (int k = 0; k < list[i].IngredientList.Length; k++)
            {
                recipeIngrList[k] = list[i].IngredientList[k].Name;
            }

            for (int j = 0; j < ingredients.Length; j++)
            {
                if (recipeIngrList.Contains(ingredients[j], StringComparer.OrdinalIgnoreCase))
                {
                    count += 1;
                    matchedRecipesCounts[list[i]] = count;
                    indexReference[list[i]] = i;
                }
            }
        }

        matchedRecipesCounts = matchedRecipesCounts.OrderByDescending(key => key.Value).ToDictionary(k => k.Key, v => v.Value);
        
        foreach (var entry in matchedRecipesCounts)
        {
            Console.WriteLine(entry.Key.Name + ": " + entry.Value);
        }

        foreach (var entry in matchedRecipesCounts)
        {
            recipeResultsIndexes[entry.Key] = indexReference[entry.Key];
        }

        recipeResults = new List<CookingInstructor.RecipeNS.Recipe>(matchedRecipesCounts.Keys);
    }
}