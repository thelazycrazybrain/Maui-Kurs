using ServiceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Services {
    public class FoodService : IFoodService {
        public List<FoodModel> GetFoods() {
            return new List<FoodModel> {
            new FoodModel("Açaí berry"),
            new FoodModel("Acerola cherry"),
            new FoodModel("Ackee"),
            new FoodModel("African horned cucumber"),
            new FoodModel("Apple"),
            new FoodModel("Apricot"),
            new FoodModel("Arctic raspberry"),
            new FoodModel("Asian pear"),
            new FoodModel("Atemoya"),
            new FoodModel("Avocado"),
            new FoodModel("Babaco"),
            new FoodModel("Bacaba"),
            new FoodModel("Bael fruit"),
            new FoodModel("Banana")
           };
        }
    }
}
