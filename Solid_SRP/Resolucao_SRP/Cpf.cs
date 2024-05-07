
namespace Solid_SRP.Resolucao_SRP
{
    public class Cpf
    {
        public string Numero { get; set; }

        public bool Validar()
        {
            // Aqui você pode implementar a lógica de validação do CPF
            // Retorna verdadeiro se o CPF for válido e falso caso contrário
            // Por exemplo, você pode validar o formato do CPF e usar um algoritmo de verificação
            return !string.IsNullOrWhiteSpace(Numero) && Numero.Length == 11; // Exemplo simples de validação
        }
    }
}
