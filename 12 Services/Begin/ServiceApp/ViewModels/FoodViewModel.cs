namespace ServiceApp.ViewModels {
    using CommunityToolkit.Mvvm.ComponentModel;
    using ServiceApp.Models;
    using System.Collections.ObjectModel;

    public class FoodViewModel : ObservableObject {
        ObservableCollection<FoodModel> _foods;
        public ObservableCollection<FoodModel> Foods {
            get => _foods;
            set => SetProperty(ref _foods, value);
        }

        public string? DeviceId { get; }
    }
}
