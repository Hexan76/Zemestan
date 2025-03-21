using System;
using Zemestan.Domain.Books;
using Zemestan.EntityFrameworkCore;

public class BookRepository : EfCoreRepository<ZemestanDbContext, Book, Guid>, IBookRepository
{
    public BookRepository(IDbContextProvider<ZemestanDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}