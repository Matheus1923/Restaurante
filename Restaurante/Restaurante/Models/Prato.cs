using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    [Table("Prato")]
    public class Prato
    {
        [Key]
        [Column("idprato")]
        [Required(ErrorMessage = "O campo é obrigatório")]

        public int IdPrato { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "O campo deve conter entre 5 á 50 caracteres")]
        [Column("nome")]

        public string Nome { get; set; }
        
    }
}
