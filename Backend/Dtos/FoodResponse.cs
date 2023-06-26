using Backend.Models;

namespace Backend.Dtos{
    public class FoodResponse{

        public FoodResponse(Food food){
            FoodID= food.FoodID;
            Name=food.Name;
            Description=food.Description;
            Restaurant= new RestaurantResponse
        (food.Restaurant!);
        }
        public int FoodID{get;set;}
        public RestaurantResponse Restaurant {get;set;}=default!;
        public string Name{get;set;}=default!;
        public string? Description{get;set;}

    }
}