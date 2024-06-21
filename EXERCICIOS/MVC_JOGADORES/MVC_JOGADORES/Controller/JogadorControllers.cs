using System.Collections.Generic;
using System.IO;
using System.Linq;
using MVC_JOGADORES.Controller.Models;
using MVC_JOGADORES.Data;

namespace MVC_JOGADORES.Controller
{
    public class JogadorControllers
    {
        private List<Jogador> jogadores = DataSet.Jogador; 

        public List<Jogador> List()
        {
            return jogadores;
        }

        public bool Insert(Jogador jogador)
        {
            if (jogador == null || jogador.Id <= 0 || string.IsNullOrWhiteSpace(jogador.Nome))
                return false;

            jogadores.Add(jogador); 
            return true;
        }

        public int GetNextId()
        {
            int tam = jogadores.Count;
            return tam > 0 ? jogadores[tam - 1].Id + 1 : 1;
        }

        public bool ExportToCsv(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("ID,Nome,Idade,Matrícula,CPF,Curso,Modalidade,Pontuacao");

                    foreach (var jogador in jogadores)
                    {
                        writer.WriteLine($"{jogador.Id},{jogador.Nome},{jogador.Idade},{jogador.Matricula},{jogador.CPF},{jogador.Curso},{jogador.Modalidade},{jogador.Pontuacao}");
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ImportFromCsv(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                   
                    reader.ReadLine();

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');

                        Jogador jogador = new Jogador
                        {
                            Id = int.Parse(values[0]),
                            Nome = values[1],
                            Idade = int.Parse(values[2]),
                            Matricula = int.Parse(values[3]),
                            CPF = values[4],
                            Curso = values[5],
                            Modalidade = values[6],
                            Pontuacao = int.Parse(values[7])
                        };

                        jogadores.Add(jogador);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Jogador> Search(string name)
        {
            return jogadores.Where(j => j.Nome.Contains(name, System.StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public bool Update(Jogador updatedJogador)
        {
            var jogador = jogadores.FirstOrDefault(j => j.Id == updatedJogador.Id);
            if (jogador == null)
                return false;

            jogador.Nome = updatedJogador.Nome;
            jogador.Idade = updatedJogador.Idade;
            jogador.Matricula = updatedJogador.Matricula;
            jogador.CPF = updatedJogador.CPF;
            jogador.Curso = updatedJogador.Curso;
            jogador.Modalidade = updatedJogador.Modalidade;
            jogador.Pontuacao = updatedJogador.Pontuacao;

            return true;
        }

        public bool Delete(int id)
        {
            var jogador = jogadores.FirstOrDefault(j => j.Id == id);
            if (jogador == null)
                return false;

            jogadores.Remove(jogador);
            return true;
        }

        public List<Jogador> Top10Jogadores()
        {
            return jogadores.OrderByDescending(j => j.Pontuacao).Take(10).ToList();
        }
    }
}
