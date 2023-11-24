namespace UsingXAMLChapter2;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
		Startup.Init();
	}
}

