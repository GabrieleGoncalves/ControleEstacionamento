using AutoMapper;
using ControleEstacionamento.Web.AutoMapper;


namespace ControleEstacionamento.Web.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(config =>
            {
                config.AddProfile(new ViewModelToDomainProfile());
                config.AddProfile(new DomainToViewModelProfile());

            });
        }
    }
}