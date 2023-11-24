namespace IntroMAUI;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    public void Slider_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
		int val = Convert.ToInt32(MySlider.Value);
		//DisplayAlert(val.ToString(),"test","close");
		img.WidthRequest = val;
		img.HeightRequest = val;
		
    }

    public async void TapGestureRecognizer_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
		Image i = (Image)sender;
		i.Opacity = .5;
		await Task.Delay(200);
		i.Opacity = 1;
    }
}


