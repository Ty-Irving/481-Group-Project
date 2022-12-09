public class FilterData
{
    public FilterDataStore<String> Times;
    public FilterDataStore<String> Difficulties;
    public FilterDataStore<String> Restrictions;

    public FilterData()
    {
        Times = new FilterDataStore<String>(new List<String>
        {
            "15",
            "30",
            "45",
            "60"
        });

        Difficulties = new FilterDataStore<String>(new List<String>
        { 
            "Easy", 
            "Medium", 
            "Hard" 
        });

        Restrictions = new FilterDataStore<String>(new List<String>
        { 
            "Vegan", 
            "Vegetarian", 
            "Gluten-Free" 
        });
    }

    public class FilterDataStore<T>
    {
        private List<T> TotalOptions_ { get; set; }
        public List<T> Options { get; private set; } = new List<T> {};

        public FilterDataStore(List<T> options)
        {
            TotalOptions_ = options;
        }

        public void Add(T item)
        {
            if (TotalOptions_.Contains(item) && ! Options.Contains(item))
            {
                Options.Add(item);
            }
        }

        public void Insert(int index, T item)
        {
            if (TotalOptions_.Contains(item) && ! Options.Contains(item))
            {
                Options.Insert(index, item);
            }
        }

        public void Remove(T item)
        {
            Options.Remove(item);
        }
    }
}