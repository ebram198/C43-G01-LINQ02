
using Linq02;
using System.Collections;
using System.Collections.Generic;
using System.Net.WebSockets;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;

namespace Assigment_LINQ02

{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Element Operators
            #region 1. Get first Product out of Stock 
            //var result = ListGenerator.ProductList.FirstOrDefault(x=>x.UnitsInStock==0);
            //Console.WriteLine(result);
            #endregion


            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result = ListGenerator.ProductList.FirstOrDefault(x => x.UnitPrice >1000);
            //Console.WriteLine(result);
            #endregion

            #region 3. Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Where(x => x > 5).ElementAt(1); 
            //Console.WriteLine(result);
            //#endregion













            #endregion



            #endregion

            #region LINQ - Aggregate Operator

            #region 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result=Arr.Count(x => x % 2 == 1);
            //Console.WriteLine(result);



            #endregion

            #region 2. Return a list of customers and how many orders each has.
            //var customerOrderCounts = ListGenerator.CustomerList
            //           .Select(customer => new
            //           {
            //               CustomerName = customer.CustomerName,

            //               countoforder = customer.Orders.Count(),


            //           });


            //foreach (var result in customerOrderCounts)
            //{
            //    Console.WriteLine($"Customer: {result.CustomerName} , Orders:{result.countoforder}");
            //}



            #endregion

            #region 3. Return a list of categories and how many products each has


            //var result = (from x in ListGenerator.ProductList
            //              group x by x.Category into g
            //              select new
            //              {
            //                  CategoryName = g.Key,
            //                  ProductCount = g.Count()
            //              });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result= Arr.Count();
            //Console.WriteLine(result);


