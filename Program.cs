using System;

namespace Assistant
{
    class Program
    {
        static void Main (string[] args)
        {
            Menu();
        }
        static void Menu(){
            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine("*BEM-VINDO AO ASSISTANT*");
            Console.WriteLine("1- Calculator");
            Console.WriteLine("2- Stopwatch");
            Console.WriteLine("3- TextEditor");
            Console.WriteLine("0- Sair");
            Console.WriteLine("----------------------------");
            Console.Write("Escolha uma opção: ");
            short option = short.Parse(Console.ReadLine());

            if(option == 0){
                Console.Clear();
                Console.WriteLine("Obrigado por acesssar o Assistant | Volte sempre!");
                Console.WriteLine("Attention: Press ENTER to exit!");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            switch(option)
            {
                case 1: Calculator(); break;
                case 2: Stopwatch(); break;
                case 3: TextEditor(); break;
                default: Menu(); break;
            }
        }
        static void Calculator()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("*BEM-VINDO A CALCULADORA DO ASSISTANT*");
            Console.WriteLine("1- Somar");
            Console.WriteLine("2- Subtrair");
            Console.WriteLine("3- Dividir");
            Console.WriteLine("4- Multiplicar");
            Console.WriteLine("0- Back tu menu");
            Console.WriteLine("----------------------------");
            Console.Write("Escolha uma opção: ");
            short option = short.Parse(Console.ReadLine());

            if(option == 0)
            {
                Menu();
            }

            Console.WriteLine($"Agora, digite os valores que deseja:");

            Console.Write("Digite o Valor 1: ");
            float v1 = float.Parse(Console.ReadLine());


            Console.Write("Digite o Valor 2: ");
            float v2 = float.Parse(Console.ReadLine());


            switch(option)
            {
                case 1: Somar(v1, v2); break;
                case 2: Subtrair(v1, v2); break;
                case 3: Dividir(v1, v2); break;
                case 4: Multiplicar(v1, v2); break;
            }

        }
        static void Somar(float v1, float v2)
        {
            Console.WriteLine($"Valor da soma de V1 + V2 = {v1+v2}");
            Console.ReadKey();
            Calculator();
        }
        static void Subtrair(float v1, float v2)
        {
            Console.WriteLine($"Valor da subtração de V1 - V2 = {v1-v2}");
            Console.ReadKey();
            Calculator();    
        }
        static void Dividir(float v1, float v2)
        {
            Console.WriteLine($"Valor da divisão de V1 / V2 = {v1/v2}");
            Console.ReadKey();
            Calculator();
        }
        static void Multiplicar(float v1, float v2)
        {
            Console.WriteLine($"Valor da multiplicação de V1 * V2 = {v1*v2}");
            Console.ReadKey();
            Calculator();
        }
        static void Stopwatch()
        {
            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine("*BEM-VINDO AO STOPWATCH DO ASSISTANT*");
            Console.WriteLine("S- Calc. em Segundos -> 10s -> 10 Segundos");
            Console.WriteLine("M- Calc. em Minutos -> 1m - 1 Minuto");
            Console.WriteLine("0- Back to menu");
            Console.WriteLine("----------------------------");
            Console.Write("Escolha uma opção: ");
            short option = short.Parse(Console.ReadLine());
        }

        static void TextEditor()
        {

        }
    }
}