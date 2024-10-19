using ServiceApp.ViewModels;

namespace ServiceApp.Pages;

public partial class FoodPage : ContentPage
{
	public FoodPage(FoodViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}

	
}