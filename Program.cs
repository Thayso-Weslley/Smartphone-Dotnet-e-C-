using DesafioPOO.Models;

// Instâncias ========================================================================================================================================

Nokia nokia = new Nokia("(81)98411-5541", "WIndowsPhone", "89789789789", 256);
Iphone IPhone = new Iphone("(81)99148-8162", "XR", "12345678765432", 64);

// Escolher o SmartPhone =============================================================================================================================

Console.Clear();
Console.Write("Olá!\nSeja bem vindo ao meu código!" +
                  "\nPara prosseguir preciso que escola um celular, mas pense bem, pois o modelo escolhido será usado até o fim do programa:" +
                  "\n\n   a) Nokia WindowsPhone \n   b) IPhone XR\n\n" +
                  "Opção: ");

string celular = Console.ReadLine().ToLower().Trim();
while(celular != "a" && celular != "b")
{
    Console.Clear();
    Console.Write("   Escolha inválida!\n   Para proceguir com o programa, preciso que escolha um dos modelos abaixo:"+
                  "\n\n   a) Nokia WindowsPhone \n   b) IPhone XR\n\n" +
                  "Opção: ");

    celular = Console.ReadLine().ToLower().Trim();
}

Console.Clear();
if(celular == "a")
{
    celular = "Nokia";
    Console.WriteLine($"   Ótimo!\n   Você escolheu o {celular} WindowsPhone\n");
}
if(celular == "b")
{
    celular = "IPhone";
    Console.WriteLine($"   Ótimo!\n   Você escolheu o {celular} XR\n");
}

// Menu do SmartPhone ===============================================================================================================================

string option;
do
{
    Console.Write($"O que pretende fazer com o seu {celular} agora?\n\n");
    Console.Write($"   a) Fazer uma ligação\n   b) Receber uma ligação\n   c) Baixar um aplicativo\n   d) Desligar o {celular}\n\n   Opção: ");

    option = Console.ReadLine().ToLower().Trim();

    switch (option)
    {
        // Fazer Ligação ============================================================================================================================
        case "a":
            if(celular=="Nokia"){nokia.Ligar();}
            if(celular=="IPhone"){IPhone.Ligar();}
            break;

        // Receber Ligação ==========================================================================================================================
        case "b":
            if(celular=="Nokia"){nokia.ReceberLigacao();}
            if(celular=="IPhone"){IPhone.ReceberLigacao();}
            break;

        // Intalar Aplicativo =======================================================================================================================
        case "c":
            Console.Clear();
            Console.Write("   Escreva o nome do applicativo que você deseja installar: ");
            string App = Console.ReadLine().Trim();
            if(celular=="Nokia"){nokia.InstalarAplicativo(App);}
            if(celular=="IPhone"){IPhone.InstalarAplicativo(App);}
            break;

        // Desligar Celular e Encerrar o Programa ===================================================================================================
        case "d":
            Console.Clear();

            for(int i = 0; i <= 3; i++)
            {
                Console.Clear();
                Console.Write($"Desligando {celular}");
                for(int j = 0; j <= 2; j++)
                {
                    Console.Write(".");
                    Thread.Sleep(800);
                }
            }
            
            Console.WriteLine("\n\n   Thayso: Obrigado por testar meu programa em .Net e C#\n\n");
            Thread.Sleep(5000);
            break;

        // Tratamento de opção inválida ============================================================================================================
        default:
            Console.Clear();
            Console.WriteLine("Opção inválida");
            break;

    
    }
} while(option != "d");