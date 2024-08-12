using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS3ADVANCED
{

    public delegate string BookFunctionDelegate(Book B);
    public class BookFunction
    {
        public static string GetTitle (Book B)
        {

        return B.ISBN.ToString ();
        }
        public static string GetAuthors(Book B)
        {

            return B.Authors.ToString();
        }
        public static string GetPrice(Book B)
        {

            return B.Price.ToString();
        }
    }

    
}
