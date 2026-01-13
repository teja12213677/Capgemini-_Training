
 public class test{
    static void Main(string[] args){
        PhoneCall Cobj=new PhoneCall();
        bool notify = bool.Parse(Console.ReadLine());
        
        Cobj.MakeAPhoneCall(notify);
        Console.WriteLine(Cobj.Message);
    }
}