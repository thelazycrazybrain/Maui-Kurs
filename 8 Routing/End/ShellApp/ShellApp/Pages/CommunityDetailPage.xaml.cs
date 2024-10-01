namespace ShellApp.Pages;

public partial class CommunityDetailPage : ContentPage
{
	public CommunityDetailPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e) {
		await Shell.Current.GoToAsync("..", true);
    }

    private async void Button2_Clicked(object sender, EventArgs e) {
        await Shell.Current.GoToAsync("../Special");
    }
}