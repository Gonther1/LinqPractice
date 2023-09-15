﻿internal class Program
{
    private static void Main(string[] args)
    {
        // bool bolean;
        LinqQueries queries = new LinqQueries();
        // ImprimirValores(queries.AllCollection()); Toda la libreria
        // ImprimirValores(queries.Libros200Pages()); Libros con más de 200 páginas
        // bolean=queries.CampoStatus();
        // if (bolean==true)
        // {
        //     Console.WriteLine("Todos los libros contienen un status");
        // }
        // else 
        // {
        //     Console.WriteLine("Al menos algun libro no tiene status");
        // }

        // ImprimirValores(queries.Publish2005()); Imprimir Libros publicados en 2005
        // ImprimirValores(queries.CategoriePython()); Imprimir Libros con la categoria Python
        ImprimirValores(queries.CategorieJavaOrdened());
    }
    private static void ImprimirValores(IEnumerable<Book> books)
    {
        int registros=0;
        Console.Clear();
        Console.ForegroundColor =  ConsoleColor.Yellow;
        Console.WriteLine("{0,-70} {1,7} {2,20}", "Titulo", "N. Paginas", "Fecha publicacion");
        foreach(Book book in books)
        {
            Console.ForegroundColor =  ConsoleColor.Blue;
            registros+=1;
            Console.WriteLine("{0,-70} {1,7} {2,20}", book.Title, book.PageCount, book.PublishedDate.ToShortDateString());
        }
    }
}