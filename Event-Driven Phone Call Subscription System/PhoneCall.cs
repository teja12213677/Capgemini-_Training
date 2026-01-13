using System;
public class PhoneCall{
    public delegate void Notify();
    public event Notify PhoneCallEvent;
    
    public string Message{get; private set;}
    
    private void OnSubscribe(){
        Message="Subscribe to Call";
    }
    private void OnUnSubscribe(){
        Message="UnSubscribe to Call";
        
    }
    public void MakeAPhoneCall(bool notify){
      PhoneCallEvent=null;
        if(notify)
        {
           PhoneCallEvent += OnSubscribe;
        }
        else{
            PhoneCallEvent += OnUnSubscribe;
        }
        PhoneCallEvent?.Invoke();
        
    }
}