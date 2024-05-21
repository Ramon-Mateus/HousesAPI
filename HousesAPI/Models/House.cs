namespace HousesAPI.Models
{
    public class House
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Photo { get; set; } = string.Empty;
        public int AvaibleUnits { get; set; }
        public Boolean Wifi {  get; set; }
        public Boolean Laundry { get; set; }
    }
}
