using AutoMapper;

namespace Campus.Application.MapperProfiles;
public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<Domain.Models.User, DataContext.Entities.User>().ReverseMap();
    }
}
