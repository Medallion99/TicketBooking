namespace TicketBooking.Entity
{
    public class Booking
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string TripId { get; set; } = string.Empty;
        public string VehicleNo { get; set; } = string.Empty;
        public string Cust_Name { get; set; } = string.Empty;
        public string Cust_Phone { get; set; } = string.Empty;
        public string Cust_Sex { get; set; } = string.Empty;
        public string TicketNumber { get; set; } = string.Empty;
        public double Amount { get; set; }
        public string SeatNumber { get; set; } = string.Empty;
        public string VehicleRoute { get; set; } = string.Empty;
        public string DriverSlNo { get; set; } = string.Empty;
        public string EnteredBy { get; set; } = string.Empty;
    }
}
