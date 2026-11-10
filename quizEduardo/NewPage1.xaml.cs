using System.Security.Cryptography;

namespace quizEduardo;

public partial class NewPage1 : ContentPage
{
    bool respondida = false;
    string respostaSelecionada = "";
    

    public NewPage1()
	{
		InitializeComponent();
	}


  

    private async void Avancar_Clicked(object sender, EventArgs e)
    {
        if (alternativaA.IsChecked)
            respostaSelecionada = "A";

        else if (alternativaB.IsChecked)
            respostaSelecionada = "B";

        else if (alternativaC.IsChecked)
            respostaSelecionada = "C";

        else if (alternativaD.IsChecked)
            respostaSelecionada = "D";

         globalVAr.VerificarResposta(respostaSelecionada);
    }

}