            #endregion


            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).


            //string filpath = "dictionary_english.txt";
            //string[] words=File.ReadAllLines(filpath);

            //var result = words.Sum(word => word.Length);

            //Console.WriteLine(result);


            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string filepath = "dictionary_english.txt ";

            //string[] words=File.ReadAllLines(filepath);

            //var result=words.Min(x => x.Length);
            //Console.WriteLine(result);

            #endregion


            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string filepath = "dictionary_english.txt ";

            //string[] words = File.ReadAllLines(filepath);

            //var result = words.Max(x => x.Length);
            //Console.WriteLine(result);

            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First)
            //string filepath = "dictionary_english.txt ";

            //string[] words = File.ReadAllLines(filepath);

            //var result = words.Average(x => x.Length);
            //Console.WriteLine(result);

            #endregion

            #region 9. Get the total units in stock for each product category.

            //var result = (from x in ListGenerator.ProductList.Where(x => x.UnitsInStock > 0)
            //              group x by x.Category into g

            //              select new
            //              {

            //                  CategoryName = g.Key,
            //                  totalunitsinstock = g.Count()

            //             });

            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}



            #endregion


            #region 10. Get the cheapest price among each category's products
            //var result = (from x in ListGenerator.ProductList
            //              group x by x.Category into g

            //              select new
            //              {

            //                  CategoryName = g.Key,
            //                  thecheapestprice = g.Min(x => x.UnitPrice)

            //              });


            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion

            #region 12. Get the most expensive price among each category's products.
            //var result = (from x in ListGenerator.ProductList
            //              group x by x.Category into g

            //              select new
            //              {

            //                  CategoryName = g.Key,
            //                  thecheapestprice = g.Max(x => x.UnitPrice)

            //              });


            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}

            #endregion

            #region 13. Get the products with the most expensive price in each category.
            //var result = ListGenerator.ProductList.GroupBy(x => x.Category).Select(p => p.OrderByDescending(x => x.UnitPrice)).FirstOrDefault();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion



            #region 14. Get the average price of each category's products.

            //var result =(from x in ListGenerator.ProductList
            //             group x by x.Category into g
            //             select new 
            //             {
            //                CategoryName= g.Key,
            //                 AveragePrice= g.Average(x=>x.UnitPrice),

            //             });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion




            #endregion

            #region LINQ - Set Operators
            #region 1. Find the unique Category names from Product List

            //var result = ListGenerator.ProductList.Select(x => x.Category).Distinct();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var result01 = ListGenerator.ProductList.Select(x => x.ProductName[0]);
            ////foreach (var item in result01)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //var result02 = ListGenerator.CustomerList.Select(x => x.CustomerName[0]);
            ////foreach (var item in result02)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //var finalresult=result01.Concat(result02).Distinct();
            //foreach (var item in finalresult)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names.

            //var result01 = ListGenerator.ProductList.Select(x => x.ProductName[0]);
            //var result02 = ListGenerator.CustomerList.Select(x => x.CustomerName[0]);
            //var finalresult = result01.Intersect(result02);
            //foreach (var item in finalresult)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var result01 = ListGenerator.ProductList.Select(x => x.ProductName[0]);
            //var result02 = ListGenerator.CustomerList.Select(x => x.CustomerName[0]);
            //var finalresult = result01.Except(result02);
            //foreach (var item in finalresult)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates





            //var result01 = ListGenerator.ProductList.Where(x => x.ProductName.Length >= 3).Select(p => p.ProductName.Substring(p.ProductName.Length - 3));

            //var result02 = ListGenerator.CustomerList.Where(x => x.CustomerName.Length >= 3).Select(p => p.CustomerName.Substring(p.CustomerName.Length-3));
            //var finalresult = result01.Concat(result02);
            //foreach (var item in finalresult)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion













            #endregion

            #region LINQ - Partitioning Operators

            #region 1. Get the first 3 orders from customers in Washington
            //var result = ListGenerator.CustomerList
            //    .Where(x => x.City == "Washington")
            //    .SelectMany(c => c.Orders)
            //    .Take(3);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region 2. Get all but the first 2 orders from customers in Washington.
            //var result = ListGenerator.CustomerList
            //    .Where(x => x.City == "Washington")
            //    .SelectMany(c => c.Orders)
            //    .Skip(2);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.


            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((x, i) => x >= i);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4. Get the elements of the array starting from the first element divisible by 3

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile(x => x % 3 != 0); 

            //foreach (int x in result)
            //{
            //    Console.WriteLine(x); 
            //}
            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile((x, i) => x >= i);
            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #endregion

            #region LINQ - Quantifiers

            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //bool result = words.Any(word => word.Contains("ei"));
            //Console.WriteLine(result ? "At least one word contains 'ei'." : "No word  contains the  'ei'.");

            #endregion


            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var result = ListGenerator.ProductList.GroupBy(x => x.Category).Where(p => p.Any(m => m.UnitsInStock == 0));
            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Category: {group.Key}"); 
            //    foreach (var product in group) 
            //    {
            //        Console.WriteLine($"  {product}");
            //    }
            //}




            #endregion


            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.

            //var result = ListGenerator.ProductList.GroupBy(x => x.Category).Where(p => p.Any(m => m.UnitsInStock != 0));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var i in item) 
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            #endregion



            #endregion

            #region LINQ – Grouping Operators

            #region 1. Use group by to partition a list of numbers by their remainder when divided by 5


            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var result=numbers.GroupBy(x => x %5);

            //foreach (var x in result)
            //{
            //    Console.WriteLine($"Numbers with remainder {x.Key} when divided by 5:");
            //    foreach (var y in x) Console.WriteLine(y);
            //}

            #endregion


            #region Uses group by to partition a list of words by their first letter Use dictionary_english.txt for Input



            #endregion



            #region Consider this Array as an Input

            String[] Arr = { "from", "salt", "earn", " last", "near", "form" };
            var result = Arr.GroupBy(x => new string(x.ToCharArray().OrderBy(d => d).ToArray()));

            foreach (var group in result)
            {
                Console.WriteLine("Group: [" + string.Join(", ", group) + "]");
            }

            #endregion

            #endregion









        }
    }
}
