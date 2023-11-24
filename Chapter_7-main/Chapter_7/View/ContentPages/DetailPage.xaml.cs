using Chapter_7.Classes.Data;

namespace Chapter_7.View.ContentPages;

public partial class DetailPage : ContentPage
{
	public DetailPage(ItemData i)
	{
		InitializeComponent();
		this.BindingContext = i;
	}
}