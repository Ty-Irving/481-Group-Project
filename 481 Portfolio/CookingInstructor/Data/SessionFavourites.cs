namespace CookingInstructor.Data
{
    public class SessionFavourites
    {
        public List<String>? favourites { get; set; }

        public void addToList(string Name){
            if(favourites == null || favourites.Contains(Name)){
                return;
            }
            else{
                favourites.Add(Name);
            }
        }

        public void removeFromList(string Name){
            if(favourites == null){
                return;
            }
            else{
                favourites.Remove(Name);
            }
        }
    }
}

