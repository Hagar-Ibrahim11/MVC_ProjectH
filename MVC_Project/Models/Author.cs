﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        public string AuthorName { get; set; }

        public string Biography { get; set; }

        public DateTime BirthDate { get; set; }

        public string Country { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
