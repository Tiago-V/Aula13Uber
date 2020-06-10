namespace Aula_13_Uber
{
    public class Cartao
    {
       public string numero { get; set; }
       public string titular { get; set; }
       public string bandeira { get; set; }
       public string cvv { get; set; }

       public string Cadastrar(){
           return "Cartão cadastrado! ";
       }
       public void Excluir(){
           System.Console.WriteLine("Cartão Excluído!");
       }        
    }
}