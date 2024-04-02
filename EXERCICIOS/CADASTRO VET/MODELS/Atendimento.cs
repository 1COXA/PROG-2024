using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace _240125_01.Models
{
    public class Atendimento
    {
        public int Id { get; set; }

        public DateTime DtNascimento { get; set; }
        public Animal Animal { get; set }
        public Veterinario Veterinario { get; set; }
        public string Observacao { get; set;}
    }
}