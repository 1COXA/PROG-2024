using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240125_01.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Raca { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Nome { get; set; }
        public string NomeTutor { get; set; }
        public string FoneTutor { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }

        public bool Validar()
        {
            var isValid = true;
            if( string.IsNullOrWhiteSpace(Nome) )
            isValid = false;

            if( string.IsNullOrWhiteSpace(NomeTutor) )
            isValid = false; 
        }
    }
}
   
