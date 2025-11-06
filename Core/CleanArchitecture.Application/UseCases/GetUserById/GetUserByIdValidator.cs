using FluentValidation;

namespace CleanArchitecture.Application.UseCases.GetUserById;

internal class GetUserByIdValidator : AbstractValidator<GetUserByIdRequest>
{
    public GetUserByIdValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}
