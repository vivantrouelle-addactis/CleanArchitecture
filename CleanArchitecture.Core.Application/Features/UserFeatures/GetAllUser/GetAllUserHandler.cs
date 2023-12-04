using AutoMapper;
using CleanArchitecture.Core.Application.Repositories;
using MediatR;

namespace CleanArchitecture.Core.Application.Features.UserFeatures.GetAllUser;

public sealed class GetAllUserHandler : IRequestHandler<GetAllUserRequest, List<GetAllUserResponse>>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public GetAllUserHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllUserResponse>> Handle(GetAllUserRequest request, CancellationToken cancellationToken)
    {
        List<Domain.Entities.User> users = await _userRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllUserResponse>>(users);
    }
}
