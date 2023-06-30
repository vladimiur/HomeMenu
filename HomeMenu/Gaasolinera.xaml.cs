namespace HomeMenu;

public partial class Gaasolinera : ContentPage
{
	public Gaasolinera()
	{
		InitializeComponent();
	}

    private void btncalcular_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(litro.Text))
		{
			double Dato1;
            Dato1 = Convert.ToInt32(litro.Text);
            double respuesta = (Dato1 * 0.2642);
            galon.Text = Convert.ToString(respuesta);
        }	
        else
        {
            DisplayAlert("Error", "Introduce todos los numeros", "Ok");
        }

        
		
		

    }
}