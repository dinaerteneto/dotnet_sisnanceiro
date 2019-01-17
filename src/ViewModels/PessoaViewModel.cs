using System.Collections.Generic;
using src.Models;

namespace src.ViewModels
{
    public class PessoaViewModel
    {
        public Pessoa Pessoa { get; set; }
        public Endereco Endereco { get; set; }
        public Contato Contato { get; set; }
    }
}