using System;

namespace Aula_13_Uber
{
    public class Corrida
    {
        public int localInicio { get; set; }
        public int localChegada { get; set; }
        public string statusCorrida { get; set; }
        public string motorista { get; set; }
        public string passageiro { get; set; }
        public int valorFixo { get; set; }
        public int valorKm { get; set; }
        public int kmcorrida { get; set; }
        public int valorTotal { get; set; }

        public string Cancelar(){
            return "Corrida Cancelada! ";
        }
        
        public string ValorCorrida(){
            motorista = "Rogério";
            passageiro = "Tiago";
            localInicio = 2;
            localChegada = 10;
            kmcorrida = localChegada - localInicio;

            valorFixo = 5;
            valorKm = 2;
            valorTotal = valorFixo + (valorKm * kmcorrida); 
            return $"O valor fixo e o valor por km cobrado por {motorista} é respectivamente RS {valorFixo}, RS {valorKm}, e o valor total a ser pago por {passageiro} é RS {valorTotal}";
        }
    }
}