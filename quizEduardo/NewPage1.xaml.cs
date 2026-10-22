namespace quizEduardo;

public partial class NewPage1 : ContentPage
{
    bool respondida = false;
	public NewPage1()
	{
		InitializeComponent();
	}


  

    private void Avancar_Clicked(object sender, EventArgs e)
    {
      if (respondida)
            return;

        if (rbD.IsChecked == false &&
            rbA.IsChecked == false &&
            rbC.IsChecked == false &&
            rbD.IsChecked == false)
        {
            await DisplayAlert(
          "Atenção",
          "Selecione uma alternativa.",
          "OK");

            return;

        }
    }
}

