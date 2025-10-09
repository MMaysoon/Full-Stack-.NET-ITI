using Lab_01_Solution;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using static Lab_01_Solution.ListGenerators;
using static System.Runtime.InteropServices.JavaScript.JSType;

#region Restriction Operators
// 1.
Console.WriteLine("\n\n______________all products that are out of stock______________");
var r1 = ProductList.Where(x => x.UnitsInStock == 0);
foreach (var x in r1)
{
    Console.WriteLine(x);
}

// 2.
Console.WriteLine("\n\n________all products that are in stock and cost more than 3.00 per unit____________");
var r2 = ProductList.Where(x => (x.UnitsInStock > 0) && (x.UnitPrice > 3.00m));
foreach (var x in r2)
{
    Console.WriteLine(x);
}

// 3.
Console.WriteLine("\n\n___________digits whose name is shorter than their value_____________");
string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
var r3 = Arr.Where((x,index) => x.Length<index);
foreach (var x in r3)
    { Console.WriteLine(x); }
#endregion

#region Element Operators
//1.
Console.WriteLine("\n\n___________first Product out of Stock___________");
var r4 = ProductList.FirstOrDefault(x => x.UnitsInStock == 0);
Console.WriteLine(r4!= null?r4:"Not Found");


//2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
Console.WriteLine("\n\n___________first product whose Price > 1000____________");
var r5 = ProductList.SingleOrDefault(x => x.UnitPrice > 1000);
Console.WriteLine(r5 != null ? r5 : "Not Found");

//3. 
Console.WriteLine("\n\n___________second number greater than 5____________");
int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var r6 = Arr2.Where(x => x > 5).ElementAtOrDefault(1);
Console.WriteLine(r6);

#endregion


#region Set Operators
//1.
Console.WriteLine("\n\n___________unique Category names from Product List______________");
var r7 = ProductList.Select(x=>x.Category).Distinct();
foreach(var  x in r7)
    { Console.WriteLine(x); }


//2.
Console.WriteLine("\n\n_________Sequence containing the unique first letter from both product and customer names__________");
var s1 = ProductList.Select(x => x.ProductName[0]);
var s2=CustomerList.Select(x=>x.CompanyName[0] );
var r8=s1.Union(s2).OrderBy(ch=>ch);
Console.WriteLine(string.Join(" , " ,r8));

//3.
Console.WriteLine("\n\n_________sequence that contains the common first letter from both product and customer names_________");
var r9 = s1.Intersect(s2).OrderBy(ch => ch);
Console.WriteLine(string.Join(" , ", r9));

//4. 
Console.WriteLine("\n\n_________sequence that contains the first letters of product names that are not also first letters of customer names._______");
var r10 = s1.Except(s2).OrderBy(ch => ch);
Console.WriteLine(string.Join(" , ", r10));

//5. Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates
Console.WriteLine("\n\n_________unique Category names from Product List___________");
var s3=ProductList.Select (x=>x.ProductName.Substring(x.ProductName.Length-3));  //maysoon 7-3=4  oon
var s4=CustomerList.Select(x=>x.CompanyName.Substring(x.CompanyName.Length-3));
var r11=s3.Concat(s4);  //with duplicate
Console.WriteLine(string.Join(" , ",r11));

#endregion

#region Aggregate Operators
//1.get the number of odd numbers in the array
Console.WriteLine("\n\n_____number of odd numbers in the array_____");
int[] Arr3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var r12 = Arr3.Where(x => x % 2 == 1).Count();
Console.WriteLine($"number of odd numbers : {r12}");

//2.Return a list of customers and how many orders each has.
Console.WriteLine("\n\n_____list of customers and how many orders each has_____");
var r13 = CustomerList.Select(c => new {CustomerName= c.CompanyName, OrderCount=c.Orders.Length });
foreach(var x in r13)
{
    Console.WriteLine(x);
}


//3. Return a list of categories and how many products each has
Console.WriteLine("\n\n_____list of categories and how many products each has_____");
var r14 = ProductList.GroupBy(x => x.Category).Select(c=>new {Category=c.Key , ProductCount=c.Count()});
foreach(var x in r14)
    { Console.WriteLine(x); }

//4. Get the total of the numbers in an array.
Console.WriteLine("\n\n___Get the total of the numbers in an array___");
int[] Arr4 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var r15 = Arr4.Count();

