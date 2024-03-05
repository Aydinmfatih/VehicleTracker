namespace VehicleTracker.Dal.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string PlateNumber { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }

    }
}
