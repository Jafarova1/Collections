using System;
using System.Collections.Generic;

namespace Task_Collections_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Author> authorList = new List<Author>();
            authorList.Add(new Author("Gultaj", "Ceferova", 48));
            authorList.Add(new Author("Resul", "Huseynov", 41));
            authorList.Add(new Author("Fidan", "Alizade", 22));
            authorList.Add(new Author("Nermin", "Aliyeva", 39));


            CheckAuthor(authorList);
                                             
        }
        public static void CheckAuthor(List<Author> authorList)
        {
            var result = authorList.FindAll(m => m.Age > 40);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name}  {item.Surname}");

            }

        }
     
       
       
    }
}
