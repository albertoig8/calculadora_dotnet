using System;

namespace calculadora_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double n1;
            double n2;
            double resultado;
            bool validacao = true;
            Program program = new Program();

            Console.WriteLine("###Seja bem vindo a calculadora DOTNET###");

            do
            {
                Console.WriteLine("Qual a operação desejada?");
                Console.WriteLine("(1) Soma");
                Console.WriteLine("(2) Subtração");
                Console.WriteLine("(3) Multiplicação");
                Console.WriteLine("(4) Divisão");
                Console.WriteLine("(5) Sair");

                Console.WriteLine("Digite a sua opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o primeiro número: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        n2 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.Soma(n1, n2);
                        Console.WriteLine("O resultado da minha soma é {0}", resultado);

                        
                        break;

                    case 2:
                        Console.WriteLine("Digite o primeiro número: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        n2 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.Subitracao(n1, n2);
                        Console.WriteLine("O resultado da minha subitração é {0}", resultado);
                        
                        break;

                    case 3:
                        Console.WriteLine("Digite o primeiro número: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        n2 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.Multiplicacao(n1, n2);
                        Console.WriteLine("O resultado da minha multiplicação é {0}", resultado);
                        
                        break;

                    case 4:
                        Console.WriteLine("Digite o primeiro número: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        n2 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.Divisao(n1, n2);
                        Console.WriteLine("O resultado da minha divisão é {0}", resultado);
                        
                        break;

                    case 5:
                        validacao = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        
                        break;
                }
                Console.WriteLine("Aperte Enter para continuar");
                Console.ReadLine();
                Console.Clear();
            } while (validacao);

            
        }

        public double Soma(double n1,  double n2)
        {
            return n1 + n2;
        }

        public double Subitracao(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Multiplicacao(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Divisao(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
