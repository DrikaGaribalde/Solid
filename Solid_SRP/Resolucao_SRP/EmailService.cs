using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_SRP.Resolucao_SRP
{
    public class EmailService
    {
        public static void Enviar(string remetente, string destinatario, string assunto, string corpo)
        {
            // lógica para enviar o e-mail
            Console.WriteLine($"Enviando e-mail de: {remetente}");
            Console.WriteLine($"Para: {destinatario}");
            Console.WriteLine($"Assunto: {assunto}");
            Console.WriteLine($"Corpo: {corpo}");
            Console.WriteLine("E-mail enviado com sucesso!");
        }
    }
}
