namespace Epicure_Me;

public partial class DetailRecipePage : ContentPage
{
	public DetailRecipePage(Recipe recipe)
	{
		InitializeComponent();
		BindingContext = recipe;
	}
}