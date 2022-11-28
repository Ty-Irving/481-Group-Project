public class CommonIngredients
{
    private static readonly List<String> commonIngredients_ = new List<String> {
        "Garlic",
        "Onion"
    };

    public bool Contains(String name) {
        return commonIngredients_.Contains(name);
    }
}