public class SearchMode
{
    public SearchModeEnum state { get; set; } = SearchModeEnum.ByRecipe;
}

public enum SearchModeEnum
{
    ByRecipe,
    ByIngredient
}