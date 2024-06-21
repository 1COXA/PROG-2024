using System;
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
            Console.WriteLine("5 - Pesquisar Jogadores");
            Console.WriteLine("6 - Atualizar Jogador");
            Console.WriteLine("7 - Excluir Jogador");
            Console.WriteLine("8 - Top 10 Jogadores");
            Console.WriteLine("");

            int option = 0;
            try
            {
                option = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Opção inválida. Por favor, insira um número.");
                this.Init();
            }

            switch (option)
            {
                case 1:
                    Insert();
                    break;
                case 2:
                    List();
                    break;
                case 3:
                    Export();
                    break;
                case 4:
                    Import();
                    break;
                case 5:
                    Search();
                    break;
                case 6:
                    Update();
                    break;
                case 7:
                    Delete();
                    break;
                case 8:
                    Top10();
                    break;
                default:
                    break;
            }
        }

        private void List()
        {
            List<Jogador> listagem = jogadorControllers.List();

            foreach (var jogador in listagem)
            {
                Console.WriteLine(Print(jogador));
            }
        }

        private string Print(Jogador jogador)
        {
            string retorno = "";

            retorno += $"ID: {jogador.Id} \n";
            retorno += $"Nome: {jogador.Nome} \n";
            retorno += $"Idade: {jogador.Idade} \n";
            retorno += $"Matrícula: {jogador.Matricula} \n";
            retorno += $"CPF: {jogador.CPF} \n";
            retorno += $"Curso: {jogador.Curso} \n";
            retorno += $"Modalidade: {jogador.Modalidade} \n";
            retorno += $"Pontuação: {jogador.Pontuacao} \n";
            retorno += "------------------------------------------- \n";

            return retorno;
        }

        private void Insert()
        {
            Jogador jogador = new Jogador();
            jogador.Id = jogadorControllers.GetNextId();

            Console.WriteLine("Informe o nome do atleta:");
            jogador.Nome = Console.ReadLine();

            try
            {
                Console.WriteLine("Informe a idade do atleta:");
                jogador.Idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe a matrícula do atleta:");
                jogador.Matricula = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o CPF do atleta:");
                jogador.CPF = Console.ReadLine();

                Console.WriteLine("Informe o curso do atleta:");
                jogador.Curso = Console.ReadLine();

                Console.WriteLine("Informe a modalidade do atleta:");
                jogador.Modalidade = Console.ReadLine();

                Console.WriteLine("Informe a pontuação do atleta:");
                jogador.Pontuacao = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Dados inválidos. Tente novamente.");
                Insert();
                return;
            }

            bool retorno = jogadorControllers.Insert(jogador);
            if (retorno)
                Console.WriteLine("Jogador registrado com sucesso!");
            else
                Console.WriteLine("Falha ao inserir, verifique os dados");
        }

        private void Export()
        {
            Console.WriteLine("Informe o caminho do arquivo para exportação (exemplo: C:\\jogadores.csv):");
            string filePath = Console.ReadLine();

            bool result = jogadorControllers.ExportToCsv(filePath);

            if (result)
                Console.WriteLine("Jogadores exportados com sucesso!");
            else
                Console.WriteLine("Falha na exportação dos jogadores.");
        }

        private void Import()
        {
            Console.WriteLine("Informe o caminho do arquivo para importação (exemplo: C:\\jogadores.csv):");
            string filePath = Console.ReadLine();

            bool result = jogadorControllers.ImportFromCsv(filePath);

            if (result)
                Console.WriteLine("Jogadores importados com sucesso!");
            else
                Console.WriteLine("Falha na importação dos jogadores.");
        }

        private void Search()
        {
            Console.WriteLine("Informe o nome do jogador para busca:");
            string name = Console.ReadLine();

            List<Jogador> searchResults = jogadorControllers.Search(name);

            if (searchResults.Count == 0)
            {
                Console.WriteLine("Nenhum jogador encontrado com esse nome.");
            }
            else
            {
                foreach (var jogador in searchResults)
                {
                    Console.WriteLine(Print(jogador));
                }
            }
        }

        private void Update()
        {
            Console.WriteLine("Informe o ID do jogador que deseja atualizar:");
            int id = int.Parse(Console.ReadLine());

            Jogador jogador = new Jogador { Id = id };

            Console.WriteLine("Informe o novo nome do atleta (deixe em branco para manter o valor atual):");
            string nome = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(nome)) jogador.Nome = nome;

            try
            {
                Console.WriteLine("Informe a nova idade do atleta (deixe em branco para manter o valor atual):");
                string idadeInput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(idadeInput)) jogador.Idade = int.Parse(idadeInput);

                Console.WriteLine("Informe a nova matrícula do atleta (deixe em branco para manter o valor atual):");
                string matricula = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(matricula)) jogador.Matricula = int.Parse(matricula);

                Console.WriteLine("Informe o novo CPF do atleta (deixe em branco para manter o valor atual):");
                string cpf = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(cpf)) jogador.CPF = cpf;

                Console.WriteLine("Informe o novo curso do atleta (deixe em branco para manter o valor atual):");
                string curso = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(curso)) jogador.Curso = curso;

                Console.WriteLine("Informe a nova modalidade do atleta (deixe em branco para manter o valor atual):");
                string modalidade = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(modalidade)) jogador.Modalidade = modalidade;

                Console.WriteLine("Informe a nova pontuação do atleta (deixe em branco para manter o valor atual):");
                string pontuacaoInput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(pontuacaoInput)) jogador.Pontuacao = int.Parse(pontuacaoInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Dados inválidos. Tente novamente.");
                Update();
                return;
            }

            bool retorno = jogadorControllers.Update(jogador);
            if (retorno)
                Console.WriteLine("Jogador atualizado com sucesso!");
            else
                Console.WriteLine("Falha ao atualizar, verifique os dados");
        }

        private void Delete()
        {
            Console.WriteLine("Informe o ID do jogador que deseja excluir:");
            int id = int.Parse(Console.ReadLine());

            bool result = jogadorControllers.Delete(id);

            if (result)
                Console.WriteLine("Jogador excluído com sucesso!");
            else
                Console.WriteLine("Falha ao excluir jogador.");
        }

        private void Top10()
        {
            List<Jogador> top10 = jogadorControllers.Top10Jogadores();

            Console.WriteLine("Top 10 melhores jogadores da história:");
            foreach (var jogador in top10)
            {
                Console.WriteLine(Print(jogador));
            }
        }
    }
}
