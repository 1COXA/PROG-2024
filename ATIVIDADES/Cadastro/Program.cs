using System.Collections;
using System.Linq.Expressions;

bool sair = false;
Hashtable hashtable = new();

Console.WriteLine("Bem-vindo ao programa de cadastro de usuários");

while (sair==false)
{
    string ? nome = "";
    string ? nascimento = "";
    string ? sexo = "";
    string ? email = "";
    string ? cpf = "";
    string ? cep = "";
    string ? endereço = "";
    string ? bairro = "";
    string ? estado = "";
    string ? pais ="";

    
    while (nome=="")
    {
        Console.WriteLine("Digite o nome:");
        nome = Console.ReadLine() ?? "";
        if(nome=="")
        {
            Console.WriteLine("\x1b[1;31mErro:\x1b[0m Nome não pode ser vazio.");
        }
    }


    while (nascimento=="")
    {
        Console.WriteLine("Digite a data de nascimento (somente números):");
        nascimento = Console.ReadLine() ?? "";
        
        if (nascimento.Length != 6)
        {   
            if(nascimento == "")
            {
                Console.WriteLine("\x1b[1;31mErro:\x1b[0m Data de nascimento não pode ser vazio.");
            }
            else
            {
                Console.WriteLine("\x1b[1;31mErro:\x1b[0m Data deve conter 6 caracteres, sendo apenas os números.");
            }
            nascimento="";
        }
    }

    while (sexo=="")
    {
        Console.WriteLine("Digite seu sexo ou genero:");
        nome = Console.ReadLine() ?? "";
        if(sexo=="")
        {
            Console.WriteLine("\x1b[1;31mErro:\x1b[0m O sexo/genero não pode ser vazio.");
        }
    }

    while (email=="")
    {
        Console.WriteLine("Digite seu email:");
        nome = Console.ReadLine() ?? "";
        if(email=="")
        {
            Console.WriteLine("\x1b[1;31mErro:\x1b[0m O email não pode ser vazio.");
        }
    }



    while (cpf=="")
    {
        Console.WriteLine("Digite o CPF (somente números):");
        cpf = Console.ReadLine() ?? "";
        
        if (cpf.Length != 11)
        {   
            if(cpf == "")
            {
                Console.WriteLine("\x1b[1;31mErro:\x1b[0m CPF não pode ser vazio.");
            }
            else
            {
                Console.WriteLine("\x1b[1;31mErro:\x1b[0m CPF deve conter 11 caracteres, sendo apenas os números.");
            }
            cpf="";
        }
    }

while (cep=="")
    {
        Console.WriteLine("Digite o cep (somente números):");
        cep = Console.ReadLine() ?? "";
        
        if (cep.Length != 6)
        {   
            if(cep == "")
            {
                Console.WriteLine("\x1b[1;31mErro:\x1b[0m Cep de nascimento não pode ser vazio.");
            }
            else
            {
                Console.WriteLine("\x1b[1;31mErro:\x1b[0m Cep deve conter 9 caracteres, sendo apenas os números.");
            }
            cep="";
        }
    }

 while (endereço=="")
    {
        Console.WriteLine("Digite o endereço:");
        endereço = Console.ReadLine() ?? "";
        if(endereço=="")
        {
            Console.WriteLine("\x1b[1;31mErro:\x1b[0m Endereço não pode ser vazio.");
        }
    }

 while (bairro=="")
    {
        Console.WriteLine("Digite o bairro:");
        bairro = Console.ReadLine() ?? "";
        if(bairro=="")
        {
            Console.WriteLine("\x1b[1;31mErro:\x1b[0m Bairro não pode ser vazio.");
        }
    }

 while (estado=="")
    {
        Console.WriteLine("Digite o endereço:");
        estado = Console.ReadLine() ?? "";
        if(estado=="")
        {
            Console.WriteLine("\x1b[1;31mErro:\x1b[0m Estado não pode ser vazio.");
        }
    }

 while (pais=="")
    {
        Console.WriteLine("Digite o endereço:");
        pais = Console.ReadLine() ?? "";
        if(pais=="")
        {
            Console.WriteLine("\x1b[1;31mErro:\x1b[0m Nome não pode ser vazio.");
        }
    }

    try
    {
        string nomehash = nome;
        string cpfhash = Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        hashtable.Add(cpfhash, nomehash);
        nomehash = "";
        cpfhash = "";
    }
    catch(ArgumentException aex)
    {
        Console.Write("\x1b[1;31mErro:\x1b[0m chave duplicada inserida.");
        Console.WriteLine($" Detalhes: {aex.Message}");
    }

    Console.WriteLine("---------------------------------------------------");
    Console.WriteLine("               Usuários cadastrados                ");
    Console.WriteLine("---------------------------------------------------");
    foreach (DictionaryEntry de in hashtable)
    {
        Console.WriteLine(
            "Nome: {1} | CPF: {0}"
            , de.Key
            , de.Value
        );
        Console.WriteLine("---------------------------------------------------");
    }

    Console.WriteLine("Deseja cadastrar mais um usuário? (S/N)");
    string ? exit = Console.ReadLine() ?? "";
    exit = exit.ToLower();
    switch(exit) 
    {
    case "s":
        sair = false;
        break;

    case "n":
        sair=true;
        break;

    case "":
        sair=true;
        break;
    default:
        sair=true;
        break;
    }
}
