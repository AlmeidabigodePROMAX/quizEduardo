namespace quizEduardo;

public partial class NewPage5 : ContentPage
{
    respostaSelecionada = "";

    public NewPage5()
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

        if (respostaSelecionada == "")
        {
            await DisplayAlert("SELECIONE UMA ALTERNATIVA", "SELECIONE UMA ALTERNATIVA", "OK");
            return;
        }

        await globalVAr.VerificarResposta(respostaSelecionada);
        await Navigation.PushAsync(new NewPage5());
    }
}