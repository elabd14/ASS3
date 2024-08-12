﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS3ADVANCED
{
   
    public class LibarayEngine
    {

  
        public static void ProcessBooks(List<Book> blist, BookFunctionDelegate func)
        {
            if (func is not null && blist is not null)
                foreach (Book book in blist)
                {
                    Console.WriteLine(func(book));
                }
        }


        public static void ProcessBooks2(List<Book> blist, Func<Book, string> func)
        {
            if (func is not null && blist is not null)
                foreach (Book book in blist)
                {
                    Console.WriteLine(func(book));
                }
        }
    }
}