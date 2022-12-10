public class SearchMode
{
    public event EventHandler? OnChange;

    private SearchModeEnum state_;
    public SearchModeEnum state { 
        get
        {
            return state_;
        }
        set
        {
            if (state_ != value)
            {
                state_ = value;
                NotifyStateChanged();
            }
        }
    }

    public async Task NotifyStateChanged()
    {
        OnChange?.Invoke(this, null);
    }

    public SearchMode ()
    {
        state = SearchModeEnum.ByRecipe;
    }
}

public enum SearchModeEnum
{
    ByRecipe,
    ByIngredient
}