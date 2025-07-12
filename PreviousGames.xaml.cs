namespace MathGameMaui;

public partial class PreviousGames : ContentPage
{
	public PreviousGames()
	{
		InitializeComponent();

		gamesList.ItemsSource = App.GameRepository.GetAllGames();
	}

    private void OnDelete(object sender, EventArgs e)
    {
		Button btn = (Button)sender;

		App.GameRepository.Delete((int)btn.BindingContext);

		gamesList.ItemsSource = App.GameRepository.GetAllGames();
    }
}