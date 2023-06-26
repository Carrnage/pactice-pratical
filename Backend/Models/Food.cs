namespace Backend.Models{
    public class Food{
        public int FoodID{get;set;}
        public int RestaurantID{get;set;}
        public string Name{get;set;}=default!;
        public string Description{get;set;}=default!;
        public Restaurant? Restaurant {get;set;}
    }
}