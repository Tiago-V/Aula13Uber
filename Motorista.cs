namespace Aula_13_Uber
{
    public class Motorista : Usuario
    {
        public string carro { get; set; }
        public string placa { get; set; }
        public string aceitar { get; set; }

        public string aceitarPassageiro( string nome ){
            if(aceitar == "Sim"){

                return "Passageiro aceito: "+nome;

            }else if(aceitar == "Não"){

                return "Passageiro recusado: "+nome;

            }else{

            return "Valor Inválido";
            
            }
        }
        public string CarroPlaca(){
            carro = "Toyota Etios Sedan X Plus - Preto";
            placa = "SPO-3179";
            return $"Carro: {carro} \aPlaca: {placa}";
        }
        public bool receberPagamento(){
            System.Console.WriteLine("Pagamento recebido.");
            return true;
        }
    }
}