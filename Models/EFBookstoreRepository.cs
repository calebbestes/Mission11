// EFBookstoreRepository.cs
namespace WebApplication1.Models
{
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private readonly BookstoreContext _context;

        public EFBookstoreRepository(BookstoreContext context)
        {
            _context = context;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}