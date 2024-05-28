using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesImobiliaria.Models
{
    public class Imovel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public double Valor { get; set; }
        public int Comodos { get; set; }
        public int Id_Categoria { get; set; }
        public int Id_Localidade { get; set; }
        public int Id_Negocio { get; set; }
    }
}