using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace src.Models
{
    [Table("Pessoa")]
    public class Pessoa
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [MaxLength(14)]
        public string CpfCnpj { get; set; }

        [Required]
        public bool isTenant { get; set; }

        [MaxLength(100), Required]
        public string Nome { get; set; }

        [MaxLength(100)]
        public string Sobrenome { get; set; }

        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}", ApplyFormatInEditMode = true), MaxLength(12)]
        public string DataNascimento { get; set; }

        [MaxLength(1)]
        public string Sexo { get; set; }

        public virtual List<Pessoa> Pessoas { get; set; }
        public virtual List<Contato> Contatos { get; set; }
        public virtual List<Endereco> Enderecos { get; set; }
    }
}