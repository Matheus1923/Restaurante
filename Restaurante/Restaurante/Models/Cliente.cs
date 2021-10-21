using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [Column("idcliente")]
        [Required(ErrorMessage = "O campo é obrigatório")]

        public Int32 IdCliente { get; set; }

        [Column("nome")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo não pode ser nulo")]

        public string Nome { get; set; }
    }
}
