namespace Astronomy.Pages;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
        btnprofile1.Clicked += async (s, e) => await Shell.Current.GoToAsync("profiledetails?dataName=profile");
    }
}