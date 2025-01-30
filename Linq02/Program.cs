using System.Collections;
using static Linq02.ListGenerator;

namespace Linq02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Element Operator

            #region First
            //get first elemnt At sequence

            //var result = ProductList.First();
            //Console.WriteLine(result);

            #endregion

            #region Last
            //get last elemnt At sequence
            //var result = ProductList.Last();
            //Console.WriteLine(result);
            #endregion

            #region FirstOrDefault

            //FirstOrDefault : get the first element in the sequence if the sequenec is empty is return null
            //List<Product> TestList = new List<Product>();
            //var result = TestList.FirstOrDefault();
            //Console.WriteLine(result?.ProductName??"Not Found");

            #endregion

            #region LastOrDefault

            //LastOrDefault : get the Last element in the sequence if the sequenec is empty is return null
            //List<Product> TestList = new List<Product>();
            //var result = TestList.LastOrDefault();
            //Console.WriteLine(result?.ProductName ?? "Not Found");


            #endregion


            #region Element AT -Element At Default
            //Element AT:get the specific element in squence if the sequence is empty is return exeception
            //Element At Default :get the specific element in squence if the sequence is empty is return NULL

            //var result= ProductList.ElementAt(19);

            //Console.WriteLine(result);

            //--------------------------Element At Default-----------------------------
            //var reult = ProductList.ElementAtOrDefault(999999999);
            //Console.WriteLine(reult?.ProductName ?? "Not found");


            #endregion

            #region Single -SingleOrDefault
            //Single: get element with match condition but return execption if the squence is empty or sequence contain more than  element in sequence match condition  
            //var result = ProductList.Single(p=>p.ProductID==21);
            //Console.WriteLine(result);

            //List<Product> TestList = new List<Product>();
            //var result02 = TestList.Single(x=>x.ProductID==50);
            //Console.WriteLine(result02);
            #endregion


            #region SingleOrDefault
            //SingleOrDefault: get element with match condition but return Null if the squence is empty or there are element in sequence match condition  
            //var result = ProductList.SingleOrDefault(p => p.ProductID == 219);
            //Console.WriteLine(result?.ProductName ?? "Not Found ");


            #endregion


            #region Hybrid Syntax 
            //Hybrid Syntax : fluent Syntax + query Syntax
            //var result = (from p in ProductList
            //              where p.UnitsInStock == 0
            //              select new 
            //              { 
            //                  p.ProductID,
            //                  p.UnitPrice,
            //                  p.ProductName,

            //              }).FirstOrDefault();
            //Console.WriteLine(result);
            #endregion





            #endregion


            #region Aggregate Operators

            #region Count
            //var result =ProductList.Count();//list pproperty
            //Console.WriteLine(result);

            //var result = ProductList.Count(x=>x.UnitsInStock==0);//Linq Operator
            //Console.WriteLine(result);
            #endregion

            #region MIN -MAX
            //var result = ProductList.Min();//list pproperty
            //Console.WriteLine(result); //exception

            //var MinLenght = ProductList.Min(p => p.ProductName.Length);
            //Console.WriteLine(MinLenght);

            ////Hybrid syntax
            //var result =(from p in ProductList
            //            where p.ProductName.Length==MinLenght
            // select p).FirstOrDefault();

            //Console.WriteLine(result);

            #endregion

            #region Sum - Avg
            //var result = ProductList.Sum(p => p.UnitPrice);
            //Console.WriteLine(result);

            //var result = ProductList.Average(p => p.UnitPrice);
            //Console.WriteLine(result);
            #endregion

            #region Aggreagte
            //string[] names = { "Bola", "Aml", "Ebram", "Mina", "Youseef" };
            //var result = names.Aggregate((str01, str02) => $"{str01} {str02}");
            ////str01 =Bola ,str02=Aml
            ////str01=bola  aml ,str02=Ebram
            ////str01=bola aml  ebram  str02=Mina
            ////str01=bola aml ebram mina , str02=Youseef
            //Console.WriteLine(result);
            #endregion

            #endregion


            #region Casting (conversion) Operators
            //List<Product> Result = ProductList.Where(x => x.UnitsInStock == 0).ToList();//casting to list 
            //foreach (Product Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}
            //--------------------------------------------------------
            // Product[] Result = ProductList.Where(x => x.UnitsInStock == 0).ToArray();//casting to array
            //foreach (Product Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}
            //---------------------------------------------------------------------------------
            //Dictionary<long, String> result = ProductList.Where(x => x.UnitsInStock == 0).ToDictionary(p=>p.ProductID,p=>p.ProductName);
            //foreach (var item in result)
            //{

            //    Console.WriteLine(item);
            //}
            //------------------------------------------------------------------------------------
            //HashSet<Product> result = ProductList.Where(x => x.UnitsInStock == 0).ToHashSet();
            //foreach (Product product in result)
            //{
            //    Console.WriteLine(product);
            //}
            //------------------------------------------------------------------------------
            // ArrayList obj = new ArrayList() {
            //"mona","omar","Ahmed",
            //    1,
            //    2,
            //    3,
            //    'A',
            //};

            // var result= obj.OfType<int>();
            // foreach (var item in result)
            // {
            //     Console.WriteLine(item);
            // }

            #endregion


            #region Generation Operators
            // AS static method
            #region Range
            //var result =Enumerable.Range(1, 10);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Repeat
            //var result = Enumerable.Repeat(1, 10);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Empty
            //var result = Enumerable.Empty<Product>().ToArray();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion


            #region Set operator
            //union=>without Duplication
            //var seq01 = Enumerable.Range(0, 100);
            //var seq02 = Enumerable.Range(50, 100);

            //var result = seq01.Union(seq02);
            //var result = seq01.Intersect(seq02);
            //var result = seq01.Except(seq02);
            //var result = seq01.Distinct();
            //var result = seq01.Concat(seq02);




            //Console.WriteLine("---------------seq01------------");
            //foreach (var seq in seq01)
            //{
            //    Console.WriteLine($"{seq}\t");
            //}
            //Console.WriteLine("---------------seq01------------");
            //foreach (var seq in seq02)
            //{
            //    Console.WriteLine($"{seq}\t");
            //}
            //Console.WriteLine("---------------union------------");
            //foreach (var seq in result)
            //{
            //    Console.WriteLine($"{seq}\t");
            //}
            #endregion












        }
    }
}
