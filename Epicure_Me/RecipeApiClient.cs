using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Epicure_Me
{
    class RecipeApiClient
    {
		private const string apiKey = "2e892358816546c888ccdcba6b3fa840";

			
		public async Task<List<Recipe>> GetRecipesAsync(string mealType)
		{
			try
			{
				using (HttpClient client = new HttpClient())
				{
					string apiUrl = $"https://api.spoonacular.com/recipes/random?number=1&tags={mealType}&apiKey={apiKey}";

					Debug.WriteLine($"API URL: {apiUrl}");

					HttpResponseMessage response = await client.GetAsync(apiUrl);

					if (response.IsSuccessStatusCode)
					{
						string content = await response.Content.ReadAsStringAsync();
						Debug.WriteLine(content);

						RecipeApiResponse apiResponse = JsonConvert.DeserializeObject<RecipeApiResponse>(content);

						if (apiResponse != null)
						{
							return apiResponse.Recipes;
						}
					}
					else
					{
						Debug.WriteLine($"API Error: {response.ReasonPhrase}");
					}
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine($"API Exception: {ex.Message}");
			}

			return new List<Recipe>();
		}

		public async Task<List<Recipe>> SearchRecipeAsync(string apiQuery)
		{
			try
			{
				using (HttpClient client = new HttpClient())
				{
					string apiUrl = $"https://api.spoonacular.com/recipes/findByIngredients?number=1&ingredients={apiQuery}&apiKey={apiKey}";
					HttpResponseMessage response = await client.GetAsync(apiUrl);
					if (response.IsSuccessStatusCode)
					{
						string content = await response.Content.ReadAsStringAsync();
						Debug.WriteLine(content);
						RecipeApiResponse apiResponse = JsonConvert.DeserializeObject<RecipeApiResponse>(content);
						if (apiResponse != null)
						{
							return apiResponse.Recipes;
						}
						else
						{
							Debug.WriteLine("API Error: " + response.ReasonPhrase);
						}
					}
				}
			}
			catch (Exception ex) 
			{
				Debug.WriteLine("API Exception: " + ex.Message);
			}
			return new List<Recipe>();
			
		}



	}
}
