// 房屋類別
public class House : ICloneable
{
    public string Address { get; set; }
    public int NumberOfRooms { get; set; }

    public House(string address, int numberOfRooms)
    {
        Address = address;
        NumberOfRooms = numberOfRooms;
    }

    public ICloneable Clone()
    {
        // 使用淺層複製
        return (ICloneable)MemberwiseClone();
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Address: {Address}, Rooms: {NumberOfRooms}");
    }
}
