namespace Solid_LSP.Resolucao_LSP
{
    internal class Quadrado_LSP: Paralelogramo_LSP
    {
        public Quadrado_LSP(int altura, int largura)
               : base(altura, largura)
        {
            if (largura != altura)
                throw new ArgumentException("Os dois lados do quadrado precisam ser iguais");
        }
    }
}
