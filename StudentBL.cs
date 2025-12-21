using System;
using System.Linq.Expressions;
using System.Xml.Schema;
namespace STUDENTMGMTSYSTEMAPP
{

    public class StudentBL
    {
      public Student sObj;
      public StudentBL()
      {
        sObj = new Student();
      }

      public void AcceptStudentDetails()
      {
        try
        {
          Console.WriteLine("Student Management System");
          Console.WriteLine("==========================");
          Console.WriteLine("Enter Roll No: ");
          sObj.RollNo = int.Parse(Console.ReadLine());
          Console.WriteLine("Enter Your name: ");
          sObj.Name = Console.ReadLine();
          Console.WriteLine("Enter Your Address: ");
          sObj.Address = Console.ReadLine();
          Console.WriteLine("Enter Physics Marks: ");
          sObj.phy = int.Parse(Console.ReadLine());
          Console.WriteLine("Enter Chemistry Marks: ");
          sObj.chem = int.Parse(Console.ReadLine());
          Console.WriteLine("Enter Maths Marks: ");
          sObj.math = int.Parse(Console.ReadLine());
        }
        catch (InvalidMarksException e)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
          Console.WriteLine(e.Message);
          Console.ForegroundColor = ConsoleColor.White;
        }
        
      }

      public int CalcTotal()
      {

        sObj.Total = sObj.phy + sObj.chem + sObj.math;
        return sObj.Total;
      }
        public float CalcAvg()
        {
          sObj.Perc = (float)sObj.Total / 3;
          return sObj.Perc;
        }
       public void CalcResult(out int myTotal,out float myPerc)
        {
          myTotal = sObj.phy + sObj.chem + sObj.math;
          myPerc = (float)myTotal / 3;
        }
    }
}
        

