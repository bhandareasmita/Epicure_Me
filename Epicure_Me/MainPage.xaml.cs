namespace Epicure_Me
{
	public partial class MainPage : ContentPage
	{
	
		public MainPage()
		{
			InitializeComponent();
			
			
		}

		private async void OnLunchTapped(object sender, TappedEventArgs e)
		{
			await Shell.Current.GoToAsync("//LunchPage");
		}

		private async void OnBreakfastTapped(object sender, TappedEventArgs e)
		{
			await Shell.Current.GoToAsync("//BreakfastPage");
		}
	}
}