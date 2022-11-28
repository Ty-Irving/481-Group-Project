public class CommonIngredients
{
    private static readonly List<String> commonIngredients_ = new List<String> {
        "Garlic",
        "Onion",
        "Butter",
        "Egg",
        "Olive Oil",
        "Flour",
        "Sugar",
        "Milk",
        "Rice",
        "Soya Sauce",
        "Bread"
    };

    public List<String> list { get; private set; }

    public event Action? OnChange;

    public CommonIngredients()
    {
        list = new List<String>(commonIngredients_);
    }

    public void Add(String name)
    {
        if (commonIngredients_.Contains(name) && ! list.Contains(name))
        {
            list.Add(name);
            OnChange?.Invoke();
        }
    }

    public void Insert(int index, String name)
    {
        if (commonIngredients_.Contains(name) && ! list.Contains(name))
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