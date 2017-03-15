using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Books
{
    public class Library
    {
        ConsoleIO consoleIO = new ConsoleIO();
        //Book g = new Book();
       static public List<Book> listBooks = new List<Book>();

        public void CreateLibrary()
        {
            listBooks.Add(new Book() { nameAuthor = "Mikhail Bulgakov", nameBook = "Master i Margo", yearOfPublishing = 1891, numberOfPages = 1000 });
            listBooks.Add(new Book() { nameAuthor = "Lev Tolstoi", nameBook = "Mertvye Dushi", yearOfPublishing = 1865, numberOfPages = 835 });
            listBooks.Add(new Book() { nameAuthor = "Nikolai Gogol ", nameBook = "Mertvye Dushi", yearOfPublishing = 1842, numberOfPages = 933 });
            listBooks.Add(new Book() { nameAuthor = "Alexander Pushki ", nameBook = "Evgenyi Onegin", yearOfPublishing = 1825, numberOfPages = 1114 });
            listBooks.Add(new Book() { nameAuthor = "Anton Chekhov ", nameBook = "Palata №6", yearOfPublishing = 1892, numberOfPages = 753 });
            consoleIO.showBooks();
        }
    }
}
