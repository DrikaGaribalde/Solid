
namespace Solid_SRP.Resolucao_SRP
{
    public class Email
    {
        public string Endereco { get; set; }

        public bool Validar()
        {
            // Aqui você pode implementar a lógica de validação do e-mail
            // Retorna verdadeiro se o e-mail for válido e falso caso contrário
            return !string.IsNullOrWhiteSpace(Endereco);
        }
    }
}