//5.Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
Console.WriteLine("\n\n___total number of characters of all words in dictionary_english.txt__");
string[] words = File.ReadAllLines("C:\\Users\\user\\Desktop\\ITI\\Linq\\Day_01\\Lab_01\\dictionary_english.txt");
int totalChars =words.Sum(x=>x.Length);
Console.WriteLine(totalChars);


//6. Get the total units in stock for each product category.
Console.WriteLine("\n\n___total units in stock for each product category.___");
var r16 = ProductList.GroupBy(p => p.Category).Select(c => new { CategoryName = c.Key, TotalUnitInStock = c.Sum(p => p.UnitsInStock) });
foreach(var x in r16) {  Console.WriteLine(x); }

//7. Get the length of the shortest word in dictionary_english.txt 
Console.WriteLine("\n\n___length of the shortest word in dictionary_english___");
var r17 = words.OrderBy(x=>x.Length).FirstOrDefault();
Console.WriteLine(r17.Length);

//8. Get the cheapest price among each category's products
Console.WriteLine("\n\n___cheapest price among each category's products___");
var r18 = ProductList.GroupBy(p => p.Category).Select(c =>new { CategoryName = c.Key, MinUnitPricePerCategory = c.Min(p => p.UnitPrice) });
foreach(var x in r18) { Console.WriteLine(x.ToString()); }


//9. Get the products with the cheapest price in each category (Use Let)
// Query syntex
Console.WriteLine("\n\n___products with the cheapest price in each category___");
var r19 = from p in ProductList
          group p by p.Category into CategoryGroup    // 1.Groupby Category
          let minPrice = CategoryGroup.Min(c => c.UnitPrice)  //2.Get Each Cactory with less unitPrice
          from p in CategoryGroup
          where p.UnitPrice == minPrice
          select new
          {
              Category = CategoryGroup.Key,
              ProductName = p.ProductName,
              UnitPrice = p.UnitPrice,
          };
foreach (var x in r19) { Console.WriteLine(x); }

// Method Sytex
//var r20 = ProductList.GroupBy(p => p.Category)
//                   .Select(g => g.OrderBy(p => p.UnitPrice).FirstOrDefault());
//foreach (var x in r20) { Console.WriteLine($"{x.Category} | {x.ProductName} | {x.UnitPrice}"); }

//10. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
Console.WriteLine("\n\n___length of the longest word in dictionary_english___");
var r21 = words.OrderByDescending(x => x.Length).FirstOrDefault();
Console.WriteLine(r21.Length);

//11. Get the most expensive price among each category's products.
Console.WriteLine("\n\n___most expensive price among each category's products__");
var r22 = ProductList.GroupBy(p => p.Category).Select(c => new { CategoryName = c.Key, UnitPrice = c.Max(p => p.UnitPrice) });
foreach (var x in r22) { Console.WriteLine(x); }

//12. Get the products with the most expensive price in each category.
Console.WriteLine("\n\n___products with the most expensive price in each category___");
var r23=ProductList.GroupBy(p=>p.Category)
                    .Select(g=>g.OrderByDescending(p=>p.UnitPrice).FirstOrDefault());
foreach (var x in r23) { Console.WriteLine($"{{ Category:{x.Category} ,ProductName: {x.ProductName} ,UnitPrice: {x.UnitPrice} }} "); }

//13. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
Console.WriteLine("\n\n___average length of the words in dictionary_english___");
var r24 = words.Average(x=>x.Length);
Console.WriteLine(r24);

//14. Get the average price of each category's products.
Console.WriteLine("\n\n___average price of each category's products___");
var r25=ProductList.GroupBy(p=>p.Category).Select(c=>new { CategoryName=c.Key,CategoryAveragePrice=c.Average(p => p.UnitPrice) });
foreach (var x in r25) { Console.WriteLine(x); }


#endregion

#region Ordering Operators
//1.Sort a list of products by name
Console.WriteLine("\n\n___Sort a list of products by name___");
var r26 = ProductList.OrderBy(p => p.ProductName);
foreach (var x in r26) { Console.WriteLine(x); }

//2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
Console.WriteLine("\n\n___custom comparer to do a case-insensitive sort of the words in an array___");
string[] Arr5 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
Array.Sort(Arr5, StringComparer.OrdinalIgnoreCase);
foreach (var word in Arr5) { Console.Write(word+"  "); }
Console.WriteLine();

