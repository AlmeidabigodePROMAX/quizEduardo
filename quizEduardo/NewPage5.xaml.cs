namespace quizEduardo;

public partial class NewPage5 : ContentPage
{
    

    public NewPage5()
	{
		InitializeComponent();
	}

    private async void Avancar_Clicked(object sender, EventArgs e)
    {
        string respostaSelecionada = "";
        if (alternativaA.IsChecked)
            respostaSelecionada = "A";

        else if (alternativaB.IsChecked)
            respostaSelecionada = "B";

        else if (alternativaC.IsChecked)
            respostaSelecionada = "C";

        else if (alternativaD.IsChecked)
            respostaSelecionada = "D";

        bool podeavancar = await globalVAr.VerificarResposta(respostaSelecionada);
        if (!podeavancar)
            return;
        await Navigation.PushAsync(new NewPage6());
    }
}