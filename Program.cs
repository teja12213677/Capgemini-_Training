// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using STUDENTMGMTSYSTEMAPP;
StudentBL sBLObj=new StudentBL();
sBLObj.AcceptStudentDetails();
int t1;
float p1;
sBLObj.CalcResult(out t1,out p1);
sBLObj.CalcTotal();
System.Console.WriteLine($"Total {sBLObj.CalcTotal()}");
System.Console.WriteLine($"Percentage : {p1}");

