using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace LojaCet49.Dados.Entidades
{
    public class Clientes
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Apelido")]
        public string LastName { get; set; }

        [Display(Name = "Morada")]
        public string Address { get; set; }

        [Display(Name = "Ultima Compra")]
        public DateTime UltimaCompra { get; set; }
    }
}
