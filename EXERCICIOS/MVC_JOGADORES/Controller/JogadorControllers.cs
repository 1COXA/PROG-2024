using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_JOGADORES.Controller.Models;

namespace MVC_JOGADORES.Controller
{
    public class JogadorControllers
    {
        private List<Jogador> jogadores = new List<Jogador>(); // Lista de jogadores

        public List<Jogador> List()
        {
            return jogadores;
        }

        public bool Insert(Jogador jogador)
        {
            if (jogador == null)
                return false;

            if (jogador.Id <= 0)
                return false;

            if (string.IsNullOrWhiteSpace(jogador.Nome))
                return false;

            jogadores.Add(jogador); // Adiciona o jogador à lista
            return true;
        }

        public int GetNextId()
        {
            int tam = jogadores.Count;

            if (tam > 0)
                return jogadores[tam - 1].Id + 1;
            else
                return 1;
        }
    }
}