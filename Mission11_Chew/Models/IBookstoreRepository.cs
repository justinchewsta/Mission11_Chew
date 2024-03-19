namespace Mission11_Chew.Models
{
    public interface IBookstoreRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
