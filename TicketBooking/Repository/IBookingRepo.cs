using TicketBooking.Entity;

namespace TicketBooking.Repository
{
    public interface IBookingRepo
    {
        public Task<int> Add<T>(T entity) where T : class;
        public Task<int> Update<T>(T entity) where T : class;
        public Task<int> Delete<T>(T entity) where T : class;
        public Task<T> GetById<T>(string id) where T : class;
        public Task<IList<T>> GetAll<T>() where T : class;
        public Task<int> RemoveRange<T>(IList<T> entity) where T : class;

    }
}
