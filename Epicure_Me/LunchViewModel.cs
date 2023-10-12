using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epicure_Me
{
    class LunchViewModel : INotifyPropertyChanged
    {
		private ObservableCollection<Recipe> _breakfastRecipes;
		private ObservableCollection<Recipe> _lunchRecipes;
		private ObservableCollection<Recipe> _dinnerRecipes;
		private ObservableCollection<Recipe> _dessertRecipes;

		public ObservableCollection<Recipe> BreakfastRecipes
		{
			get { return _breakfastRecipes; }
			set
			{
				if (_breakfastRecipes != value)
				{
					_breakfastRecipes = value;
					OnPropertyChanged(nameof(BreakfastRecipes));
				}
			}
		}
		
		public ObservableCollection<Recipe> LunchRecipes
		{
			get { return _lunchRecipes; }
			set
			{
				if (_lunchRecipes != value)
				{
					_lunchRecipes = value;
					OnPropertyChanged(nameof(LunchRecipes));
				}
			}
		}

		public ObservableCollection<Recipe> DinnerRecipes
		{
			get { return _dinnerRecipes; }
			set
			{
				if (_dinnerRecipes != value)
				{
					_dinnerRecipes = value;
					OnPropertyChanged(nameof(DinnerRecipes));
				}
			}
		}

		public ObservableCollection<Recipe> DessertRecipes
		{
			get { return _dinnerRecipes; }
			set
			{
				if ( _dinnerRecipes != value)
				{
					_dinnerRecipes = value;
					OnPropertyChanged(nameof(DinnerRecipes));
				}
			}
		}

		// Constructor
		public LunchViewModel()
		{
			LunchRecipes = new ObservableCollection<Recipe>();
			BreakfastRecipes = new ObservableCollection<Recipe>();
			DinnerRecipes = new ObservableCollection<Recipe>();
			DessertRecipes = new ObservableCollection<Recipe>();

			// Load recipes for all meal types
			LoadLunchRecipes();
			LoadBreakfastRecipes();
			LoadDinnerRecipes();
			LoadDessertRecipes();
		}

		public async Task LoadBreakfastRecipes()
		{
			try
			{
				// Assume you have a RecipeApiClient that fetches lunch recipes from an API
				RecipeApiClient recipeApiClient = new RecipeApiClient();

				// Make an API call to fetch lunch recipes (this call can be asynchronous)
				List<Recipe> breakfastRecipes = await recipeApiClient.GetRecipesAsync("breakfast");

				// Check the API response
				Console.WriteLine("API Response: " + JsonConvert.SerializeObject(breakfastRecipes));

				// Populate the LunchRecipes ObservableCollection with the retrieved recipes
				if (breakfastRecipes != null)
				{
					foreach (Recipe recipe in breakfastRecipes)
					{
						LunchRecipes.Add(recipe);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
		}

		public async Task LoadLunchRecipes()
		{
			try
			{
				// Assume you have a RecipeApiClient that fetches lunch recipes from an API
				RecipeApiClient recipeApiClient = new RecipeApiClient();

				// Make an API call to fetch lunch recipes (this call can be asynchronous)
				List<Recipe> lunchRecipes = await recipeApiClient.GetRecipesAsync("lunch");

				// Check the API response
				Console.WriteLine("API Response: " + JsonConvert.SerializeObject(lunchRecipes));

				// Populate the LunchRecipes ObservableCollection with the retrieved recipes
				if (lunchRecipes != null)
				{
					foreach (Recipe lunchRecipe in lunchRecipes)
					{
						LunchRecipes.Add(lunchRecipe);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
		}

		public async Task LoadDinnerRecipes()
		{
			try
			{
				// Assume you have a RecipeApiClient that fetches lunch recipes from an API
				RecipeApiClient recipeApiClient = new RecipeApiClient();

				// Make an API call to fetch lunch recipes (this call can be asynchronous)
				List<Recipe> dinnerRecipes = await recipeApiClient.GetRecipesAsync("dinner");

				// Check the API response
				Console.WriteLine("API Response: " + JsonConvert.SerializeObject(dinnerRecipes));

				// Populate the LunchRecipes ObservableCollection with the retrieved recipes
				if (dinnerRecipes != null)
				{
					foreach (Recipe lunchRecipe in dinnerRecipes)
					{
						LunchRecipes.Add(lunchRecipe);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
		}

		public async Task LoadDessertRecipes()
		{
			try
			{
				// Assume you have a RecipeApiClient that fetches lunch recipes from an API
				RecipeApiClient recipeApiClient = new RecipeApiClient();

				// Make an API call to fetch lunch recipes (this call can be asynchronous)
				List<Recipe> dessertRecipes = await recipeApiClient.GetRecipesAsync("dinner");

				// Check the API response
				Console.WriteLine("API Response: " + JsonConvert.SerializeObject(dessertRecipes));

				// Populate the LunchRecipes ObservableCollection with the retrieved recipes
				if (dessertRecipes != null)
				{
					foreach (Recipe lunchRecipe in dessertRecipes)
					{
						LunchRecipes.Add(lunchRecipe);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
		}

		// Implement INotifyPropertyChanged for property change notifications
		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
