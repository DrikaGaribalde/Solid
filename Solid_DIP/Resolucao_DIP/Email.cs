namespace Solid_DIP.Resolucao_DIP
{
    internal class Email
    {
        public string Endereco { get; set; }

        public bool Validar()
        {
            return Endereco.Contains("@");
        }
    }
}
