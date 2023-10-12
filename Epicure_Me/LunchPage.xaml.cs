//using AndroidX.Lifecycle;
using System.Windows.Input;

namespace Epicure_Me;

public partial class LunchPage : ContentPage

{
	public LunchPage()
	{
		InitializeComponent();
		LoadLunchRecipes();
	}


	private async void OnBackButtonClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//MainPage");
	}
	private async void LoadLunchRecipes()
	{
		var viewModel = new LunchViewModel();
		BindingContext = viewModel;
		await viewModel.LoadLunchRecipes();
	}
	private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		try
		{
			if (e.CurrentSelection.FirstOrDefault() is Recipe selectedRecipe)
			{
				// Navigate to the RecipeDetailPage, passing the selectedRecipe as a parameter
				await Navigation.PushAsync(new RecipeDetailPage(selectedRecipe));
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("Navigation Error: " + ex.Message);
		}
	}
	private void OnHeartImageTapped(object sender, EventArgs e)
	{
		if (sender is Image image && image.BindingContext is Recipe recipe)
		{
			recipe.IsFavorite = !recipe.IsFavorite;
			
		}
		
	}
}
	