// See https://aka.ms/new-console-template for more information
using System;
public class Book{
    public string tittle{set; get;}
    public string author{set; get;}
    public int numPages{set; get;}
    public DateTime dueDate{set; get;}
    public DateTime returnedDate{set; get;}
    
    


public Book(string tittle, string author, int numPages, DateTime dueDate, DateTime returnedDate){
    
    this.tittle=tittle;
    this.author=author;
    this.numPages=numPages;
    this.dueDate=dueDate;
   this.returnedDate=returnedDate;
}
   public double AveragePagesReadPerDay(int daysToRead){
       return numPages/daysToRead;
}
public double CalculateLateFee(double dailyLateFeeRate){
    int daysLate=(returnedDate - dueDate).Days;
    return daysLate*dailyLateFeeRate;
}
}
public class Program{
    public static void Main(String[] args){
        
        Console.WriteLine("Enter the tittle: ");
        string tittle=Console.ReadLine();
        Console.WriteLine("ENter the author: ");
        string author=Console.ReadLine();
        Console.WriteLine("Enter the number of pages: ");
        int numPages=int.Parse(Console.ReadLine());
        Console.WriteLine("ENter the due date: ");
        DateTime dueDate=DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter the return date: ");
        DateTime returnedDate=DateTime.Parse(Console.ReadLine());
         Console.WriteLine("Enter the days to read: ");
         int daysToRead=int.Parse(Console.ReadLine());
         Console.WriteLine("Enter the daily late feerate: ");
         int dailyLateFeeRate=int.Parse(Console.ReadLine());
         Book book=new Book(tittle, author, numPages, dueDate, returnedDate);
         Console.WriteLine("Average Pages Read per day: " + book.AveragePagesReadPerDay(daysToRead));
         Console.WriteLine("Late Fee" + book.CalculateLateFee(dailyLateFeeRate));
         
        
    }
    
}

