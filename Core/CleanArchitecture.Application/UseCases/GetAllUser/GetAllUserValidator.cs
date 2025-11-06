using FluentValidation;

namespace CleanArchitecture.Application.UseCases.GetAllUser;

public class GetAllUserValidator : AbstractValidator<GetAllUserValidator>
{
    public GetAllUserValidator()
    {
        // sem validação
    }
}
