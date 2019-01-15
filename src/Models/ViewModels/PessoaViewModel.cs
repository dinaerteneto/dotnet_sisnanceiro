using System.Collections.Generic;

namespace src.Models.ViewModels
{
    public class PessoaViewModel
    {
        public IEnumerable<Pessoa> Pessoa { get; set; }
        public IEnumerable<Endereco> Endereco { get; set; }
    }
}