using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace src.Models
{
    public class Endereco
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(8)]
        public string Cep { get; set; }

        [MaxLength(60)]
        public string Numero { get; set; }

        [MaxLength(100)]
        public string Complemento { get; set; }

        [MaxLength(255)]
        public string Logradouro { get; set; }

        [MaxLength(255)]
        public string Bairro { get; set; }

        [MaxLength(255)]
        public string Cidade { get; set; }

        [MaxLength(2)]
        public string Uf { get; set; }
    }
}