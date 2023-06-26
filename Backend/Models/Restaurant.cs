
namespace Backend.Models{
    public class Restaurant{
        public int RestaurantID { get; set; }
        public string Name { get; set; } =default!;
        public int Rating {get;set;}
        public List<Food> Foods {get;set;} =new();
    }
}