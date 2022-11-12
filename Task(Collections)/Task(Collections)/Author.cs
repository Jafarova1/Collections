using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Collections_
{
   public class Author
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Author(string AuthorName,string AuthorSurname,int AuthorAge)
        {
            Name = AuthorName;
            Surname = AuthorSurname;
            Age = AuthorAge;
        }

    }
}
