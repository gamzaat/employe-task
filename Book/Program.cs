// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



Book[] Books = new Book[10];

for(int i = 0; i < Books.Length; i++) 
{
    Console.WriteLine("Kitab adi  : ");
    string name=Console.ReadLine();
    Console.WriteLine("Kitab sehifesi  : ");
    int page=int.Parse(Console.ReadLine());

    Book book = new Book(name, page);
    Books[i] = book;

}
 
bool CheckName(string name)
{
    if (string.IsNullOrWhiteSpace(name) && name.Length > 2)
    {
        return true;

        return false;
    }
}


foreach(Book book in Books)
{
    Console.WriteLine($"Name  : {book.Name} pageCount:{book.PageCount}");