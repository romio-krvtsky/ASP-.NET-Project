using System.Text.Json.Serialization;

namespace WebApplication1.Blazor.Client.Models
{
    public class ListViewModel
    {
        [JsonPropertyName("dishId")]
        public int DishId { get; set; } // id блюда
        [JsonPropertyName("dishName")]
        public string DishName { get; set; } // название блюда
    }
}
