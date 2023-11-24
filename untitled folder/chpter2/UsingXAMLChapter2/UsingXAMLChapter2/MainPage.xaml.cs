using Microsoft.Maui.Controls;
using UsingXAMLChapter2.Pages;

namespace UsingXAMLChapter2;

public partial class MainPage : ContentPage
{
	int count = 0;
    bool IsEnableBoolean = false;

	public MainPage()
    {
		InitializeComponent();
        

    }

    void Button_Clicked_namespace(System.Object sender, System.EventArgs e)
    {
		Pages.namespacePage np = new Pages.namespacePage();
		Navigation.PushAsync(np);
        
    }

    void Chapter3_Clicked(System.Object sender, System.EventArgs e)
    {
        //Chapter3 ch3 = new Chapter3();
        DisplayAlert("Chapter 3", "Click here to move to chapter 3", "Cancel");
        Navigation.PushAsync(new Chapter3());
    }

    void Chapter4_Clicked(System.Object sender, System.EventArgs e)
    {
        DisplayAlert("Chapter 4", "Click here to move to chapter 4", "Cancel");
        if(Chapter3.IsEnabled == true)
            {
            Chapter3.IsEnabled = false;
            }
        else { Chapter3.IsEnabled = true; }
    }

    void Chapter5_Clicked(System.Object sender, System.EventArgs e)
    {
        DisplayAlert("Chapter 5", "Click here to move to chapter 5", "Cancel");
    }

    void Chapter6_Clicked(System.Object sender, System.EventArgs e)
    {
        DisplayAlert("Chapter 6", "Click here to move to chapter 6", "Cancel");
    }

    void Chapter7_Clicked(System.Object sender, System.EventArgs e)
    {
        DisplayAlert("Chapter 7", "Click here to move to chapter 7", "Cancel");
    }

    void DependencyInjection_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new DependecyInjectionPage());
    }

}


