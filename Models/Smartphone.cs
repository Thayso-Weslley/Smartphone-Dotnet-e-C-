using System.Globalization;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Atributos e Construtores =====================================================================================================================
        public string Numero { get; set; }
        protected string Modelo { get; set; } 
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Funções estáticas ================================================================================================================================
            
            // relogio interno ==============================================================================================================================
        
        static private void Tempo()
        {
            int seconds = 0;
            int minutes = 0;

            while (true)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.X)
                {
                    Console.WriteLine($"\n  Ligação encerrada.\n  Tempo de duração: {minutes}:{seconds-1}\n");
                    Thread.Sleep(5000);
                    break;
                }

                Console.Clear();
                Console.WriteLine($"   Tempo passado: {minutes} minutos e {seconds} segundos \n   Precione a tecla 'x' para encerrar a ligação. \n");
                Thread.Sleep(1000);
                seconds++;

                if (seconds == 60)
                {
                    minutes++;
                    seconds = 0;
                }

                if (minutes == 60)
                {
                    Console.WriteLine("\n Sua ligação atingiu o tempo limite e foi encerrada automaticamente. \n");
                    Thread.Sleep(5000);
                    break;
                }
            }
        }
            // Espera para que uma ação aconteça =======================================================================================================
        static private void AcaoDeEspera(string Texto, int NumeroDePontos, int Vezes, int Milisegundos)
        {
            for(int i = 0; i < Vezes; i++)
            {
                Console.Clear();
                Console.Write(Texto);
                for(int j = 0; j < NumeroDePontos; j++)
                {
                    Console.Write(".");
                    Thread.Sleep(Milisegundos);
                }
            }
            Console.Clear();
        }

        // Métodos ======================================================================================================================================
        
            // Fazer Ligação ============================================================================================================================
        public void Ligar()
        {
            AcaoDeEspera("Ligando", 3, 3, 800);
            Console.WriteLine("   O número que você ligou não está atendendo, nem possue caixa postal. \n   Por favor, tente mais tarde.\n");
            Thread.Sleep(5000);
        }

            // Receber Ligação =========================================================================================================================
        public void ReceberLigacao()
        {
            Console.Clear();
            while(true)
            {
                Console.Write("  O número XXXXX-XXXX está te ligando.\n  Deseja atender? (s/n): ");
                string call = Console.ReadLine().ToLower().Trim();

                // Atender Ligação======================================================================================================================

                if(call == "s")
                {
                    AcaoDeEspera("Atendendo Ligação", 3, 3, 100);
                    Tempo();
                    break;
                }

                // Recusar Ligação ======================================================================================================================

                else if(call == "n")
                {
                    Console.Clear();
                    Console.Write("Ligação Recusada.\n\n");
                    Thread.Sleep(3500);
                    break;
                }

                // Tratamento de Opção Inválida =========================================================================================================

                else
                {
                    Console.Clear();
                    Console.WriteLine("Essa opção não é válida!\n");
                    Thread.Sleep(3500);
                }
            }
        }

            // Desligar Celular =========================================================================================================================

        public void Desligar(string celular)
        {
            AcaoDeEspera($"Desligando {celular}", 4, 4, 800);
            Console.WriteLine("\n\n   Thayso: Obrigado por testar meu programa em .Net e C#\n\n");
            Thread.Sleep(5000);
        }
            
            // Instalar Aplicativo ======================================================================================================================

        public abstract void InstalarAplicativo(string nomeApp);
    }
}