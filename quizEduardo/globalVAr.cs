using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace quizEduardo
{
    public static class globalVAr {
        public static double Pontucao { get; set; } = 0;
        public static string[] respostasCertas =
        {
            "A",
            "B",
            "C",
            "D",
            "A",
            "B",
            "C",
            "D",
            "A",
            "B"
        };
        public static int perguntaAtual { get; set; } = 0;
     
       
       public static async Task<bool> VerificarResposta(string respostaSelecionada)
        {
            if (string.IsNullOrEmpty(respostaSelecionada))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Atenção",
                    "Selecione uma alternativa!",
                    "OK");

                return false;
            }

            string respostaCerta = respostasCertas[perguntaAtual];

            if (respostaCerta == respostaSelecionada)
            {
                Pontucao++;

                await Application.Current.MainPage.DisplayAlert(
                    "Resposta Correta",
                    "Você acertou a resposta!",
                    "OK");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Resposta Incorreta",
                    "Você errou a resposta!",
                    "OK");
            }

            perguntaAtual++;

            return true;
        }


    }
}
    


