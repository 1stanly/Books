using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Books
{
    class Program
    {
        static void Main()
        {
            Library start = new Library();
            start.CreateLibraryBooks();
            start.CreateLibraryJournals();

            ConsoleIO consoleIO = new ConsoleIO();
            consoleIO.ReadLine();
        }
    }
}
