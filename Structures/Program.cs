using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
  
        struct Books
        {
            string title;
           string author;
            string subject;
            int bookId;

            public void getValues(string t, string a, string s, int id)
            {
                title = t;
                author = a;
                subject = s;
                bookId = id;
            }

            public void display()
            {
                Console.WriteLine("Title : {0}", title);
                Console.WriteLine("Author : {0}", author);
                Console.WriteLine("Subject : {0}", subject);
                Console.WriteLine("Book_id :{0}", bookId);
            }
        };

        public class Program
        {

            public static void Main(string[] args)
            {
                Books Book1 = new Books();   /* Declare Book1 of type Book */
                Books Book2 = new Books();   /* Declare Book2 of type Book */

                /* book 1 specification */
                Book1.getValues("C Programming",
                "Nuha Ali", "C Programming Tutorial", 6495407);

                /* book 2 specification */
                Book2.getValues("Telecom Billing",
                "Zara Ali", "Telecom Billing Tutorial", 6495700);

                /* print Book1 info */
                Book1.display();

                /* print Book2 info */
                Book2.display();

                Console.ReadKey();
            }
        }
 }
