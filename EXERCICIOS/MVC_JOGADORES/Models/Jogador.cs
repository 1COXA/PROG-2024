using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_JOGADORES.Controller.Models
{
    public class Jogador
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Nacionalidade { get; set; }

        public string? Time { get; set; }

    public Jogador(){
        
    }

    public Jogador(
        int id,
         string nome,
         string nacionalidade,
         string time
         )
    {
      Id = id;
      Nome = nome;
      Nacionalidade = nacionalidade;
      Time = time;
    }
  }
}