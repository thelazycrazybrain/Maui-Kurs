namespace ShellApp.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e) {
		await Shell.Current.GoToAsync("//Help");
    }
}