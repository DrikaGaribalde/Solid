namespace Solid_LSP.Resolucao_LSP
{
    internal class CalculoArea_LSP
    {
        public static void ObterAreaParalelogramo(Paralelogramo_LSP ret)
        {
            Console.Clear();
            Console.WriteLine("Calculo da área do Retangulo");
            Console.WriteLine();
            Console.WriteLine(ret.Altura + " * " + ret.Largura);
            Console.WriteLine();
            Console.WriteLine(ret.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {
            var quad = new Quadrado_LSP(5, 5);
            var ret = new Retangulo_LSP(10, 5);

            ObterAreaParalelogramo(quad);
            ObterAreaParalelogramo(ret);
        }
    }
}
///O princípio de Liskov Substitution Principle nos permite usar o polimorfismo 
///com mais confiança. Podemos chamar nossas classes derivadas 
///referindo-se à sua classe base sem preocupações com resultados inesperados.