using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using src.Models;

namespace src.ViewModels
{
    public class PessoaViewModel
    {
        public int Id { get; set; }
        public string CpfCnpj { get; set; }
        public bool isTenant { get; set; }

        [MaxLength(100), Required]
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public string DataNascimento { get; set; }
        public string Sexo { get; set; }
        public virtual List<Pessoa> Pessoas { get; set; }
        public virtual List<Contato> Contatos { get; set; }
        public virtual List<Endereco> Enderecos { get; set; }        
    }
}