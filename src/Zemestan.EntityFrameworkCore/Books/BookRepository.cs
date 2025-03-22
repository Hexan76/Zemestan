using System;
using Zemestan.Books;
using Zemestan.EntityFrameworkCore;

public class BookRepository : EfCoreRepository<ZemestanDbContext, Book, Guid>, IBookRepository
{
    public BookRepository(IDbContextProvider<ZemestanDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}