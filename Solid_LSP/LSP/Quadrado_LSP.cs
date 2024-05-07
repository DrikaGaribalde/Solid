namespace Solid_LSP.LSP
{
    public class Quadrado_LSP : Retangulo_LSP
    {
        public override double Altura
        {
            set {
                base.Altura = value;
                base.Largura = value;
            }
        }

        public override double Largura
        {
            set {
                base.Altura = value;
                base.Largura = value;
            }
        }
    }

}
