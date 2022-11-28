public class YourIngredients
{
    public event Action? OnChange;
    
    public List<String> list { get; private set; } = new List<String> {};

    public void Set(List<String> newList)
    {
        list = newList;
        OnChange?.Invoke();
    }

    public void Add(String name)
    {
        if (! list.Contains(name))
        {
            list.Add(name);
            OnChange?.Invoke();
        }
    }

    public void Insert(int index, String name)
    {
        if (! list.Contains(name))
        {
            list.Insert(index, name);
            OnChange?.Invoke();
        }
    }

    public void Remove(String name)
    {
        list.Remove(name);
        OnChange?.Invoke();
    }
}