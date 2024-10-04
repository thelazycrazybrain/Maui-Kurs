namespace ShellApp.Pages;

public partial class TodoListPage : ContentPage {
    public TodoListPage() {
        InitializeComponent();
    }

    private async void GetCoffee_Clicked(object sender, EventArgs e) {
        await Shell.Current.GoToAsync("/Detail?Task=Get Coffee");
    }

    private async void GetEnergy_Clicked(object sender, EventArgs e) {
        await Shell.Current.GoToAsync("/Detail", new Dictionary<string, object> {
            { "Task", "Get Energy Drinks" }
        });
    }
}