namespace ShellApp.Pages;

public partial class CommunityListPage : ContentPage
{
	public CommunityListPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e) {
		await Shell.Current.GoToAsync("/Detail");
    }
}