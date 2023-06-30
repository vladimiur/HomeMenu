using System.Text.RegularExpressions;

namespace HomeMenu;

public partial class Dinosaurio : ContentPage
{
	public Dinosaurio()
	{
		InitializeComponent();
	}

   
    private void btncalcul_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(pes.Text) && !String.IsNullOrEmpty(altu.Text))
		{
			double ValorA, ValorB;
            ValorA = Convert.ToUInt32(pes.Text);
            ValorB = Convert.ToUInt32(altu.Text);
            double respuestasx = Math.Pow(ValorA % ValorB, 2);
            respu.Text = "R/" + Convert.ToString(respuestasx);
        }
        else
        {
            DisplayAlert("Error", "Introduce todos los numeros", "Ok");
        }


    }
}