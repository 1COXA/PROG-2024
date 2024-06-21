using MVC_JOGADORES.Views;

int option = 0;

do
{
    Console.WriteLine("-------------------------------");
    Console.WriteLine("Programa para gestão de dados!");
    Console.WriteLine("------------------------------");
    Console.WriteLine("1 - Jogadores");

    option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.WriteLine("Opção Jogadores");
            JogadorView jogadorView = new JogadorView();
            break;
    }
} while (option > 0);
