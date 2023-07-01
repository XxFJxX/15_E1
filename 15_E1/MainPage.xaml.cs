namespace _15_E1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        int P = Convert.ToInt32(Pr.Text);
        int C = Convert.ToInt32(Ca.Text);

        int ca = P - C;



        Cam.Text = "Su cambio es de :  $" + ca;
     
    }
}

