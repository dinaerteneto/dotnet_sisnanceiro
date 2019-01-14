using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace src.Models
{
    public class Pessoa
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(100), Required]
        public string Name { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }

        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}", ApplyFormatInEditMode = true), MaxLength(12)]
        public DateTime BirthDate { get; set; }

        [MaxLength(1)]
        public string Gender { get; set; }

        public virtual List<Endereco> Enderecos { get; set; }
    }
}