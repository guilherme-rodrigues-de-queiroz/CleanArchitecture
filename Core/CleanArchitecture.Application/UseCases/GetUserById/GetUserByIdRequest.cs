using MediatR;

namespace CleanArchitecture.Application.UseCases.GetUserById;

public sealed record GetUserByIdRequest(Guid Id) :
                    IRequest<GetUserByIdResponse>;

