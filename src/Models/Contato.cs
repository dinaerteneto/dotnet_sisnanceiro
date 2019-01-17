using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace src.Models
{

    [Table("Contato")]
    public class Contato
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Descricao { get; set; }
        
        [MaxLength(255)]
        public string Observacao { get; set; }
        public virtual List<ContatoTipo> Tipos { get; set; }
    }
}