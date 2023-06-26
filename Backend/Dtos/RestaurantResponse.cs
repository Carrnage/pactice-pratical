using Backend.Models;

namespace Backend.Dtos{
    public class RestaurantResponse{
            public RestaurantResponse(Restaurant restaurant){
        RestaurantID=restaurant.RestaurantID;
        Name=restaurant.Name;
        Rating=restaurant.Rating;
    }

        public int RestaurantID { get; set; }
        public string Name { get; set; } =default!;
        public int? Rating {get;set;}

    }
}