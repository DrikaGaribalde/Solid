namespace Solid_DIP.Resolucao_DIP
{
    internal interface IEmailServices
    {
        void Enviar(string de, string para, string assunto, string mensagem);
    }
}
