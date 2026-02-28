
namespace BugSweeperDemo;

public partial class MainPage : ContentPage
{
	const string tiemFormat = @"%m\:ss";

	bool isGameInProgress;
	DateTime gameStartTime;

	public MainPage()
	{
		InitializeComponent();

		board.GameStarted += (sender, args) =>
		{
			
		};
	}
}
