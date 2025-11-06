using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.UseCases.GetUserById;

public sealed class GetUserByIdMapper : Profile
{
    public GetUserByIdMapper()
    {
        CreateMap<User, GetUserByIdResponse>();
    }
}
