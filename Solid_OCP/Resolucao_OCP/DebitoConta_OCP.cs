namespace Solid_OCP.Resolucao_OCP
{
    public abstract class DebitoConta_OCP
    {
        public string NumeroTransacao { get; set; }

        public abstract string Debitar(decimal valor, string conta);

        public string FormatarTransacao()
        {
            const string chars = "ABCasDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var randon = new Random();
            NumeroTransacao = new string(Enumerable.Repeat(chars, 15)
            .Select(s => s[randon.Next(s.Length)]).ToArray());

            return NumeroTransacao;
        }
    }
}
