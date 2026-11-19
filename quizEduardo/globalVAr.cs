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
     
        public static async Task VerificarResposta(string respostaSelecionada)
        {
            string respostaCerta = respostasCertas[perguntaAtual];

            if(respostaSelecionada == "")
            {
                await Application.Current.MainPage.DisplayAlert("SELECIONE UMA ALTERNATIVA", "SELECIONE UMA ALTERNATIVA", "OK");
            }
            else if (respostaCerta == respostaSelecionada)
            {

             
                Pontucao++;
                await Application.Current.MainPage.DisplayAlert("Resposta Correta", "Você acertou a resposta!", "OK");
                

            }
            else { 
                await Application.Current.MainPage.DisplayAlert("Resposta Incorreta", "Você errou a resposta!", "OK");
                
            }
            
        }
           
        }
    }
    


