using BookStoreAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<BookStoreContext>(options =>
    options.UseInMemoryDatabase("BookStoreDB"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Seed data
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<BookStoreContext>();

    // Add sample authors
    var author1 = new Author { Id = 1, Name = "J.K. Rowling" };
    var author2 = new Author { Id = 2, Name = "George R.R. Martin" };

    context.Authors.AddRange(author1, author2);
    context.SaveChanges();

    context.Books.AddRange(
        new Book
        {
            Id = 1,
            Title = "Harry Potter and the Philosopher's Stone",
            PublicationYear = 1997,
            AuthorId = 1
        },
        new Book
        {
            Id = 2,
            Title = "Harry Potter and the Chamber of Secrets",
            PublicationYear= 1998,
            AuthorId = 1
        },
        new Book
        {
            Id = 3,
            Title = "A Game of Thrones",
            PublicationYear = 1996,
            AuthorId = 2
        }
    );

    context.SaveChanges();
}

app.Run();
