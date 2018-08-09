using System;
using System.Linq;
using System.Collections.Generic;

public class Product
{
    public string Title { get; set; }
    public double Price { get; set; }

    public Product (string title, double price)
    {
        this.Title = title;
        this.Price = price;
    }
}

public class Program
{
    public static void Main()
    {
        Spacer();
        Console.WriteLine("     LINQ FUN");
        Spacer();
        StudentInfo();
        Spacer();
        ProductInfo();
        Spacer();
        NumbersWithLambdas();
        Spacer();
    }

    public static void NumbersWithLambdas()
    {
        List<int> numbers = new List<int>() {
            9, -59, 23, 71, -74, 13, 52, 44, 2
        };

        IOrderedEnumerable<int> smallPositiveNumbers = numbers
            .Where(n => n < 40 && n > 0)
            .OrderBy(n => n);

        Boolean allBetweenLarge = numbers.All(n => n > -100 && n < 400);
        Boolean allBetweenSmall = numbers.All(n => n > -5 && n < 39);

        foreach (int number in numbers) {
            Console.WriteLine(number);
        }

        Console.WriteLine($"\nall between large? {allBetweenLarge}");
        Console.WriteLine($"all between small? {allBetweenSmall}");

        IEnumerable<int> addTen = numbers.Select(n => n + 10);

        Console.WriteLine("\nAll Numbers Plus 10:\n");

        foreach (int number in addTen) {
            Console.WriteLine(number);
        }
    }

    public static void Spacer()
    {
        Console.WriteLine("\n**************************************\n");
    }

    public static void ProductInfo()
    {
        List<Product> shoppingCart = new List<Product>() {
            new Product("Bike", 109.99),
            new Product("Mittens", 6.49),
            new Product("Lolllipop", 0.50),
            new Product("Pocket Watch", 584.00)
        };

        IEnumerable<Product> inexpensive = from product in shoppingCart
            where product.Price < 100.00
            orderby product.Price descending
            select product;

        Console.WriteLine("Inexpensive Products:");
        foreach (Product product in inexpensive) {
            Console.WriteLine($"    {product.Title} ${product.Price:f2}");
        }
    }

    public static void StudentInfo() {
        List<int> cohortStudentCount = new List<int>()
        {
            25, 12, 28, 22, 11, 25, 27, 24, 19
        };

        Console.WriteLine($"Largest cohort: {cohortStudentCount.Max()}");
        Console.WriteLine($"Smallest cohort: {cohortStudentCount.Min()}");
        Console.WriteLine($"Total students from all cohorts: {cohortStudentCount.Sum()}");

        IEnumerable<int> idealSizes = from count in cohortStudentCount
            where count < 27 && count > 19
            orderby count ascending
            select count;

        Console.WriteLine($"\nAverage ideal size is {idealSizes.Average()}");
        Console.WriteLine($"There were {idealSizes.Count()} ideally sized cohorts");
        Console.WriteLine($"There have been {cohortStudentCount.Count()} total cohorts");
    }
}
