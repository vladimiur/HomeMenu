
namespace HomeMenu;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new HomeMenu.MainPage();
		MainPage = new NavigationPage(new MainPage());
	}
}
