using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Models {
    public class FoodModel {
        public FoodModel(string name) {
            Name = name;
        }

        public string Name { get; set; }
    }
}