//3.Sort a list of products by units in stock from highest to lowest.
Console.WriteLine("\n\n___list of products by units in stock from highest to lowest.___");
var r27 = ProductList.OrderByDescending(p => p.UnitsInStock);
foreach(var x in r27){ Console.WriteLine(x); }

//4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
Console.WriteLine("\n\n___Sort a list of digits, first by length of their name, and then alphabetically by the name itself___");
string[] Arr6 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
var r28 = Arr6.OrderBy(x => x.Length).ThenBy(x => x);
foreach(var x in r28) { Console.Write(x,"  "); }
Console.WriteLine();

//5.Sort first by word length and then by a case-insensitive sort of the words in an array.
Console.WriteLine("\n\n__Sort first by word length and then by a case-insensitive sort of the words in an array___");
string[] words_1 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
var r29=words_1.OrderBy(x=>x.Length).ThenBy(x => x,StringComparer.OrdinalIgnoreCase);
foreach (var x in r29) { Console.Write(x+"  "); }
Console.WriteLine();

//6.Sort a list of products, first by category, and then by unit price, from highest to lowest.
Console.WriteLine("\n\n___.Sort a list of products, first by category, and then by unit price, from highest to lowest___");
var r30 = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
foreach(var x in r30) {  Console.WriteLine(x); }

//7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.
Console.WriteLine("\n\n__Sort first by word length and then by a case-insensitive sort of the words in an array___");
string[] words_2 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
var r31 = words_1.OrderBy(x => x.Length).ThenByDescending(x => x, StringComparer.OrdinalIgnoreCase);
foreach (var x in r31) { Console.Write(x + "  "); }
Console.WriteLine();

//8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
Console.WriteLine("\n\n___list of all digits in the array whose second letter is 'i' that is reversed___");
string[] Arr7 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
var r32 = Arr7.Where(w => w[1]=='i').Reverse();
foreach (var x in r32) { Console.Write(x + "  "); }
Console.WriteLine();

#endregion

#region Partitioning Operators
//1.Get the first 3 orders from customers in Washington
Console.WriteLine("\n\n___the first 3 orders from customers in Washington___");
var r33 = CustomerList.Where(x => x.Country == "Washington").SelectMany(o=>o.Orders).Take(3);
foreach (var x in r33) { Console.WriteLine(x); }

//2. Get all but the first 2 orders from customers in Washington.
Console.WriteLine("\n\n___Get all but the first 2 orders from customers in Washington___");
var r34 = CustomerList.Where(x => x.Country == "Washington").SelectMany(o => o.Orders).Skip(2);
foreach (var x in r34) { Console.WriteLine(x); }

//3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
Console.WriteLine("\n\n___Num > Index___");
int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var r35 = numbers.TakeWhile((num, index) => num > index);
foreach (var x in r35) {Console.Write(x+"  "); }
Console.WriteLine();

//4.Get the elements of the array starting from the first element divisible by 3.
Console.WriteLine("\n\n___Element Divide by 3___");
int[] numbers_2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var r36 = numbers_2.Where(n =>n>0 && n % 3 == 0);
foreach (var x in r36) { Console.Write(x + "  "); }
Console.WriteLine();

//5.Get the elements of the array starting from the first element less than its position.
Console.WriteLine("\n\n___Element Less than poistion___");
int[] numbers_3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var r37 = numbers_2.SkipWhile((num,index)=>num>=index);
foreach (var x in r36) { Console.Write(x + "  "); }
Console.WriteLine();
#endregion


#region Projection Operators
//1.Return a sequence of just the names of a list of products.
Console.WriteLine("\n\n___sequence of just the names of a list of products.___");
var r38 = ProductList.Select(x => x.ProductName);
foreach (var x in r38) { Console.Write(x + "  "); }
Console.WriteLine();

//2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
Console.WriteLine("\n\n___ sequence of the uppercase and lowercase versions of each word in the original array___");
string[] words_3 = { "aPPLE", "BlUeBeRrY", "cHeRry" };
var r39=words_3.Select(w => new {UpperCase=w.ToUpper(), LowerCase=w.ToLower()});
foreach(var x in r39) { Console.WriteLine(x); }


//3.Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
Console.WriteLine("\n\n__sequence containing some properties of Products___");
var r40 = ProductList.Select(p => new
{
    Name = p.ProductName,
    Category = p.Category,
    Price = p.UnitPrice
});
foreach (var x in r40) { Console.WriteLine(x); }

