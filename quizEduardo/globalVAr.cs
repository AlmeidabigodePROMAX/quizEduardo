using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace quizEduardo
{
    public static class globalVAr
    {
        public static double Pontucao { get; set; } = 0;

        public static string[] respostasCertas =
        {
            "A", "B", "C", "D",
            "A", "C", "C", "B"
        };

        public static int perguntaAtual { get; set; } = 0;

        public static async Task<bool> VerificarResposta(string respostaSelecionada)
        {
            if (string.IsNullOrWhiteSpace(respostaSelecionada))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Atenção",
                    "Selecione uma alternativa!",
                    "OK");

                return false;
            }

            if (perguntaAtual >= respostasCertas.Length)
                return false;

            string respostaCerta = respostasCertas[perguntaAtual];

            if (respostaCerta == respostaSelecionada)
            {
                Pontucao++;

                await Application.Current.MainPage.DisplayAlert(
                    "Resposta correta",
                    "Você acertou!",
                    "OK");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Resposta incorreta",
                    $"Você errou! A resposta certa é: {respostasCertas[perguntaAtual]}",
                    "OK");
            }

            perguntaAtual++;

            return true;
        }
    }

}



