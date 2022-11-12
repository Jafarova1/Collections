using Collections.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Homework
            //  DateTime startDate = DateTime.Now.AddDays(2);
            //  DateTime endDate = DateTime.Now.AddDays(25);
            //  double salary = 2000;

            //  IEmployeeService employeeService = new IEmployeeService();
            //int result=  employeeService.GetFilterEmployeeCount(startDate, endDate, salary);
            //  Console.WriteLine(result);

            Celcius celcius = new Celcius(36);
            Kelvin kelvin = celcius;
            Console.WriteLine(kelvin.Degree);
            #endregion
            #region List

            //int[] arr = { 1, 2, 4, 5, 7 };
            //Console.WriteLine(arr[0]);


            //List<int> nums = new List<int>() { 200, 300, 400 };
            //           List<int> numbers = new List<int>();
            //numbers.Add(5);
            //numbers.Add(15);
            //numbers.Add(20);
            //numbers.Add(30);
            //numbers.Add(111);
            //numbers.Add(112);

            //numbers.AddRange(nums);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //var result = numbers.Contains(5);
            //if (result)
            //{
            //    Console.WriteLine("yes");
            //}


            //Console.WriteLine(numbers.Count);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //var result = numbers.Find(m => m > 100);

            //var result2 = numbers.FindAll(m => m > 100);
            //Console.WriteLine(result2);

            //var result4 = numbers.FindIndex(m=>m>100);
            //Console.WriteLine(result4);

            //var result5 = numbers.FindLastIndex(m => m > 100);
            //Console.WriteLine(result5);

            //numbers.Sort();
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //var result = numbers.ToArray();
            //var result2 = result.ToList();

            //var result = numbers.BinarySearch(5);
            //Console.WriteLine(result);

            //List<string> names = new List<string>() { "Resul", "Nicat", "Novreste", "Gultac" };
            //var result = names.FindAll(m => m == "Nicat");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //var searcText = Console.ReadLine();



            //var result = Search(names,searcText);
            ////var result = Search(searcText);

            //if (result.Count == 0)
            //{
            //    Console.WriteLine("Not found");
            //}
            //else
            //{
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    List<Person> people = new List<Person>();
            //    people.Add(new Person { FullName = "Qosqar Nerimanli", Birthday = DateTime.Now.AddDays(10), Salary = 1500 });
            //    people.Add(new Person { FullName = "Resul huseynov", Birthday = DateTime.Now.AddDays(20), Salary = 1600 });
            //    people.Add(new Person { FullName = "Gulatc Ceferova", Birthday = DateTime.Now.AddDays(15), Salary = 6000 });


            //    var result = people.FindAll(m => m.Salary > 1600 && m.FullName.StartsWith("r"));


            //    foreach (var person in result)
            //    {
            //        Console.WriteLine("FullName:[0], Birthday:[1], Salary[2]",person.FullName,person.Birthday,person.Salary);
            //    }

            #endregion

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(1,"Resul");
            //hashtable.Add(2, "Nicat");
            //hashtable.Add(3, "Vuqar");

            //foreach (DictionaryEntry item in hashtable.Values)
            //{
            //    Console.WriteLine(item.Key +" "+item.Value);
            //}

            //SortedList sortedlist = new SortedList();
            //sortedlist.Add(1, "Resul");
            //sortedlist.Add(2, "Nicat");
            //sortedlist.Add(3, "Vuqar");
            //foreach (DictionaryEntry item in sortedlist.Values)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //ArrayList arraylist = new ArrayList();
            //arraylist.Add("salam");
            //arraylist.Add(15);
            //foreach (var item in arraylist)
            //{
            //    Console.WriteLine(item);
            //}




            //SortedList<int, string> list = new SortedList<int, string>();
            //list.Add(1, "Gultac");
            //list.Add(2, "Resul");

            //foreach (KeyValuePair<int,string> item in list)
            //{
            //    if (item.Key == 1)
            //    {
            //        Console.WriteLine(item.Value);
            //    }
            //}

            //Dictionary<string, string> dictionaryList = new Dictionary<string, string>();
            //dictionaryList.Add("Admin", "Ramil");

            //Console.WriteLine(dictionaryList["Admin"]);

            //foreach (KeyValuePair<string,string> item in list)
            //{
            //    if (item.Key == "Admin")
            //    {
            //        Console.WriteLine(item.Value);
            //    }
            //}

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(10);
            queue.Enqueue(3);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }


            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(10);
            stack.Push(3);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }








        }







    }

   

        //private static List<string> Search(List<string> datas,string str)
        //{
            
        //    //var result = datas.FindAll(m => m.Contains(str));
        //    List<string> names = new List<string>() { "Gultac", "Novreste", "Resul" };
        //    var result3 = names.FindAll(m => m.ToLower().Contains(str.ToLower()));
        //    return result;
        //    //var result1 = datas.FindAll(m => m.StartWith(str));
        //    //return result;
        //    var result4 = datas.FindAll(m => m.ToLower().Contains(str.ToLower()));
        //    return result4;

        }
    

   

