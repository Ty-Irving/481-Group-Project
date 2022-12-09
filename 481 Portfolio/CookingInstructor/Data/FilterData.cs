public class FilterData
{
    public FilterDataStore Times;
    public FilterDataStore Difficulties;
    public FilterDataStore Restrictions;

    public FilterData()
    {
        Times = new FilterDataStore(new List<String>
        {
            "&lt; 15",
            "&lt; 30",
            "&lt; 45",
            "&gt; 60"
        });

        Difficulties = new FilterDataStore(new List<String>
        { 
            "Easy", 
            "Medium", 
            "Hard" 
        });

        Restrictions = new FilterDataStore(new List<String>
        { 
            "Vegan", 
            "Vegetarian", 
            "Gluten-Free" 
        });

        Console.WriteLine();
    }
}

public class FilterDataStore
{
    private List<String> TotalOptions_ { get; set; }
    public List<String> Options { get; private set; } = new List<String> {};

    public FilterDataStore(List<String> options)
    {
        TotalOptions_ = options;
    }

    public List<String> TotalOptions() 
    {
        return TotalOptions_;
    }

    public void Add(String item)
    {
        if (TotalOptions_.Contains(item) && ! Options.Contains(item))
        {
            Options.Add(item);
        }
    }

    public void Insert(int index, String item)
    {
        if (TotalOptions_.Contains(item) && ! Options.Contains(item))
        {
            Options.Insert(index, item);
        }
    }

    public void Remove(String item)
    {
        Options.Remove(item);
    }
}