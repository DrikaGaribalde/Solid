
namespace Solid_SRP.Resolucao_SRP
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string? Nome { get; set; }
        public Email? Email { get; set; }
        public Cpf? Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool Validar()
        {
            return Email.Validar() && Cpf.Validar();
        }
    }
}
///A classe cliente deve ser especializada em um único assunto 
///e possuir apenas um assunto e possuir apenas uma responsabilidade
