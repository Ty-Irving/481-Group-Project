public class YourIngredients
{
    public event EventHandler? OnChange;
    
    public List<String> list { get; private set; } = new List<String> {};

    public void Set(List<String> newList)
    {
        list = newList;
        NotifyStateChanged();
    }

    public void Add(String name)
    {
        if (! list.Contains(name))
        {
            list.Add(name);
            NotifyStateChanged();
        }
    }

    public void Insert(int index, String name)
    {
        if (! list.Contains(name))
        {
            list.Insert(index, name);
            NotifyStateChanged();
        }
    }

    public void Remove(String name)
    {
        list.Remove(name);
        NotifyStateChanged();
    }

    public void NotifyStateChanged()
    {
        OnChange?.Invoke(this, new EventArgs());
    }
}

public class SearchIngredientsResults
{
    public List<int> RecipeIDs {get;set;} = new List<int>();
}