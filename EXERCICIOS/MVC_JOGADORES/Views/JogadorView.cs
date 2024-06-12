using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_JOGADORES.Controller;
using MVC_JOGADORES.Controller.Models;

namespace MVC_JOGADORES.Views
{
    public class JogadorView
    {
         private JogadorControllers jogadorControllers;

        public JogadorView()
        {
            jogadorControllers = new JogadorControllers();
            this.Init();
        }

        public void Init()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Top 10 melhores jogadores do mundo em 2024!");
            Console.WriteLine("------------------------");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Jogadores");
            Console.WriteLine("2 - Listar Jogadores");
            Console.WriteLine("3 - Exportar Jogadores");
            Console.WriteLine("4 - Importar Jogadores");
            Console.WriteLine("");

            int option = 0;
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Insert();
                    break;

                case 2:
                    List();
                    break;

                default:
                    break;
            }

        }

        private void List()
        {
            List<Jogador> listagem = jogadorControllers.List();

            for (int i = 0; i < listagem.Count; i++)
            {
                Console.WriteLine(Print(listagem[i]));
            }
        }

        private string Print(Jogador jogador)
        {
            string retorno = "";

            retorno += $"ID: {jogador.Id} \n";
            retorno += $"Nome: {jogador.Nome} \n";
            retorno += $"Nacionalidade: {jogador.Nacionalidade} \n";
            retorno += "------------------------------------------- \n";

            return retorno;
        }

        private void Insert()
        {
            Jogador jogador = new Jogador();
            jogador.Id = jogadorControllers.GetNextId();

            Console.WriteLine("Informe o nome do atleta:");
            jogador.Nome = Console.ReadLine();

            Console.WriteLine("Informe a idade do atleta:");
            jogador.Idade = Console.ReadLine();

            Console.WriteLine("Informe a matrícula do atleta:");
            jogador.Matrícula = Console.ReadLine();

             Console.WriteLine("Informe o CPF do atleta:");
            jogador.Cpf = Console.ReadLine();

            Console.WriteLine("Informe o curso do atleta:");
            jogador.Curso = Console.ReadLine();

             Console.WriteLine("Informe a modalidade do atleta:");
            jogador.Modalidade = Console.ReadLine();


            bool retorno = jogadorControllers.Insert(jogador);
            if (retorno)
                Console.WriteLine("Jogador registrado com sucesso!");
            else
                Console.WriteLine("Falha ao inserir, verifique os dados");

        }
    }
}
    
