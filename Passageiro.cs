namespace Aula_13_Uber
{
    public class Passageiro : Usuario
    {
        public string ProcurandoMotorista(){

            System.Console.WriteLine("Procurando motoristas disponíveis...");

            return "Motorista encontrado! ";
        }
        public string Pagar( string statusCorrida ){
            if(statusCorrida == "Finalizado"){
                return "Pagamento efetuado";
            }
            return "Pagamento pendente pois a corrida não foi finalizada";
        }
    }
}