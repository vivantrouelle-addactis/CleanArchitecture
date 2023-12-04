using MediatR;

namespace CleanArchitecture.Core.Application.Features.UserFeatures.CreateUser;

public sealed record CreateUserRequest(string Email, string firstName, string lastName) : IRequest<CreateUserResponse>;
