namespace Chapter_7.View.p3;

public partial class Page3 : ContentPage
{
	public Page3(string strCon="0")
	{
		InitializeComponent();
		this.Title = strCon;
		var idInt = Preferences.Get("id",0);
		lbl1.Text = "presistence value by preference type saved in application: " + idInt.ToString();
	}
}