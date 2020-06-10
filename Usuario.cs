namespace Aula_13_Uber
{
    public class Usuario
    {
        private int idade;
        public int Idade
        {
            get { return idade; }
            set {
                 if(idade > 0){
                    idade = value;
                } 
            }
        }   
        public string nome { get; set; }

        private string login = "tiago@gmail.com";
        
        private string senha = "1234";

        public string Foto { get; set; }
        public string LocalizacaoAtual { get; set; }
        public string TokenLogin { get; set; }

        public bool Login(string login, string senha){
        
            if( this.login == login && this.senha == senha ){
                TokenLogin = "1524";
                return true;
            }

            return false;
        }

        public void Logout(){
            TokenLogin = "";

        }

    }
}