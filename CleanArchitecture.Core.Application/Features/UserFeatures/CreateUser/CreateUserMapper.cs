﻿using AutoMapper;
using CleanArchitecture.Core.Domain.Entities;

namespace CleanArchitecture.Core.Application.Features.UserFeatures.CreateUser;

public sealed class CreateUserMapper : Profile
{
    public CreateUserMapper()
    {
        CreateMap<CreateUserRequest, User>();
        CreateMap<User, CreateUserResponse>();
    }
}
