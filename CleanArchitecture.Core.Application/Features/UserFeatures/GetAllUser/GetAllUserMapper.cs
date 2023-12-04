using AutoMapper;
using CleanArchitecture.Core.Domain.Entities;

namespace CleanArchitecture.Core.Application.Features.UserFeatures.GetAllUser;

public class GetAllUserMapper : Profile
{
    public GetAllUserMapper()
    {
        CreateMap<User, GetAllUserResponse>();
    }
}
