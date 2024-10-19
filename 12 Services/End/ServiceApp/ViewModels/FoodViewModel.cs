namespace ServiceApp.ViewModels {
    using CommunityToolkit.Mvvm.ComponentModel;
    using ServiceApp.Models;
    using ServiceApp.Services;
    using System.Collections.ObjectModel;

    public class FoodViewModel : ObservableObject {
        private readonly IFoodService _foodService;
        private readonly IDeviceService _deviceService;

        public FoodViewModel(IFoodService foodService, IDeviceService deviceService) {
            _foodService = foodService;
            _deviceService = deviceService;
            Foods = new ObservableCollection<FoodModel>(_foodService.GetFoods());
        }


        ObservableCollection<FoodModel> _foods;
        public ObservableCollection<FoodModel> Foods {
            get => _foods;
            set => SetProperty(ref _foods, value);
        }

        public string? DeviceId { get => _deviceService.GetId(); }
    }
}
