using AutoMapper;
using Domain.Entities;
using Presentation.ViewModels;

namespace CRUD.AutoMapper
{
    public class DomainToViewModelMappingProfile
        : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<UserViewModel, User>();
        }
    }
}