﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDwithWebAPI
{
    public class BookShop
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Authour { get; set; }
        public long ToatalNoPages { get; set; }
        public string PublishedBy { get; set; }
        public long ContactNo { get; set; }

    }
}
