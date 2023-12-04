using CleanArchitecture.Core.Domain.Common;

namespace CleanArchitecture.Core.Domain.Entities;

public sealed class User : BaseEntity
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string Email { get; set; }
}

