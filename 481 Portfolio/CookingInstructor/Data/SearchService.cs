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

    public string constructURL(List<int> recipeIDs)
    {
        string url = "/SearchPage?ids=";
        foreach (var id in recipeIDs)
        {
            if (id == recipeIDs[0])
            {
                url += id;
            }
            else
            {
                url += "," + id;
            }
        }
        Console.WriteLine(url);
        return url;
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

    public List<int> GetCuisineResults(String targetCuisine)
    {
        var allRecipeIDs = AllRecipeIDs();
        List<int> filteredRecipeIDs = new List<int>(allRecipeIDs);

        if (targetCuisine != "All")
        {
            foreach(var id in allRecipeIDs)
            {
                var recipe = list[id];

                if ( ! targetCuisine.Contains(recipe.Category)  )
                {
                    filteredRecipeIDs.Remove(id);
                }
            }
        }
        
        return filteredRecipeIDs;
    }

    public List<int> Filter(List<int> recipeIDs)
    {
        List<int> filteredRecipeIDs = new List<int>(recipeIDs);

        foreach(var id in recipeIDs)
        {
            var recipe = list[id];

            bool correctTime = IsCorrectTime(recipe);
            bool correctDiff = IsCorrectDifficulty(recipe);
            bool correctRestriction = IsCorrectRestrictions(recipe);

            // Console.Write(correctTime + " && " + correctDiff + " && " + correctRestriction);
            // Console.WriteLine();

            if ( ! (correctTime &&
                    correctDiff &&
                    correctRestriction))
            {
                filteredRecipeIDs.Remove(id);
                //Console.WriteLine("   Removing " + list[id].Name);
            }
        }

        // foreach(var id in filteredRecipeIDs)
        // {
        //     Console.Write(list[id].Name + ", ");
        // }
        // Console.WriteLine();

        return filteredRecipeIDs;
    }

    private bool IsCorrectTime(CookingInstructor.RecipeNS.Recipe recipe)
    {
        // 0--><--15--><--30--><--45--><--60--><--60+ ->
        // Rather than trying to understand boolean overlap, 
        // just consider what buckets each time interval falls into
        
        if (filterData.Times.Options.Count != 0)
        {
            int interval = 15;
            int leftBound, rightBound;
            String lastEntry = filterData.Times.TotalOptions().Last();
            foreach (var option in filterData.Times.Options)
            {
                // Last position, so check if greater than
                if (option == lastEntry)
                {
                    leftBound = Int32.Parse(option);
                    rightBound = Int32.MaxValue;
                }
                else
                {
                    rightBound = Int32.Parse(option);
                    leftBound = rightBound - interval;
                }

                // Console.WriteLine(recipe.Name +"."+ recipe.Time +": "+ IsInRange(recipe.Time, leftBound, rightBound));
                if(IsInRange(recipe.Time, leftBound, rightBound)) return true;
            }
            // No more filters, not correct time
            return false;
        }
        else
        {
            // No filters active
            return true;
        }
    }

    private bool IsInRange(int time, int leftBound, int rightBound)
    {
        // Console.WriteLine(time+", "+leftBound+", "+rightBound);
        return (leftBound < time && time <= rightBound);
    }

    private bool IsCorrectDifficulty(CookingInstructor.RecipeNS.Recipe recipe)
    {
        String diff = (recipe.Difficulty == 1) ? "Easy" : (recipe.Difficulty == 2) ? "Medium" : "Hard";
        // Console.WriteLine(recipe.Name +"."+ diff +": "+ filterData.Difficulties.Options.Contains(diff));

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
        // Console.WriteLine(restriction + ": ");

        bool contains = filterData.Restrictions.Options.Count == 0 ||
                        filterData.Restrictions.Options.Contains(restriction) ||
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
        
        // foreach (var entry in matchedRecipesCounts)
        // {
        //     Console.WriteLine(entry.Key.Name + ": " + entry.Value);
        // }

        foreach (var entry in matchedRecipesCounts)
        {
            recipeResultsIndexes[entry.Key] = indexReference[entry.Key];
        }

        recipeResults = new List<CookingInstructor.RecipeNS.Recipe>(matchedRecipesCounts.Keys);
    }
}


public class RecipeIDEventArgs : EventArgs
{
    List<int> recipeIDs {get;set;} = new List<int>();
    public RecipeIDEventArgs(List<int> ids)
    {
        recipeIDs = ids;
    }
}