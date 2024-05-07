namespace Solid_LSP.Resolucao_LSP
{
    internal class Paralelogramo_LSP
    {
        protected Paralelogramo_LSP(int altura, int largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public double Altura { get; private set; }
        public double Largura { get; private set; }
        public double Area { get { return Altura * Largura; } }
    }
}
