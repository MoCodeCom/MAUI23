using Chapter_7.View.p2;
using Chapter_7.View.p3;

namespace Chapter_7.View.MasterDetailPage;

public partial class UsingMasterDetailPage : MasterDetailPage
{
	public UsingMasterDetailPage()
	{
		InitializeComponent();
		string[] lstMenu = { "Home", "Page2", "Page3" };
		menu.ItemsSource = lstMenu;
		int idStr = Preferences.Get("id",0);
		menu.ItemTapped += (sender, e) =>
		{
			ContentPage gotoPage;
			switch (e.Item.ToString())
			{
				case "Home":
					gotoPage = new MainPage();
					break;
				case "Page2":
					gotoPage = new Page2();
					break;
				case "Page3":
					gotoPage = new Page3(idStr.ToString());
					break;
				default:
					gotoPage = new MainPage();
					break;
			}

			NavigationPage np = new NavigationPage(gotoPage);
			Navigation.PushAsync(np);
			menu.SelectedItem = null;

		};
		//np = new NavigationPage();
	}
}