namespace HiddenVilla_Server.Model;

public class HotelRoom
{
    public int Id { get; set; }

    public string? RoomName { get; set; }

    public double Price { get; set; }

    public bool IsActive { get; set; }

    public List<HotelRoomProp>? BlazorRoomProps { get; set; }

}