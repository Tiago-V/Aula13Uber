using System;

namespace Aula_13_Uber
{
    class Program
    {
        static void Main(string[] args)
        {

            //Login
            
            Usuario user = new Usuario();
            Corrida run = new Corrida();
            Passageiro passenger = new Passageiro();
            Motorista driver = new Motorista();

            Console.WriteLine("Digite Seu Login: ");
            string login = Console.ReadLine();

            Console.WriteLine("Digite Sua Senha: ");
            string senha = Console.ReadLine();

            user.Login(login, senha);

            if(user.TokenLogin != "" && user.TokenLogin != null){

                Console.WriteLine("Acesso liberado! Usuário Logado! ");
                Console.WriteLine(user.TokenLogin);

            }else{
                Console.WriteLine("Usuário deslogado! ");
            }

            //Passageiro
            
            Console.WriteLine(passenger.ProcurandoMotorista());
            Console.WriteLine();

            Console.WriteLine("Destino definido.");
            Console.WriteLine("Corrida iniciada.");

            Console.WriteLine("A quilometragem da corrida é de "+run.kmcorrida+"km.");
            Console.WriteLine(run.ValorCorrida());
            Console.WriteLine(passenger.Pagar("Finalizado"));

            Console.WriteLine("Corrida finalizada.");

            //Motorista

            Console.WriteLine("Aceitar passagerio? \aSim. \aNão.");
            driver.aceitar = Console.ReadLine();
            Console.WriteLine(driver.aceitarPassageiro("Tiago"));
            Console.WriteLine();

            Console.WriteLine(driver.CarroPlaca());
            Console.WriteLine();

            Console.WriteLine(driver.receberPagamento()); 
        }
    }
}
