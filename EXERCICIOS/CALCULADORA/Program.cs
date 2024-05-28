using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao programa de operações aritméticas!");
        Console.WriteLine("Por favor, siga as instruções abaixo:");

        // Solicitar o primeiro número ao usuário
        Console.WriteLine("Digite o primeiro número:");
        double num1;
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Entrada inválida! Por favor, digite um número válido:");
        }

        // Solicitar o operador aritmético ao usuário
        Console.WriteLine("Digite o operador aritmético (+, -, *, /):");
        char operador;
        while (!char.TryParse(Console.ReadLine(), out operador) || (operador != '+' && operador != '-' && operador != '*' && operador != '/'))
        {
            Console.WriteLine("Operador inválido! Por favor, digite um operador válido:");
        }

        // Solicitar o segundo número ao usuário
        Console.WriteLine("Digite o segundo número:");
        double num2;
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Entrada inválida! Por favor, digite um número válido:");
        }

        // Realizar o cálculo com base no operador fornecido
        double resultado = 0;
        try
        {
            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        throw new DivideByZeroException("Erro: divisão por zero!");
                    }
                    break;
            }

            // Exibir o resultado
            Console.WriteLine($"Resultado: {resultado}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}
