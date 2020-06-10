namespace Aula_13_Uber
{
    public class Conta
    {
        public string agencia { get; set; }
        public string conta { get; set; }

        public string Cadastrar(){
            return "Conta Cadastrada! ";
        }
        public void Excluir(){
            System.Console.WriteLine("Conta Excluída! ");
        }
    }
}