using System;
using System.Collections.Generic;
using System.Linq;
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
        public static bool VerificarResposta(string respostaSelecionada)
        {
            string respostaCerta = respostasCertas[perguntaAtual];

            switch (respostaSelecionada == respostaCerta)
            {
                case true:
                    Pontucao++;
                    return true;

                case false:
                    return false;

                default:
                    return false;
            }
        }
    }
    

}
