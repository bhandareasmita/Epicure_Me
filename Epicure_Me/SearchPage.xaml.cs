using System.Collections.ObjectModel;

namespace Epicure_Me;

public partial class SearchPage : ContentPage
{
	public SearchPage()
	{
		InitializeComponent();
		BindingContext = this;
	}
	private ObservableCollection<Recipe> _searchRecipes;
	public ObservableCollection<Recipe> SearchRecipes
	{
		get { return _searchRecipes; }
		set
		{
			if (_searchRecipes != value)
			{
				_searchRecipes = value;
				OnPropertyChanged(nameof(SearchRecipes));
			}
		}
	}

	private async void Button_Back_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//MainPage");
	}

	private async void Btn_Search_Clicked(object sender, EventArgs e)
	{
		string input = Search_Bar.Text;
		if (string.IsNullOrEmpty(input))
		{
			return;
		}
		else
		{
			string[] searchItems = input.Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries);
			List<string> searchQuery = searchItems.Select(x => x.Trim()).ToList();
			string apiQuery = string.Join(",+", searchQuery);
			RecipeApiClient recipeApiClient = new RecipeApiClient();
			List<Recipe> searchResults = await recipeApiClient.SearchRecipeAsync(apiQuery);
			SearchRecipes = new ObservableCollection<Recipe>(searchResults);
		}	

	}
}