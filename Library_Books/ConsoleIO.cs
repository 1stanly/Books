using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Books
{
     public class ConsoleIO
    {
         public void showBooks()
        {
            foreach (Book n in Library.listBooks)
            {
                Console.WriteLine(n.nameAuthor + " " + n.nameBook + " " + n.yearOfPublishing + " " + n.numberOfPages);
            }
        }
         public void ReadLine()
        {
            Console.ReadLine();
        }
    }
}
