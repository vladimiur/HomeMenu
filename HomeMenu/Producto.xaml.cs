namespace HomeMenu;

public partial class Producto : ContentPage
{
	public Producto()
	{
		InitializeComponent();
	}

   

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(preci.Text) && !String.IsNullOrEmpty(diner.Text))
        {
            double dato1,dato2;
            dato1= Double.Parse(preci.Text);
            dato2 = Double.Parse(diner.Text);
            double Resultado = (dato2 - dato1);
            camb.Text = "$" + Convert.ToString(Resultado);
        }
        else
        {
            DisplayAlert("Error", "Introduce todos los numeros", "Ok");
        }
            
        
        
        
    }
}