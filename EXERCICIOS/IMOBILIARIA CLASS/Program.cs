﻿using ClassesImobiliaria.Models;

Categoria categoria1 = new(1, "Casa");
Categoria categoria2 = new(2, "Apartamento");
Categoria categoria3 = new(3, "Sítio");

Localidade localidade1 = new(1, "Urbana");
Localidade localidade2 = new(2, "Rural");

Negocio negocio1 = new(1, "Locação");
Negocio negocio2 = new(2, "Venda");

Imagem imagem1 = new(1, 1, "C:\\Users\\Samuel\\Pictures\\FotoCasa.jpg");
Imagem imagem2 = new(2, 1, "C:\\Users\\Samuel\\Pictures\\FotoCasa2.jpg");
Imagem imagem3 = new(3, 2, "C:\\Users\\Samuel\\Pictures\\FotoCasaSitio.jpg");

Imovel casa_centro = new()
{
    Id = 1,
    Nome = "Casa no centro",
    Comodos = 2,
    Descricao = "Linda casa no centro da cidade",
    Valor = 223123.23,
    Id_Categoria = 1,
    Id_Localidade = 1,
    Id_Negocio = 2
};
Imovel casa_sitio = new()
{
    Id = 2,
    Nome = "Casa no sitio",
    Comodos = 5,
    Descricao = "Linda casa na área rural",
    Valor = 2300.87,
    Id_Categoria = 3,
    Id_Localidade = 2,
    Id_Negocio = 1
};

Console.WriteLine("");
Console.WriteLine("Casas disponíveis na imobiliária:");
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine($"{casa_centro.Nome}, {casa_centro.Descricao}, com {casa_centro.Comodos} cômodos, para venda no valor de {casa_centro.Valor}, localizada na área {localidade1.Tipo_localidade}");
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine($"{casa_sitio.Nome}, {casa_sitio.Descricao}, com {casa_sitio.Comodos} cômodos, para no valor de {casa_sitio.Valor} mensais, localizada na área {localidade2.Tipo_localidade}");
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("");