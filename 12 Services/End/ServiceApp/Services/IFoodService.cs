using ServiceApp.Models;

namespace ServiceApp.Services {
    public interface IFoodService {
        List<FoodModel> GetFoods();
    }
}
