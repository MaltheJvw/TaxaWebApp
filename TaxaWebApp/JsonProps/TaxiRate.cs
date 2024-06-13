namespace TaxaWebApp
{
    public class TaxiRate
    {
        public int PassengerCapacity { get; set; }
        public string? VehicleType { get; set; }
        public string? Time { get; set; }
        public Dictionary<string, string>? Drive { get; set; }
        public Dictionary<string, string>? Addition { get; set; }
    }
}
