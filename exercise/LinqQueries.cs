using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class LinqQueries
{
    List<Book> lstBook = new List<Book>();

    public LinqQueries()
    {
        using (StreamReader reader = new StreamReader("books.json")){
            string json= reader.ReadToEnd();
            this.lstBook=System.Text.Json.JsonSerializer
            .Deserialize<List<Book>>(json,new System.Text.Json.JsonSerializerOptions()
            {PropertyNameCaseInsensitive = true }) ?? new List<Book>();
        }
    }
    public IEnumerable<Book> AllCollection()
    {
        return lstBook;
    }
    public IEnumerable<Book> LibrosDespues2000()
    {
        // return lstBook.Where(book => book.PublishedDate.Year > 2000);
        return from book in lstBook where book.PublishedDate.Year > 200 select book;
    }
    public IEnumerable<Book> Libros200Pages()
    {
        return from book in lstBook where book.PageCount > 250 && book.Title.Contains("in Action") select book;
    }
    public bool CampoStatus()
    {
        // return from book in lstBook.All(book => book.Status != String.Empty);
        return lstBook.All(book => book.Status != String.Empty);
    }
    public IEnumerable<Book> Publish2005()
    {
        if (lstBook.Any(book => book.PublishedDate.Year == 2005))
        {
            return from book in lstBook where book.PublishedDate.Year == 2005 select book;
        }
        else 
        {
            return default;
        }
    }
    public IEnumerable<Book> CategoriePython()
    {
        return from book in lstBook where book.Categories.Contains("Python") select book;
    }
    public IEnumerable<Book> CategorieJavaOrdened()
    {
        return from book in lstBook where book.Categories.Contains("Java") orderby book.Title select book;
    }
    public IEnumerable<Book> More450Pages()
    {
        return from book in lstBook where book.PageCount > 450  select book;
    }
}
