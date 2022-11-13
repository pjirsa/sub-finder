public class Query 
{
    public Book GetBook() =>
        new Book
        {
            Title = "C# in depth.",
            Author = new Author
            {
                Name = "Jon Skeet"
            }
        };

public class Book
{
    public string Title { get; set; } = default!;

    public Author Author { get; set; } = default!;
}

public class Author
{
    public string Name { get; set; } = default!;
}

}