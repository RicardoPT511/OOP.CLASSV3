using System;

public class Book
{
    private string title;
    private string author;
    private int pages;
    private bool open;

    public Book()
    {
        title = "Libro";
        author = "Ricardo";
        pages = 111;
        open = false;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Título: " + title);
        Console.WriteLine("Autor: " + author);
        Console.WriteLine("Páginas: " + pages);
        Console.WriteLine("Abierto: " + open);
        Console.WriteLine();
    }

    public void Open()
    {
        open = true;
        Console.WriteLine("El libro está abierto");
        Console.WriteLine();
    }

    public void Close()
    {
        open = false;
        Console.WriteLine("El libro está cerrado");
        Console.WriteLine();
    }
}

class Examples
{
    static void Main(string[] args)
    {
        
        Book book = new Book();

        
        book.ShowInfo();

        
        book.Open();

        
        book.Close();
    }
}