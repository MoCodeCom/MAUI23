

namespace Chapter_7;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
		//MainPage = new NavigationPage(new Page1());
		//MainPage = new NavigationPage(new DrilldownListViewByItem());
	}
}
