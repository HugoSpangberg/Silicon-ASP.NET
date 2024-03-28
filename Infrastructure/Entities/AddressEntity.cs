namespace Infrastructure.Entities;

public class AddressEntity
{
    public int Id { get; set; }
    public string AddressLine_1 { get; set; } = null!;
    public string? AddressLine_2 { get; set; }
    public string City { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string? UserId { get; set; } 
    public UserEntity? User { get; set; }
}
