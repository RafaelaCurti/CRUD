using AutoMapper;
using Domain.Entities;
using Presentation.ViewModels;

namespace CRUD.AutoMapper
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<User, UserViewModel>();
        }
    }
}
