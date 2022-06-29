namespace Prestamos.Users.Application.Contracts
{
    public record GetAllUsersResponse
    {
        public IEnumerable<UserUpdated> Users { get; set; } = null!;
    }
}