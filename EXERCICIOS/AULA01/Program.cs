using System;

//Trabalhando com variaveis c#

//Declarando variavel sem inicialização
string ? message1 = null;
//Inicializar a variável com nulo
string ? message2 = null;
//Inicializar a string vazia
string message3 = System.String.Empty; // "";
//Declarar uma string com valor implicito
var message4 = "Uma mensagemaleatória";

Console.WriteLine(message4);

// Concatenando Strings
string concat = (message1 == null ? " " : message1) + 
                 " " + message2 + " " +
                message3 + " " + message4;
Console.WriteLine( "\n" + concat ); 

Console.WriteLine( "A Temperatura hoje {0:D} é {1}°C"
, DateTime.Now
, 23
);

string  ? nome = string.Empty;
Console.WriteLine("Qual é o seu nome?");
nome = Console.ReadLine();
string resultado = $"Oi, {nome}! Pare de jaguarice!";
Console.WriteLine(resultado);

// Comentário de marcação 240304

// Substituindo conteúdo de strings
string nomeCompleto = "Leonardo M Zonta";
nomeCompleto =
    nomeCompleto.Replace("M", "Zonta");
Console.WriteLine(nomeCompleto);

// Comparação de strings
bool isNomeEqual = (nomeCompleto == "mc zontinha");

bool isNomeEqual2 =
      string.Equals(nomeCompleto, "Leonardo M Zonta");

    Console.WriteLine($"Primeiro resultado: {isNomeEqual}");
    Console.WriteLine($"Segundo resultado: {isNomeEqual2}");

// TIPOS NUMÉRICOS
/*
    sbyte: Armazena valores entre - 128 e 127
    short: Armazena entre -32, 768 e 32, 767
    int: Armazena valores entre -2, 147,483, 648 e
                                -2, 147, 483, 647
    long:  Armazena valores entre
           -9,223,372,036,854,775,808 e
           -9,223,372,036,854,775,807
*/

float myFloat = 10.0f;
double myDouble = 5d;
decimal myDecimal = 7m;
int myInteger = 0;