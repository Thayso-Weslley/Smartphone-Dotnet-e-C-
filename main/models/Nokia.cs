using main.Models;

namespace main.Models
{
    // Classe Herdada de Smartphone ==========================================================================================
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){}
        public Nokia(){}


        // Método InstalarAplicativo() sobrescrito ===========================================================================
        public override void InstalarAplicativo(string nomeApp)
        {
            // Instalando Aplicativo ==========================================================================================
            
            Console.Clear();
            for(int i = 0; i <= 100; i++)
            {
                Console.Clear();
                Console.Write($"Instalando aplicativo: {i}%");
                Thread.Sleep(50);
            }
            Console.Write(" Concluido.");
            Thread.Sleep(5000);
            Console.WriteLine($"\nO aplicativo {nomeApp} foi instalado no seu Nokia com sucesso!\n\n");
        }
    }
}