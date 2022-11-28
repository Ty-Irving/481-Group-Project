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

    public List<String> Get() {
        return commonIngredients_;
    }

    public bool Contains(String name) {
        return commonIngredients_.Contains(name);
    }
}