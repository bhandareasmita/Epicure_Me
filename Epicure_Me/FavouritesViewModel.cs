using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epicure_Me
{
	public class FavouritesViewModel
	{
		private List<Recipe> favouriteRecipes = new List<Recipe>();
	
		public List<Recipe> FavouriteRecipes
		{
			get
			{
				return favouriteRecipes;
			}			
		}

		public void AddToFavourites(Recipe recipe)
		{
			if (!favouriteRecipes.Contains(recipe))
			{
				favouriteRecipes.Add(recipe);
			}
		}

		public void RemoveFromFavourites(Recipe recipe)
		{
			if (favouriteRecipes.Contains(recipe))
			{
				favouriteRecipes.Remove(recipe);
			}
		}

		public void ClearAll()
		{
			favouriteRecipes.Clear();
		}


	}
}
