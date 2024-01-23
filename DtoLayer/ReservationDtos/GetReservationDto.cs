namespace DtoLayer.ReservationDtos;

public class GetReservationDto
{
    public int Id { get; set; }
    public int RoomId { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public int Adult { get; set; }
    public int Child { get; set; }
    public int Infant { get; set; }
    public int TotalGuest { get; set; }
    public int TotalPrice { get; set; }
    public string PaymentStatus { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Status { get; set; }
}