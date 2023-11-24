using Chapter_7.View.p2;

namespace Chapter_7.View.p1;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}
    /*
    private async void mainPage_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    protected override bool OnBackButtonPressed()
    {
        return true;
    }
    */
    private async void Mp_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    private async void Alert_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Test Alert", "Display Alert", "Cancel");
    }


}