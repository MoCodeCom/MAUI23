using Chapter_7.View.p1;
using Chapter_7.View.p3;

namespace Chapter_7.View.p2;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
		NavigationPage.SetHasNavigationBar(this, true);
		
	}

    private void root_Clicked(object sender, EventArgs e)
    {
		
    }

	protected override  bool OnBackButtonPressed()
	{
        //bool result = DisplayAlert("Back","Are you sure to backforward?","Yes","No").Result;
        //DisplayAlert("what", "Some code", "Yes");


        /*
		if(result)
		{
			base.OnBackButtonPressed();
			return false;
        }
		*/
        base.OnBackButtonPressed();
        return true;
		
        
    }

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
		string type = (string)((ToolbarItem)sender).CommandParameter;
		//DisplayAlert("what",type,"OK");
		/*//Type pageType = Type.GetType(""+type+"NavigationExamples");
        Type pageType = Type.GetType("NavigationExamples" + type + ",NavigationExamples");
        Page page = Activator.CreateInstance(pageType) as Page;*/
		if (type == "mp")		{
            await this.Navigation.PushAsync(new MainPage());
        }else if ( type == "p3")
		{
			await this.Navigation.PushAsync(new Page3("Mohammed"));
		}
		
    }
}