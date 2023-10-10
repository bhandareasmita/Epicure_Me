using System.Collections.ObjectModel;

namespace Epicure_Me;

public partial class SearchPage : ContentPage
{
	public SearchPage()
	{
		InitializeComponent();
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

	/*private void Btn_Search_Clicked(object sender, EventArgs e)
	{
		string input = searchBar.Text;
		if (string.IsNullOrEmpty(input))
		{
			return;
		}
		else
		{
			string[] searchItems = input.Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries);
			List<string> searchQuery = searchItems.Select(x => x.Trim()).ToList();
			string apiQuery = string.Join("+", searchQuery);
		}


    }*/
}