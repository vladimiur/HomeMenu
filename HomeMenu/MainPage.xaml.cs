namespace HomeMenu;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

    async void btnvuelto_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Producto());
    }

    async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Superficie());
    }

    async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Dinosaurio());
    }

     async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Gaasolinera());
    }
}

