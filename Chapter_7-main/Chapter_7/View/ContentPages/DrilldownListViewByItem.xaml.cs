using Chapter_7.Classes.Data;

namespace Chapter_7.View.ContentPages;

public partial class DrilldownListViewByItem : ContentPage
{
	public DrilldownListViewByItem()
	{
		InitializeComponent();
		itemList.ItemsSource = new ItemData[]
		{
			new ItemData { name="Mohammed" , id ="000"},
			new ItemData { name = "Rasha" , id ="111"},
			new ItemData { name = "Hasan" , id ="222"},
			new ItemData { name = "Ahmed" , id = "333"}
		};
	}

    private async void itemList_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		
		var p = e.Item as ItemData;
		if(p == null) return;
		await Navigation.PushAsync(new DetailPage(p));
		itemList.SelectedItem = null;
		
		// List view by page : not working actually?
		//Generate page by list to show list's item details...
		/*
		var item = itemList.SelectedItem as ItemData;
		if (item != null) { return ; }
		Page p = (Page)Activator.CreateInstance(typeof(ItemData),item.name,item.id);
		await Navigation.PushAsync(p);
		itemList.SelectedItem = null;
		*/
    }
}