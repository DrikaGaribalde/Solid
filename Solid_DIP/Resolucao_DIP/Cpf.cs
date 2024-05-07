namespace Solid_DIP.Resolucao_DIP
{
    internal class Cpf
    {
        public string Numero { get; set; }

        public bool Validar()
        {
            return Numero.Length == 11;
        }
    }
}
