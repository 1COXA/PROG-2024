using _240401_01.Models;
using _240401_01.Views;

bool aux = true;
do{
    Console.WriteLine("**********************");
    Console.WriteLine("MEU POGRAMA DE PIDIDUX");
    Console.WriteLine("**********************");
    Console.WriteLine();

    Console.WriteLine("1 - Clientes");
    Console.WriteLine("2 - Produtos");
    Console.WriteLine("3 - Pedidos");
    Console.WriteLine("0 - SAIR");

    int menu = 0;

    try
    {
        menu = Convert.ToInt32(Console.ReadLine());

        switch(menu)
        {
            case 1:
                CustomerView customerView = 
                    new CustomerView();
            break;
            
            case 2:
            break;

            case 3:
            break;

            case 0:
                aux = false;
                Console.WriteLine("Obrigado e volte sempre!");
            break;

            default:
                Console.WriteLine("Opção inválida.");                         
            break;
        }
    }
    catch
    {
        Console.WriteLine("Opção inválida.");
        menu = -1;
        aux = true;
    }

}while(aux);


/*
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Customer c1 = new Customer();
c1.CustomerId = 1;
c1.Name = "Jaguara";
c1.EmailAddress = "jaguara@pixote.net";

// Construtor de Instanciação
Customer c2 = new Customer(2);
c1.Name = "Boca-Mole";
c1.EmailAddress = "bocamole@pixote.net";

// Construtor por atribuição
Customer c3 = new Customer{
    CustomerId = 3,
    Name = "Nerso",
    EmailAddress = "nerso@pixote.com"
};
*/