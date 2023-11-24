using Chapter_7.View.ContentPages;
using Chapter_7.View.MasterDetailPage;
using Chapter_7.View.p1;
using Chapter_7.View.p2;
using Chapter_7.View.TabbedPage;

namespace Chapter_7;

public partial class MainPage : ContentPage
{

    
	public MainPage()
	{
		InitializeComponent();
        this.Title = "Home";
        //Application.Current.Properties["id"] = 123;
        Preferences.Set("id",123);
        

        //Click event  by code...
        TabPage.Clicked += async (send, arg) =>
        {
            await Navigation.PushAsync(new tabPage());
        };
    }

    private async void Modelbtn_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushModalAsync(new Page1(), true);
		//NavigationPage np = new NavigationPage();
		
		
    }

    private async void Hirarchical_Clicked(object sender, EventArgs e)
    {
        var id = Preferences.Get("id",0);
        await Navigation.PushAsync(new Page2());
        await DisplayAlert("the value kept is: ",id.ToString() ," Cancel");
    }

    private async void ActionSheet_Clicked(object sender, EventArgs e)
    {
        string str = await DisplayActionSheet("Action Sheet", "Cancel", null,
            "option one", "option two", "option three");
        lblAction.Text = str;
    }

    private async void DrillDownList_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DrilldownListViewByItem());
    }

    private async void UsingMasterContentPage_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new UsingMasterDetailPage());
    }
}

