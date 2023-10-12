using System.Windows.Input;

namespace Epicure_Me;

public partial class FavouritesPage : ContentPage
{
	public ICommand ClearAllCommand { get; }
	public ICommand RemoveFromFavouritesCommand { get; }

	public FavouritesPage()
	{
		InitializeComponent();

		ClearAllCommand = new Command(ClearAll);
		RemoveFromFavouritesCommand = new Command<Recipe>(RemoveFromFavourites);

		BindingContext = new FavouritesViewModel();
	}

	private void ClearAll()
	{
		var viewModel = (FavouritesViewModel)BindingContext;
		viewModel.ClearAll();
	}

	private void RemoveFromFavourites(Recipe recipe)
	{
		var viewModel = (FavouritesViewModel)BindingContext;
		viewModel.RemoveFromFavourites(recipe);
	}
}
