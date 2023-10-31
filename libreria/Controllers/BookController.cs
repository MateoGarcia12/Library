using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libreria.Context;
using libreria.Models;

namespace libreria.Controllers
{
    internal class BookController
    {

        public static bool createBook(Book book)
        {
			try
			{
				var context = new AppDbContext();
				context.Books.Add(book);
				context.SaveChanges();
				return true;
			}
			catch (Exception e)
			{

				throw new Exception ("something went wrong while creating a book: " + e.Message);
			}
        }
    }
}
