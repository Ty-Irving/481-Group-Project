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

    public List<int> AllRecipeIDs()
    {
        List<int> all = new List<int>();
        
        for (int i = 0; i < list.Length; ++i)
        {
            all.Add(i);
        }
        return all;
    }

    public List<int> GetRecipeResults(String? recipeName)
    {
        RecipeModeSearchResults(recipeName);

        return Filter(new List<int>(recipeResultsIndexes.Values));
    }

    public List<int> GetRecipeResults(List<String> yourIngredients)
    {
        IngredientModeSearchResults(yourIngredients);
        //Filter();
        return new List<int>(recipeResultsIndexes.Values);
    }

    public List<int> Filter(List<int> recipeIDs)
    {
        List<int> filteredRecipeIDs = new List<int>(recipeIDs);

        foreach(var id in recipeIDs)
        {
            var recipe = list[id];

            if ( ! (IsCorrectTime(recipe) &&
                    IsCorrectDifficulty(recipe) &&
                    IsCorrectRestrictions(recipe)))
            {
                filteredRecipeIDs.Remove(id);
            }
        }

        return filteredRecipeIDs;
    }

    // TODO: this is broken
    private bool IsCorrectTime(CookingInstructor.RecipeNS.Recipe recipe)
    {
        // 0--><--15--><--30--><--45--><--60--><--60+ ->
        // Rather than trying to understand boolean overlap, 
        // just consider what buckets each time interval falls into
        if (filterData.Times.Options.Count != 0)
        {
            int leftBound = 0;
            for (int i = 0; i < filterData.Times.Options.Count; ++i)
            {
                int rightBound = Int32.Parse(filterData.Times.Options[i]);

                if ((leftBound < recipe.Time && recipe.Time <= rightBound) ||
                    (i == filterData.Times.Options.Count - 1 && recipe.Time > rightBound))
                {
                    return true;
                }

                leftBound = rightBound;
            }
            return false;
        }
        else
            return true;
    }

    private bool IsCorrectDifficulty(CookingInstructor.RecipeNS.Recipe recipe)
    {
        String diff = (recipe.Difficulty == 1) ? "Easy" : (recipe.Difficulty == 2) ? "Medium" : "Hard";

        bool contains = filterData.Difficulties.Options.Count == 0 ||
                        filterData.Difficulties.Options.Contains(diff);
        return contains;
    }

    private bool IsCorrectRestrictions(CookingInstructor.RecipeNS.Recipe recipe)
    {
        Dictionary<CookingInstructor.RecipeNS.Classification, String> RestrictionLookup = new Dictionary<CookingInstructor.RecipeNS.Classification, String>()
        {
            { CookingInstructor.RecipeNS.Classification.normal, "Normal" },
            { CookingInstructor.RecipeNS.Classification.GF, "Gluten-Free" },
            { CookingInstructor.RecipeNS.Classification.vegi, "Vegetarian" },
            { CookingInstructor.RecipeNS.Classification.vegan, "Vegan" },
        };

        var restriction = RestrictionLookup[recipe.Specialty];

        bool contains = filterData.Difficulties.Options.Count == 0 ||
                        filterData.Difficulties.Options.Contains(restriction) ||
                        recipe.Specialty == CookingInstructor.RecipeNS.Classification.normal;
        return contains;
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