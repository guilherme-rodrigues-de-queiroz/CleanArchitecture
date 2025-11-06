using AutoMapper;
using CleanArchitecture.Domain.Interfaces;
using MediatR;

namespace CleanArchitecture.Application.UseCases.GetUserById;

public sealed class GetUserByIdHandler : 
                    IRequestHandler<GetUserByIdRequest, GetUserByIdResponse>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public GetUserByIdHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<GetUserByIdResponse> Handle(GetUserByIdRequest request,
                                                CancellationToken cancellationToken)
    {
        var user = await _userRepository.Get(request.Id, cancellationToken);
        return _mapper.Map<GetUserByIdResponse>(user);
    }
}
