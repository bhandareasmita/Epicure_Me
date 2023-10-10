
namespace Epicure_Me;

public partial class RecipeDetailPage : ContentPage
{
	public RecipeDetailPage(Recipe selectedRecipe)
	{
		InitializeComponent();
		// Set the BindingContext to the Recipe instance
		BindingContext = selectedRecipe;
		bool containsHtmlTags = selectedRecipe.Instructions.Contains("<li>");

		if (containsHtmlTags)
		{
			// Instructions contain HTML tags; no need to modify
			WebViewInstructions.Source = new HtmlWebViewSource { Html = selectedRecipe.Instructions };
		}
		else
		{
			// Instructions without HTML tags; split by line breaks and format as an ordered list
			string[] instructions = selectedRecipe.Instructions.Split('.'); // You may need to adjust the delimiter
			string formattedInstructions = "<ol>";

			foreach (string instruction in instructions)
			{
				formattedInstructions += $"<li>{instruction.Trim()}</li>";
			}

			formattedInstructions += "</ol>";
			WebViewInstructions.Source = new HtmlWebViewSource { Html = formattedInstructions };
		}
	}

	private async void OnButton_Back_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//LunchPage");
	}

	private void Ingredients_TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
	{
		ingredientsStack.IsVisible = true;
		directionsStack.IsVisible = false;
	}

	private void Directions_TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
	{
		ingredientsStack.IsVisible = false;
		directionsStack.IsVisible = true;
	}

	private async void Button_Back_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//LunchPage");
	}
}