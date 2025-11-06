namespace CleanArchitecture.Application.UseCases.GetUserById;

public sealed record GetUserByIdResponse
{
    public Guid Id { get; set; }
    public string? Email { get; set; }
    public string? Name { get; set; }
}
