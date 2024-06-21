namespace MVC_JOGADORES.Controller.Models
{
    public class Jogador
    {
        public int Id { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
        public string? Nome { get; set; }
        public int Matricula { get; set; }
        public string? Curso { get; set; }
        public string? Modalidade { get; set; }
        public int Pontuacao { get; set; }

        public Jogador()
        {
        }

        public Jogador(
            int id,
            int idade,
            string nome,
            string curso,
            string cpf,
            int matricula,
            string modalidade,
            int pontuacao
        )
        {
            Id = id;
            Idade = idade;
            Nome = nome;
            Curso = curso;
            CPF = cpf;
            Matricula = matricula;
            Modalidade = modalidade;
            Pontuacao = pontuacao;
        }
    }
}
