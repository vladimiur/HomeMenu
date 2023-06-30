namespace HomeMenu;

public partial class Superficie : ContentPage
{
	public Superficie()
	{
		InitializeComponent();
	}

    private void CLrespuestas_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Xaltura.Text) && !String.IsNullOrEmpty(Xbase.Text))
		{
			double ValorA,ValorB;
			ValorA = Convert.ToDouble(Xaltura.Text);
			ValorB = Convert.ToDouble(Xbase.Text);
            double respuesta = (ValorA + ValorB) / 2;
            resp.Text = Convert.ToString(respuesta);
        }
        else
        {
            DisplayAlert("Error", "Introduce todos los numeros", "Ok");
        }

    }
}