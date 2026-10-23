using System.Security.Cryptography;

namespace quizEduardo;

public partial class NewPage1 : ContentPage
{
    bool respondida = false;
    string respostaSelecionada = "";
    string respostaCerta = globalVAr.respostasCertas[globalVAr.perguntaAtual];

    public NewPage1()
	{
		InitializeComponent();
	}


  

    private async void Avancar_Clicked(object sender, EventArgs e)
    {
        
        if (respondida)
            return;

        if (rbD.IsChecked == false &&
            rbA.IsChecked == false &&
            rbC.IsChecked == false &&
            rbB.IsChecked == false)
        {
            await DisplayAlert(
          "Atenção",
          "Selecione uma alternativa.",
          "OK");
            return;

        } 

        if (rbA.IsChecked)
            respostaSelecionada = "A";
        else if (rbB.IsChecked)
            respostaSelecionada = "B";
        else if (rbC.IsChecked)
            respostaSelecionada = "C";
        else if (rbD.IsChecked)
            respostaSelecionada = "D";


        await Navigation.PushAsync(new NewPage1());
    }
}

