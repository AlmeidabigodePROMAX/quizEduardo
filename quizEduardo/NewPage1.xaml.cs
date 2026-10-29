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
      globalVAr.VerificarResposta(respostaSelecionada);
    }
}