//4. Determine if the value of ints in an array match their position in the array.
Console.WriteLine("\n\n___Number: In - place ?___");
int[] Arr8 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var r41 = Arr8.Select((n,index) => new { Number=n, InPlace= n==index });
foreach(var x in r41) { Console.WriteLine(x); }

//5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
Console.WriteLine("\n\n___Pairs where a < b:___");
int[] a = { 0, 2, 4, 5, 6, 8, 9 };
int[] b = { 1, 3, 5, 7, 8 };
var r42=a.SelectMany(x=>b,(x,y)=> new {A=x,B=y})
         .Where(pair=>pair.A<pair.B);
foreach(var x in r42) {Console.WriteLine(x); }

//6.Select all orders where the order total is less than 500.00.
Console.WriteLine("\n\n___all orders where the order total is less than 500.00.__");
var r43 = CustomerList.SelectMany(c => c.Orders, (customer, order) => new { customer.CustomerID, order.OrderID, order.Total })
    .Where(x => x.Total < 500.00M);
foreach(var x in r43) { Console.WriteLine(x); }

//7. Select all orders where the order was made in 1998 or later.
Console.WriteLine("\n\n___all orders where the order was made in 1998 or later__");
var r44 = CustomerList.SelectMany(c => c.Orders, (customer, order) => new { customer.CustomerID, order.OrderID, order.OrderDate })
    .Where(x => x.OrderDate.Year>=1998);
foreach (var x in r44) { Console.WriteLine(x); }

#endregion

#region Quantifiers
//1.Determine if any of the words in dictionary_english.txt contain the substring 'ei'.
Console.WriteLine("\n\n___ Any word in dictionary_english.txt contain the substring 'ei'.___");
var r45 = words.Any(w => w.Contains("ei"));
Console.WriteLine(r45);


//2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
Console.WriteLine("\n\n___ grouped a list of products only for categories that have at least one product that is out of stock___");
var r46 = ProductList.GroupBy(p => p.Category).Where(g => g.Any(p => p.UnitsInStock == 0));
foreach (var group in r46)
{
    Console.WriteLine(group.Key);
    foreach (var product in group)
    {
        Console.WriteLine($"   {product.ProductName} - {product.UnitsInStock} in stock");
    }

}

//3. Return a grouped a list of products only for categories that have all of their products in stock.
Console.WriteLine("\n\n___Categories where all products are in stock___");

var r47 = ProductList
    .GroupBy(p => p.Category)
    .Where(g => g.All(p => p.UnitsInStock > 0));

foreach (var group in r47)
{
    Console.WriteLine($"Category: {group.Key}");
    foreach (var product in group)
    {
        Console.WriteLine($"   {product.ProductName} - {product.UnitsInStock} in stock");
    }
}


#endregion

#region Grouping Operators

//1. Use group by to partition a list of numbers by their remainder when divided by 5
Console.WriteLine("\n\n___group by to partition a list of numbers by their remainder when divided by 5___");
int[] numbers_4 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
var r48= numbers.GroupBy(n => n % 5);

foreach (var group in r48)
{
    Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5:");
    foreach (var number in group)
    {
        Console.WriteLine(number);
    }
    Console.WriteLine();
}




//2.Uses group by to partition a list of words by their first letter.
Console.WriteLine("\n\n___Uses group by to partition a list of words by their first letter.___");
var r49 = words
    .GroupBy(w => char.ToUpper(w.Trim()[0]))
    .OrderBy(g => g.Key);

foreach (var group in r49)
{
    Console.WriteLine($"\nWords starting with '{group.Key}':");
    foreach (var word in group.Take(5))
    {
        Console.WriteLine(word);
    }
}

//3. Consider this Array as an Input 
Console.WriteLine("\n\n___Group by Same Words (Ignore order chars___");
string[] Arr9 = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };

var grouped = Arr9
    .Select(w => w.Trim().ToLower())
    .GroupBy(w => System.String.Concat(w.OrderBy(c => c))) // sort letters inside each word
    .ToList();

foreach (var group in grouped)
{
    Console.WriteLine("Group:");
    foreach (var word in group)
    {
        Console.WriteLine(word);
    }
    Console.WriteLine();
}

#endregion
Console.ReadLine();