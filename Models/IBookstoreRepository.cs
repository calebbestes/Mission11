namespace WebApplication1.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}