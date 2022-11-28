public class IngredientEntryData
{
    public String name { get; set;}

    public IngredientEntryMode mode { get; set;}

    public IngredientEntryData(String n, IngredientEntryMode m) {
        name = n;
        mode = m;
    }
}

public enum IngredientEntryMode
{
    Add,
    Remove
}