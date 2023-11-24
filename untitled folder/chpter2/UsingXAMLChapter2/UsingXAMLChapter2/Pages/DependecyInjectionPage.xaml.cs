namespace UsingXAMLChapter2.Pages;

public partial class DependecyInjectionPage : ContentPage
{
	public DependecyInjectionPage()
	{
		InitializeComponent();
		BindingContext = Startup.ServiceProvider.GetService<MainPageModel>();
	}
}
