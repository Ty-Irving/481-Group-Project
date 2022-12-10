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

    public void NotifyStateChanged()
    {
        OnChange?.Invoke(this, new EventArgs());
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