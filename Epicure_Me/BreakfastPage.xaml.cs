using System.Linq.Expressions;

namespace Epicure_Me;

public partial class BreakfastPage : ContentPage
{
	public BreakfastPage()
	{
		InitializeComponent();
		LoadBreakfastRecipes();
	}
	private async void LoadBreakfastRecipes()
	{
		var viewModel = new LunchViewModel();
		BindingContext = viewModel;
		await viewModel.LoadBreakfastRecipes();
	}

	private async void Button_Back_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//MainPage");
	}

	private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		try
		{
			if (e.CurrentSelection.FirstOrDefault() is Recipe selectedRecipe)
			{
				await Navigation.PushAsync(new RecipeDetailPage(selectedRecipe));
			}
		}

		catch (Exception ex)
		{
			Console.WriteLine("Navigation Error: ", ex.Message);
		}
		
	}
}