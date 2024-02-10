using TicketBooking.Data;
using TicketBooking.Entity;
using TicketBooking.Repository;
using TicketBooking.Response;

namespace TicketBooking.Services
{
    public class BookingService
    {
        private readonly IBookingRepo _bookingRepo;

        public BookingService(IBookingRepo bookingRepo)
        {
            _bookingRepo = bookingRepo;
        }

        public async Task<TicketResponse> Booking(string tripID, string vehicleNo, string cust_Name, string Cust_PhoneNo, string Cust_Sex,
            string ticketNumber, double amount, string seatNo, string Vehicleroute, string driverSlno, string enteredBy)
        {
            var check = (await _bookingRepo.GetAll<Booking>()).Where(t => t.TripId == tripID);

            if(!check.Any() )
            {
                var initiateTrip = new Booking
                {
                    TripId = tripID,
                    VehicleNo = vehicleNo,
                    Cust_Name = cust_Name,
                    Cust_Phone = Cust_PhoneNo,
                    Cust_Sex = Cust_Sex,
                    TicketNumber = ticketNumber,
                    Amount = amount,
                    SeatNumber = seatNo,
                    VehicleRoute = Vehicleroute,
                    DriverSlNo = driverSlno,
                    EnteredBy = enteredBy
                };

                var initiate = await _bookingRepo.Add<Booking>(initiateTrip);

                if(initiate == 0)
                {
                    var response = new TicketResponse
                    {
                        TicketNumber = ticketNumber,
                        TripId = tripID,
                        VehicleNo = vehicleNo,
                        Cust_Name = cust_Name,
                        Cust_Phone = Cust_PhoneNo,
                        Cust_Sex = Cust_Sex,
                        Amount = amount,
                        SeatNumber = seatNo,
                        VehicleRoute = Vehicleroute,
                        DriverSlNo = driverSlno,
                        EnteredBy = enteredBy,
                    };
                    return response;
                }
                return new TicketResponse { TripId = tripID };
            }
            return new TicketResponse { ResponseState = "Ticket has already been issued" };
        }
    }
}
