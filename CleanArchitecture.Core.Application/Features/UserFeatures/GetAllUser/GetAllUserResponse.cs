namespace CleanArchitecture.Core.Application.Features.UserFeatures.GetAllUser;

public sealed record GetAllUserResponse
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
}
