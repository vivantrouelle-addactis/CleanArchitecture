namespace CleanArchitecture.Core.Application.Features.UserFeatures.CreateUser;

public sealed record CreateUserResponse
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
}
