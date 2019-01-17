using AutoMapper;
using src.Models;
using src.ViewModels;

namespace src.Mappers
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration()
        : this("MyProfile")
        {
        }
        protected AutoMapperProfileConfiguration(string profileName)
        : base(profileName)
        {
            CreateMap<PessoaViewModel, Pessoa>();
        }
    }
}