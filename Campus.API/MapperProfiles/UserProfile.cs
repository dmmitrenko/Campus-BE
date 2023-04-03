using AutoMapper;
using Campus.API.Models.Requests.Accounts;
using Campus.Domain.Models;

namespace Campus.API.MapperProfiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<RegistrationRequest, User>();
    }
}
